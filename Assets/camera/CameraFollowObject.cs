using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    [Header ("References")]
    [SerializeField] private Transform playerTransform;

    [Header ("Flip Rotation Stats")]
    [SerializeField] private float flipYRotationTime = 0.5f;

    private Coroutine _turnCoroutine;

    private player _player;

    private bool _FaceRight;

    // Start is called before the first frame update
      private void Awake()
    {
        _player = playerTransform.gameObject.GetComponent<player>();

        _FaceRight = _player.FaceRight;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position;
    }

  
    public void CallTurn()
    {
        _turnCoroutine = StartCoroutine(FlipYLerp());

       //LeanTween.rotateY(gameObject,DetermineEndRotation(),flipYRotationTime).setEaseInOutSine();

        
    }

    private IEnumerator FlipYLerp()
    {
        float startRotation = transform.localEulerAngles.y;
        float endRotation = DetermineEndRotation();
        float yRotation = 10f;

        float elapsedTime = 0f;
        while (elapsedTime < endRotation)
        {
            elapsedTime += Time.deltaTime;

            yRotation = Mathf.Lerp(startRotation, endRotation,(elapsedTime/flipYRotationTime));
            transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
            yield return null;
        }
    }

    private float DetermineEndRotation()
    {
        _FaceRight=!_FaceRight;
        if(_FaceRight )
        {
            return 180f;
        }
        else
        {
            return 0f;
        }
    }
}
