using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    public static int grappleCheck;

    private LineRenderer lr;
    private Vector3 grapplePoint;
    private BreakableObject breakableObject;
    public LayerMask whatIsGrappleable;
    public Transform gunTip, player;

    private float maxDistance = 1.5f;
    private float grappleRadius = 1.0f; // Adjust this radius to your needs
    private SpringJoint joint;
    public float damageAmount = 5f;

    int numberOfRays = 18; // Adjust the number of rays as needed
    float coneAngle = 0f; // Adjust the cone angle as needed


    private void Start()
    {
      
    }
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (UserInput.instance.controls.playerControls.GrappleGun.WasPressedThisFrame())
        {
            
            StartGrapple();
            grappleCheck = 1;
        }
        else if (UserInput.instance.controls.playerControls.GrappleGun.WasReleasedThisFrame())
        {
            StopGrapple();
            grappleCheck = 0;
        }
        else if (IsGrappling())
        {
            DrawRope(); // Draw the rope and continue applying damage here
        }
    }
    // Called after Update
    void LateUpdate()
    {
        DrawRope();

        // Check if the player is retracting the grapple
        if (UserInput.instance.controls.playerControls.GrappleGun.WasReleasedThisFrame() && IsGrappling())
        {
            ApplyDamageToBreakableObject();
        }
    }

    // Call this method to apply damage to the breakable object
    void ApplyDamageToBreakableObject()
    {
        if (IsGrappling() && breakableObject != null)
        {
            // Apply damage to the breakable object
            breakableObject.ApplyDamage(damageAmount);

            // Log a message to the console
            Debug.Log("Damage Applied: " + damageAmount);
        }
    }

    /// <summary>
    /// Call whenever we want to start a grapple
    /// </summary>
    void StartGrapple()
    {
        // Perform multiple raycasts in a cone pattern
        for (int i = 0; i < numberOfRays; i++)
        {
            float angle = (-coneAngle / 2f) + (i * (coneAngle / (float)(numberOfRays - 1)));
            Vector3 rayDirection = Quaternion.Euler(0, angle, 0) * gunTip.forward;

            if (Physics.SphereCast(gunTip.position, grappleRadius, rayDirection, out RaycastHit hit, maxDistance, whatIsGrappleable))
            {
                grapplePoint = hit.point;
                // Rest of the grapple logic...
                SetupGrapple();
                break; // Break out of the loop if a grapple point is found
            }
        }
        
       
    }

    /// <summary>
    /// Set up the SpringJoint and LineRenderer for grappling
    /// </summary>
    void SetupGrapple()
    {
        RaycastHit hit;
        // Use your existing SphereCast here
        if (Physics.SphereCast(gunTip.position, grappleRadius, gunTip.forward, out hit, maxDistance, whatIsGrappleable))
        {
            // Attempt to find a BreakableObject component on the collided object
            BreakableObject collidedObject = hit.collider.GetComponent<BreakableObject>();

            if (collidedObject != null)
            {
                breakableObject = collidedObject;
            }
            else
            {
                // If the collided object doesn't have a BreakableObject component, clear the reference
                breakableObject = null;
            }

            grapplePoint = hit.point;

            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            // Set up SpringJoint properties (adjust these as needed)
            joint.maxDistance = Vector3.Distance(player.position, grapplePoint) * 0.8f;
            joint.minDistance = Vector3.Distance(player.position, grapplePoint) * 0.25f;
            joint.spring = 2f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

            lr.positionCount = 2;
        }
    }



    /// <summary>
    /// Call whenever we want to stop a grapple
    /// </summary>
    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }

    private Vector3 currentGrapplePosition;

    void DrawRope()
    {
        // If not grappling or the joint is null, don't draw rope
        if (!IsGrappling() || joint == null)
        {
            // Reset the breakableObject reference to null
            breakableObject = null;
            return;
        }

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 8f);

        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, currentGrapplePosition);

        // Check if we have a reference to the breakable object
        if (breakableObject == null)
        {
            // Attempt to find the connected breakable object
            if (joint.connectedBody != null)
            {
                breakableObject = joint.connectedBody.GetComponent<BreakableObject>();
            }
        }

        // Ensure the breakableObject is not null before applying damage
        if (breakableObject != null)
        {
            // Adjust damageAmount as needed
            breakableObject.ApplyDamage(damageAmount);
        }
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
