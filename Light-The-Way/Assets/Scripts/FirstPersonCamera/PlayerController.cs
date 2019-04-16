using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Movement moveBehavior = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        moveBehavior.Move((int)vertical, (int)horizontal);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveBehavior.SetMovementMode(Movement.MovementMode.Run);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveBehavior.SetMovementMode(Movement.MovementMode.Walk);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            moveBehavior.SetMovementMode(Movement.MovementMode.Crouch);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            moveBehavior.SetMovementMode(Movement.MovementMode.Walk);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveBehavior.SignalJump();
        }

    }
}
