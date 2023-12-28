using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    public static int grappleCheck;
    public ShootGun shootGun;
    private LineRenderer lr;
    private Vector3 grapplePoint;
    private BreakableObject breakableObject;
    public LayerMask whatIsGrappleable;
    public Transform gunTip, player;
    private Rigidbody playerRigidbody;
    private Transform grappledObject;
    private float initialDistance;
    private Animator _animator;

    
    public float grappleRadius = 1f; // Adjust this radius to your needs
    private SpringJoint joint;
    public float damageAmount = 5f;
    public static int IsSwinging;
    private float maxAllowedDistance = 2f;
    public GameObject rangePrefab;
    private GameObject currentRangeIndicator;


    private void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        
        if (UserInput.instance.controls.playerControls.GrappleGun.WasPressedThisFrame())
        {
            if (shootGun.eggToShoot)
            {
            return;
            }
            StartGrapple();
            grappleCheck = 1;
            
        }
        else if (UserInput.instance.controls.playerControls.GrappleGun.WasReleasedThisFrame())
        {
            StopGrapple();
            grappleCheck = 0;
            if (currentRangeIndicator != null)
            {
                Destroy(currentRangeIndicator);
            }
        }
        else if (IsGrappling())
        {
            DrawRope();
        }
    }

    // Called after Update
    void LateUpdate()
    {
        DrawRope();

        if (IsGrappling() && grappledObject)
        {
            // Calculate the direction vector between the player and grapple point
            Vector3 grappleDirection = grapplePoint - player.position;

            // Maintain a fixed distance from the grapple point, if needed
            if (grappleDirection.magnitude > maxAllowedDistance)
            {
                player.position = grapplePoint - grappleDirection.normalized * maxAllowedDistance;
            }

            // Update the grapple point's position
            grapplePoint = grappledObject.position;

            // Set the connected anchor of the spring joint to the updated grapple point
            joint.connectedAnchor = grapplePoint;
        }
        if (UserInput.instance.controls.playerControls.GrappleGun.WasReleasedThisFrame() )
        {
            ApplyDamageToBreakableObject();
        }
        if (IsGrappling())
        {
          //  playerRigidbody.velocity += Physics.gravity * Time.deltaTime;
        }
    }

    void ApplyDamageToBreakableObject()
    {
        if (breakableObject == null)
        {
            return;
        }
        else if (breakableObject.CompareTag("NewApple"))
        {
            breakableObject.ApplyDamage(damageAmount);
            // Set eggToShoot to true
            shootGun.eggToShoot = true;
            breakableObject = null;
        }
        else 
        { 
            breakableObject.ApplyDamage(damageAmount);
            breakableObject = null;
        }
    }

    void SetupGrappleVisualEffect()
    {
        _animator.SetTrigger("start");

    }




    void StartGrapple()
    {
        Collider[] hitColliders = Physics.OverlapSphere(gunTip.position, grappleRadius, whatIsGrappleable);


        if (hitColliders.Length == 0)
        {
            currentRangeIndicator = Instantiate(rangePrefab, player.position, Quaternion.identity);
            currentRangeIndicator.transform.parent = player;
            SetupGrappleVisualEffect();
        }

        foreach (var hitCollider in hitColliders)
        {
       
            // Get the closest point on the detected object
            grapplePoint = hitCollider.ClosestPoint(gunTip.position);

            // Set up the grapple without checking if it's breakable
            SetupGrapple();

            // Indicate that you are swinging
            IsSwinging = 1;
            initialDistance = Vector3.Distance(player.position, grapplePoint);
            grappledObject = hitCollider.transform;

            BreakableObject collidedObject = hitCollider.GetComponent<BreakableObject>();
            if (collidedObject != null)
            {
                breakableObject = collidedObject;
            }
       

            // Break out of the loop after grappling to the first valid object
            break;
        }
    }
    void SetupGrapple()
    {
        joint = player.gameObject.AddComponent<SpringJoint>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedAnchor = grapplePoint;

        // Set up SpringJoint properties (adjust these as needed)
        joint.maxDistance = 0.85f;
        joint.minDistance = 0.5f;
        joint.spring = 1.5f;
        joint.damper = 7f;
        joint.massScale = 100f;

        lr.positionCount = 2;
    }

    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
        IsSwinging = 0;

        _animator.SetTrigger("exit");
    }

    private Vector3 currentGrapplePosition;

    void DrawRope()
    {
        if (!IsGrappling() || joint == null)
        {
            return;
        }

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 6f);
        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, currentGrapplePosition);
        
    }

    public bool IsGrappling()
    {
        return joint != null;
    }

    public Vector3 GetGrapplePoint()
    {
        return grapplePoint;
    }
}
