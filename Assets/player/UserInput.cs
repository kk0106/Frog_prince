using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    [HideInInspector] public Controls controls;
    [HideInInspector] public Vector2 moveInput;

    public static UserInput instance;

    private PlayerInput _playerInput;
    public bool menuOpenCloseInput { get; private set; }

    private InputAction _newmenucontrol;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

        controls = new Controls();
        controls.playerControls.Movement.performed += ctx => moveInput = ctx.ReadValue<Vector2>();

        _playerInput=GetComponent<PlayerInput>();
        _newmenucontrol = _playerInput.actions["NewUIControl"];
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    private void Update()
    {
        menuOpenCloseInput=_newmenucontrol.WasPressedThisFrame();
    }
}

