// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Forklift"",
            ""id"": ""d15dece9-d761-463b-9461-e4b689a69595"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""a7f56a39-6dd4-4894-be97-f24ffb6b871e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Decelerate"",
                    ""type"": ""Value"",
                    ""id"": ""1e138370-be67-4132-84e7-08361d83bef0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Value"",
                    ""id"": ""b517529f-fc55-481d-a1f0-162b0d526bb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Value"",
                    ""id"": ""9d06dbf9-3801-4348-8c67-36acdbcdbfc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe554c58-0a29-4f33-910a-ab2b71094f95"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Forklift"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c2b3eb1-583b-4709-bcad-6289bbd80d29"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Forklift"",
                    ""action"": ""Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""711f612a-3b4c-48a8-aef4-a7b34f980962"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Forklift"",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cfce215-ae26-4877-9050-36c437ca76b5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Forklift"",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Forklift"",
            ""bindingGroup"": ""Forklift"",
            ""devices"": []
        }
    ]
}");
        // Forklift
        m_Forklift = asset.FindActionMap("Forklift", throwIfNotFound: true);
        m_Forklift_Accelerate = m_Forklift.FindAction("Accelerate", throwIfNotFound: true);
        m_Forklift_Decelerate = m_Forklift.FindAction("Decelerate", throwIfNotFound: true);
        m_Forklift_TurnLeft = m_Forklift.FindAction("TurnLeft", throwIfNotFound: true);
        m_Forklift_TurnRight = m_Forklift.FindAction("TurnRight", throwIfNotFound: true);
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

    // Forklift
    private readonly InputActionMap m_Forklift;
    private IForkliftActions m_ForkliftActionsCallbackInterface;
    private readonly InputAction m_Forklift_Accelerate;
    private readonly InputAction m_Forklift_Decelerate;
    private readonly InputAction m_Forklift_TurnLeft;
    private readonly InputAction m_Forklift_TurnRight;
    public struct ForkliftActions
    {
        private @InputMaster m_Wrapper;
        public ForkliftActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Forklift_Accelerate;
        public InputAction @Decelerate => m_Wrapper.m_Forklift_Decelerate;
        public InputAction @TurnLeft => m_Wrapper.m_Forklift_TurnLeft;
        public InputAction @TurnRight => m_Wrapper.m_Forklift_TurnRight;
        public InputActionMap Get() { return m_Wrapper.m_Forklift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkliftActions set) { return set.Get(); }
        public void SetCallbacks(IForkliftActions instance)
        {
            if (m_Wrapper.m_ForkliftActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnAccelerate;
                @Decelerate.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDecelerate;
                @Decelerate.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDecelerate;
                @Decelerate.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDecelerate;
                @TurnLeft.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnLeft;
                @TurnRight.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnRight;
                @TurnRight.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnRight;
                @TurnRight.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnTurnRight;
            }
            m_Wrapper.m_ForkliftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Decelerate.started += instance.OnDecelerate;
                @Decelerate.performed += instance.OnDecelerate;
                @Decelerate.canceled += instance.OnDecelerate;
                @TurnLeft.started += instance.OnTurnLeft;
                @TurnLeft.performed += instance.OnTurnLeft;
                @TurnLeft.canceled += instance.OnTurnLeft;
                @TurnRight.started += instance.OnTurnRight;
                @TurnRight.performed += instance.OnTurnRight;
                @TurnRight.canceled += instance.OnTurnRight;
            }
        }
    }
    public ForkliftActions @Forklift => new ForkliftActions(this);
    private int m_ForkliftSchemeIndex = -1;
    public InputControlScheme ForkliftScheme
    {
        get
        {
            if (m_ForkliftSchemeIndex == -1) m_ForkliftSchemeIndex = asset.FindControlSchemeIndex("Forklift");
            return asset.controlSchemes[m_ForkliftSchemeIndex];
        }
    }
    public interface IForkliftActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnDecelerate(InputAction.CallbackContext context);
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
    }
}
