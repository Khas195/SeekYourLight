using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MovementData", menuName ="Data/Movement", order = 1)]
public class MovementData : ScriptableObject
{
    public float crouchSpeed = 5;
    public float walkSpeed = 10;
    public float runSpeed = 20;
    public float jumpForce = 50;
}
