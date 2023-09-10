using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable;
    public Transform gunTip, player;

    private float maxDistance = 100f;
    private float grappleRadius = 1.0f; // Adjust this radius to your needs
    private SpringJoint joint;

    int numberOfRays = 10; // Adjust the number of rays as needed
    float coneAngle = 30f; // Adjust the cone angle as needed

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }
    }

    // Called after Update
    void LateUpdate()
    {
        DrawRope();
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
        joint = player.gameObject.AddComponent<SpringJoint>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedAnchor = grapplePoint;

        // Set up SpringJoint properties (adjust these as needed)
        joint.maxDistance = Vector3.Distance(player.position, grapplePoint) * 0.8f;
        joint.minDistance = Vector3.Distance(player.position, grapplePoint) * 0.25f;
        joint.spring = 4.5f;
        joint.damper = 7f;
        joint.massScale = 4.5f;

        lr.positionCount = 2;
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
        // If not grappling, don't draw rope
        if (!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 8f);

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
