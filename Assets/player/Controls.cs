//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/player/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""playerControls"",
            ""id"": ""d25fee8e-22e4-4927-ac0e-1537f4e96283"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17eeca0a-d20f-465a-920b-5671630e507e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""talk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dbf9969d-9247-4ab1-b51f-77f9ce870dbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DialogueSystem"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cc9bb320-cf2b-4ae0-91e9-45321105e077"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grapple Gun"",
                    ""type"": ""Button"",
                    ""id"": ""ad32473e-52c4-4816-aafb-685953f70ad9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4ba10eec-436d-4c86-87e8-a5b6ef74a80f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""uiTouch"",
                    ""type"": ""Button"",
                    ""id"": ""af96febc-848f-484e-8458-929badeed848"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BackPack"",
                    ""type"": ""Button"",
                    ""id"": ""3713d037-e804-49e0-8714-caa8d3390324"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""uiChoose"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5ce15b51-734f-4bb9-99f1-41b5f76eb816"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootGun"",
                    ""type"": ""Button"",
                    ""id"": ""5e8fcb81-4f6d-423d-8c96-eb13ca88a92e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""startAni"",
                    ""type"": ""Button"",
                    ""id"": ""afc95239-0db2-4455-a34a-21438766dd1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd keys"",
                    ""id"": ""86b41216-b9ad-4db3-8d31-dfb6d7d40cd8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ebdf3d4-a7e3-4b26-bdaa-db071d29c075"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""089c791b-a02a-4801-9051-c7433515580a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd8da32c-2cac-4321-875a-53eb2ef1fda0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83ce58ce-10fb-46bf-82a2-761654024294"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""xbox move"",
                    ""id"": ""02442d65-fd51-45d2-b989-dc9e0bd8342f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4c253b65-0856-4823-9640-33d6176915df"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""96151c44-959b-46d2-a699-29c0b6d3d695"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""79ee413b-55dc-419f-b8af-94cc28bf29f1"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4eae3693-e0e2-4d18-99a5-5c13403564b9"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0b81060c-d37e-4eca-8584-bb10da118c1b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d324c17-bcf2-4dc7-ba31-0271cc403ed2"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f96007a2-c9ef-4efa-9889-b1aa664ca86e"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grapple Gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d8251ef-c722-41e1-957b-765374e909ec"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grapple Gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f733377-e8d8-495d-b61d-044565cd3f35"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6a22a31-53da-4e5f-9dcc-185c5fb6a28c"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""715266c1-7840-4e97-b17d-ffa800f6f586"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""783e8f03-36a5-454b-a6fa-70aeb08e6943"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8f7ceb2-4cc9-42ea-87ab-4b345e8d26c2"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdc80ec9-d32c-4824-b366-a8e7c3a2d21c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueSystem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e70ce55-0ffc-4ba3-9d52-3506266d0379"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueSystem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8efe16ec-26aa-4725-94e0-604e8c7fb8a6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueSystem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7838ffdf-b448-4901-a5ad-cfb0f72ea50b"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""uiTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c3b687e-e7e0-43a8-b1bb-22dda4b1b9f5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""uiTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffef414c-c2e3-44f0-9163-aa9bdd041990"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackPack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1da701dd-f79f-43cc-aa0f-8b946fad0c2b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackPack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da199ada-4562-4285-be28-8d0085b451f3"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""uiChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08574bcb-f39d-4c64-a7c9-3ff68b187367"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""uiChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50f2a59d-6ae2-4c04-bade-b4e04f23cb67"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb39091d-d680-4f86-941f-63663c5a2dc3"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64ffbdcc-5905-43ac-9045-56b760a47976"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""startAni"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50cdeae6-45b5-4bd2-b1d3-31d9ac9f8148"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""startAni"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playerControls
        m_playerControls = asset.FindActionMap("playerControls", throwIfNotFound: true);
        m_playerControls_Movement = m_playerControls.FindAction("Movement", throwIfNotFound: true);
        m_playerControls_talk = m_playerControls.FindAction("talk", throwIfNotFound: true);
        m_playerControls_DialogueSystem = m_playerControls.FindAction("DialogueSystem", throwIfNotFound: true);
        m_playerControls_GrappleGun = m_playerControls.FindAction("Grapple Gun", throwIfNotFound: true);
        m_playerControls_jump = m_playerControls.FindAction("jump", throwIfNotFound: true);
        m_playerControls_uiTouch = m_playerControls.FindAction("uiTouch", throwIfNotFound: true);
        m_playerControls_BackPack = m_playerControls.FindAction("BackPack", throwIfNotFound: true);
        m_playerControls_uiChoose = m_playerControls.FindAction("uiChoose", throwIfNotFound: true);
        m_playerControls_ShootGun = m_playerControls.FindAction("ShootGun", throwIfNotFound: true);
        m_playerControls_startAni = m_playerControls.FindAction("startAni", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // playerControls
    private readonly InputActionMap m_playerControls;
    private List<IPlayerControlsActions> m_PlayerControlsActionsCallbackInterfaces = new List<IPlayerControlsActions>();
    private readonly InputAction m_playerControls_Movement;
    private readonly InputAction m_playerControls_talk;
    private readonly InputAction m_playerControls_DialogueSystem;
    private readonly InputAction m_playerControls_GrappleGun;
    private readonly InputAction m_playerControls_jump;
    private readonly InputAction m_playerControls_uiTouch;
    private readonly InputAction m_playerControls_BackPack;
    private readonly InputAction m_playerControls_uiChoose;
    private readonly InputAction m_playerControls_ShootGun;
    private readonly InputAction m_playerControls_startAni;
    public struct PlayerControlsActions
    {
        private @Controls m_Wrapper;
        public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_playerControls_Movement;
        public InputAction @talk => m_Wrapper.m_playerControls_talk;
        public InputAction @DialogueSystem => m_Wrapper.m_playerControls_DialogueSystem;
        public InputAction @GrappleGun => m_Wrapper.m_playerControls_GrappleGun;
        public InputAction @jump => m_Wrapper.m_playerControls_jump;
        public InputAction @uiTouch => m_Wrapper.m_playerControls_uiTouch;
        public InputAction @BackPack => m_Wrapper.m_playerControls_BackPack;
        public InputAction @uiChoose => m_Wrapper.m_playerControls_uiChoose;
        public InputAction @ShootGun => m_Wrapper.m_playerControls_ShootGun;
        public InputAction @startAni => m_Wrapper.m_playerControls_startAni;
        public InputActionMap Get() { return m_Wrapper.m_playerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @talk.started += instance.OnTalk;
            @talk.performed += instance.OnTalk;
            @talk.canceled += instance.OnTalk;
            @DialogueSystem.started += instance.OnDialogueSystem;
            @DialogueSystem.performed += instance.OnDialogueSystem;
            @DialogueSystem.canceled += instance.OnDialogueSystem;
            @GrappleGun.started += instance.OnGrappleGun;
            @GrappleGun.performed += instance.OnGrappleGun;
            @GrappleGun.canceled += instance.OnGrappleGun;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @uiTouch.started += instance.OnUiTouch;
            @uiTouch.performed += instance.OnUiTouch;
            @uiTouch.canceled += instance.OnUiTouch;
            @BackPack.started += instance.OnBackPack;
            @BackPack.performed += instance.OnBackPack;
            @BackPack.canceled += instance.OnBackPack;
            @uiChoose.started += instance.OnUiChoose;
            @uiChoose.performed += instance.OnUiChoose;
            @uiChoose.canceled += instance.OnUiChoose;
            @ShootGun.started += instance.OnShootGun;
            @ShootGun.performed += instance.OnShootGun;
            @ShootGun.canceled += instance.OnShootGun;
            @startAni.started += instance.OnStartAni;
            @startAni.performed += instance.OnStartAni;
            @startAni.canceled += instance.OnStartAni;
        }

        private void UnregisterCallbacks(IPlayerControlsActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @talk.started -= instance.OnTalk;
            @talk.performed -= instance.OnTalk;
            @talk.canceled -= instance.OnTalk;
            @DialogueSystem.started -= instance.OnDialogueSystem;
            @DialogueSystem.performed -= instance.OnDialogueSystem;
            @DialogueSystem.canceled -= instance.OnDialogueSystem;
            @GrappleGun.started -= instance.OnGrappleGun;
            @GrappleGun.performed -= instance.OnGrappleGun;
            @GrappleGun.canceled -= instance.OnGrappleGun;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @uiTouch.started -= instance.OnUiTouch;
            @uiTouch.performed -= instance.OnUiTouch;
            @uiTouch.canceled -= instance.OnUiTouch;
            @BackPack.started -= instance.OnBackPack;
            @BackPack.performed -= instance.OnBackPack;
            @BackPack.canceled -= instance.OnBackPack;
            @uiChoose.started -= instance.OnUiChoose;
            @uiChoose.performed -= instance.OnUiChoose;
            @uiChoose.canceled -= instance.OnUiChoose;
            @ShootGun.started -= instance.OnShootGun;
            @ShootGun.performed -= instance.OnShootGun;
            @ShootGun.canceled -= instance.OnShootGun;
            @startAni.started -= instance.OnStartAni;
            @startAni.performed -= instance.OnStartAni;
            @startAni.canceled -= instance.OnStartAni;
        }

        public void RemoveCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsActions @playerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnTalk(InputAction.CallbackContext context);
        void OnDialogueSystem(InputAction.CallbackContext context);
        void OnGrappleGun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUiTouch(InputAction.CallbackContext context);
        void OnBackPack(InputAction.CallbackContext context);
        void OnUiChoose(InputAction.CallbackContext context);
        void OnShootGun(InputAction.CallbackContext context);
        void OnStartAni(InputAction.CallbackContext context);
    }
}
