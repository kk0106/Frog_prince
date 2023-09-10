using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleHook : MonoBehaviour
{
    public Transform _grapplingHook;
    public Transform _handPos;
    public Transform _playerBody;
    public LayerMask _grappleLayer;
    public float _maxGrappleDistance;
    public float _hookSpeed;
    public float _swingForce = 5.0f; // Adjust the swing force as needed

    bool freeze;
    public Rigidbody rb;

    private Vector3 _hookPoint;
    public Vector3 _offset;

    private bool isShooting;
    private bool isGrappling;

    public LineRenderer _lineRenderer;
    public Transform _hookEndPoint;

    public KeyCode grappleKey = KeyCode.E; // Assign your desired button input here

    private float initialGrappleDistance; // Store the initial distance to the hook point

    void Awake()
    {
        // Initialize _grappleLayer in Awake
        _grappleLayer = LayerMask.GetMask("YourLayerName");
    }

    void Start()
    {
        isGrappling = false;
        isShooting = false;
        _lineRenderer.enabled = false;
    }

    void Update()
    {
        if (freeze)
        {
            rb.velocity = Vector3.zero;
        }

        if (isGrappling)
        {
            // Calculate the current distance to the hook point
            float currentGrappleDistance = Vector3.Distance(_grapplingHook.position, _hookPoint);

            // Calculate the direction from the player to the hook point
            Vector3 grappleDirection = (_hookPoint - _playerBody.position).normalized;

            // Apply a force in the direction of the grapple to simulate swinging
            rb.AddForce(grappleDirection * _swingForce);

            // Release the grapple when the player jumps
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ReleaseGrapple();
            }
        }

        // Check for input to shoot the grappling hook
        if (Input.GetKeyDown(grappleKey) && !isShooting && !isGrappling)
        {
            isShooting = true;
            // Check for nearby hookable objects on the grapple layer
            Collider[] colliders = Physics.OverlapSphere(transform.position, _maxGrappleDistance, _grappleLayer);
            if (colliders.Length > 0)
            {
                // Choose the closest hookable object (you can implement your own logic here)
                Collider closestCollider = colliders[0];
                float closestDistance = Vector3.Distance(transform.position, closestCollider.transform.position);

                foreach (Collider col in colliders)
                {
                    // Check if the detected object is on the grapple layer
                    if (col.gameObject.layer == _grappleLayer)
                    {
                        float distance = Vector3.Distance(transform.position, col.transform.position);
                        if (distance < closestDistance)
                        {
                            closestCollider = col;
                            closestDistance = distance;
                        }
                    }
                }

                _hookPoint = closestCollider.transform.position;
                initialGrappleDistance = Vector3.Distance(transform.position, _hookPoint); // Store the initial distance
                isGrappling = true;
                _grapplingHook.parent = null;
                _grapplingHook.LookAt(_hookPoint);
                _lineRenderer.enabled = true;
            }
            isShooting = false;
        }
    }

    // New method to release the grapple
    void ReleaseGrapple()
    {
        isGrappling = false;
        _grapplingHook.SetParent(_handPos);
        _lineRenderer.enabled = false;
    }

    private void LateUpdate()
    {
        if (_lineRenderer.enabled)
        {
            _lineRenderer.SetPosition(0, _hookEndPoint.position);
            _lineRenderer.SetPosition(1, _handPos.position);
        }
    }
}
