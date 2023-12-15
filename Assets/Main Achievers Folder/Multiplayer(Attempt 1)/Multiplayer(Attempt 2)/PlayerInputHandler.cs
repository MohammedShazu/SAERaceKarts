using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
public class PlayerInputHandler : MonoBehaviour
{
    private PlayerConfiguration playerConfigs;
    private KartController karts;

    [SerializeField]
    private MeshRenderer playerMesh;

    private KartControls controls;
    
   public void Awake()
    {
        var karts = GetComponent<KartController>();
        controls = new KartControls();
    }

    public void InitializePlayer(PlayerConfiguration pc)
    {
        playerConfigs = pc;
        playerMesh.material = pc.PlayerMaterial;
        playerConfigs.Input.onActionTriggered += Input_onActionTriggered;
    }

    private void Input_onActionTriggered(CallbackContext obj)
    {
        if(obj.action.name == controls.Gameplay.Move.name)
        {
            OnMove(obj);
        }
    }

    public void OnMove(CallbackContext context)
    {
        if(karts != null)
        {
            //karts.SetInputVector(context.ReadValue<Vector2>());
        }
    }
   
}
