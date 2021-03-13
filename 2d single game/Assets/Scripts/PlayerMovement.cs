using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public void Move(InputAction.CallbackContext context)
    {
        print(context.ReadValue<float>());
        print("Test");
        transform.position = Vector3.right * context.ReadValue<float>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        print(context.ReadValue<bool>());
    }

}
