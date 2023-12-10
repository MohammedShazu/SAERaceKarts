using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    private InputActionAsset inputAsset;
    private InputActionMap player;
    private InputAction move;

    private void Awake()
    {
        inputAsset = this.GetComponent<PlayerInput>().actions;
        player = inputAsset.FindActionMap("Kart1");
    }

    private void OnEnable()
    {
        move = player.FindAction("Move");
        player.Enable();
    }

    private void OnDisable()
    {
        player.Disable();
    }
}
