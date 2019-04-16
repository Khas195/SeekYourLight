using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField]
    FirstPersonCameraData cameraData = null;
    
    [SerializeField]
    Transform pitchPivot = null;
    [SerializeField]
    Transform yawnPivot = null;
    float curPitch;
    [SerializeField]
    CursorLockMode wantedMode = CursorLockMode.None;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = wantedMode;
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }

    // Update is called once per frame
    void Update()
    {
        var yawn = Input.GetAxis("Mouse X") * cameraData.sensitivity * Time.deltaTime;
        yawnPivot.Rotate(Vector3.up * yawn );
        var pitch = Input.GetAxis("Mouse Y") * cameraData.sensitivity * Time.deltaTime;
        curPitch += pitch;
        if (curPitch > cameraData.headUpperLimit)
        {
            curPitch = cameraData.headUpperLimit;
            pitch = 0;
        } else if (curPitch < cameraData.headLowerLimit)  {
            curPitch = cameraData.headLowerLimit;
            pitch = 0;
        }
        pitchPivot.Rotate(Vector3.left* pitch );

    }
}
