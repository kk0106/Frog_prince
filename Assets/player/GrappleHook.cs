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

    bool freeze;
    public Rigidbody rb;

    private Vector3 _hookPoint;
    public Vector3 _offset;
    public Camera cam;
    public float _hookSpeed;

    private bool isShooting;
    private bool isGrappling;

    public LineRenderer _lineRenderer;
    public Transform _hookEndPoint;
    // Start is called before the first frame update
    void Start()
    {
        isGrappling = false;
        isShooting = false;
        _lineRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (freeze)
        {
            rb.velocity = Vector3.zero;

        }

        if (Input.GetMouseButtonDown(0))
        {
            ShootHook();
        }

        if (isGrappling)
        {
            _grapplingHook.position = Vector3.Lerp(_grapplingHook.position, _hookPoint, _hookSpeed * Time.deltaTime);
            if (Vector3.Distance(_grapplingHook.position, _hookPoint) < 0.5f)
            {
                freeze = true;
                _playerBody.position = Vector3.Lerp(_playerBody.position, _hookPoint - _offset, _hookSpeed * Time.deltaTime);

                if (Vector3.Distance(_playerBody.position, _hookPoint - _offset) < 0.5f)
                {
                    freeze = false;
                    isGrappling = false;
                    _grapplingHook.SetParent(_handPos);
                    _lineRenderer.enabled = false;

                }
            }
        }
    }


    private void LateUpdate()
    {
        if (_lineRenderer.enabled)
        {
            _lineRenderer.SetPosition(0, _hookEndPoint.position);
            _lineRenderer.SetPosition(1, _handPos.position);
        }
    }
        private void ShootHook() 
        {
            if (isShooting || isGrappling) return;
            isShooting = true;
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, _maxGrappleDistance, _grappleLayer))
            {
                _hookPoint = hit.point;
                isGrappling = true;
                _grapplingHook.parent = null;
                _grapplingHook.LookAt(_hookPoint);
                //print("hit");
                _lineRenderer.enabled = true;
            }
            isShooting = false;
        }

    
}