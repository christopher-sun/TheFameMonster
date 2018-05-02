using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float lookSmooth = 0.09f;
    public Vector3 offsetFromTarget = new Vector3(0, 6, -8);
    public float xTilt = 10;

    Vector3 dest = Vector3.zero;
    CharacterController charController;
    float rotateVel = 0;

    // Use this for initialization
    void Start()
    {
        SetCameraTarget(target);
    }

    void SetCameraTarget(Transform t)
    {
        target = t;
        if (target != null)
        {
            if(target.GetComponent<CharacterController>())
            {
                charController = target.GetComponent<CharacterController>();
            } else
            {
                Debug.LogError("Target needs a char controller");
            }
        } else
        {
            Debug.LogError("Add a cam target!");
        }
    }

    private void LateUpdate()
    {
        //moving
        MoveToTarget();
        //rotating
        LookAtTarget();
    }

    void MoveToTarget()
    {
        //move cam behind the target
        dest = charController.TargetRotation * offsetFromTarget;
        dest += target.position;
        transform.position = dest;
    } 

    void LookAtTarget()
    {
        float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y,
            ref rotateVel, lookSmooth);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle, 0);
    }
}