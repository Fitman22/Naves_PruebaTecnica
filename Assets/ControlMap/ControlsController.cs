using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsController : MonoBehaviour
{
    InputSystem_Actions map;
    static InputSystem_Actions.PlayerActions actions;
    private void Awake()
    {
        map = new InputSystem_Actions();
        actions = map.Player;
    }
    public static InputSystem_Actions.PlayerActions getControls()
    {
        return actions;
    }
    private void OnEnable()
    {
        map.Enable();
    }
    private void OnDestroy()
    {
        map.Disable();
    }
}
