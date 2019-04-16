using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FirstPersonCameraData", menuName = "Data/CameraData", order = 1)]
public class FirstPersonCameraData  : ScriptableObject 
{
    public float sensitivity ;
    public float headLowerLimit = -80f;
    public float headUpperLimit = 85f;
}

