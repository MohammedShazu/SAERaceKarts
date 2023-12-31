using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
{
    public Vector2 InputVector { get; private set; }

    public Vector2 MousePosition { get; private set; }

   

    public void SetInputVector(CallbackContext ctx)
    {
        InputVector = ctx.ReadValue<Vector2>();
    }
}
