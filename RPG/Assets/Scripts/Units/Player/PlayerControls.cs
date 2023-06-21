// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Units/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RPG.Units.Player
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameMap"",
            ""id"": ""513777a6-5cc8-4535-9fc9-9742f6f45287"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc4746d5-1a20-4934-93e9-445580257c81"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""6d7860a9-9c4e-42ac-89cc-ab93d4e17b35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""2c8a48f7-7d73-483d-9832-9f5ea05f2341"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""f03a80bd-c207-4185-a22c-5d90083ec990"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9be8b00d-0791-4145-9afe-dfa2ad0c4a79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""834d489d-6280-4bbb-ab0a-ff93d9744b85"",
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
                    ""id"": ""c9963f18-43ac-4b30-a7cf-dc2504dbc4c6"",
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
                    ""id"": ""babc9ade-0af8-4ba7-a255-cc2d170a8735"",
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
                    ""id"": ""cac075f1-6aad-4212-b08b-93a43fdd87cd"",
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
                    ""id"": ""f05497e4-5a5c-4d18-9413-418323f76e16"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""391e8483-c3db-4053-82d5-feab4098479c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99644e3f-58fb-407d-a0d0-fe213c680103"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b90453d-661c-432e-90c8-25b2be7c87ce"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9575d5b0-5aa5-48af-bb92-645f7caabc3c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GameMap
            m_GameMap = asset.FindActionMap("GameMap", throwIfNotFound: true);
            m_GameMap_Movement = m_GameMap.FindAction("Movement", throwIfNotFound: true);
            m_GameMap_FastAttack = m_GameMap.FindAction("FastAttack", throwIfNotFound: true);
            m_GameMap_StrongAttack = m_GameMap.FindAction("StrongAttack", throwIfNotFound: true);
            m_GameMap_Sprint = m_GameMap.FindAction("Sprint", throwIfNotFound: true);
            m_GameMap_Jump = m_GameMap.FindAction("Jump", throwIfNotFound: true);
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

        // GameMap
        private readonly InputActionMap m_GameMap;
        private IGameMapActions m_GameMapActionsCallbackInterface;
        private readonly InputAction m_GameMap_Movement;
        private readonly InputAction m_GameMap_FastAttack;
        private readonly InputAction m_GameMap_StrongAttack;
        private readonly InputAction m_GameMap_Sprint;
        private readonly InputAction m_GameMap_Jump;
        public struct GameMapActions
        {
            private @PlayerControls m_Wrapper;
            public GameMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_GameMap_Movement;
            public InputAction @FastAttack => m_Wrapper.m_GameMap_FastAttack;
            public InputAction @StrongAttack => m_Wrapper.m_GameMap_StrongAttack;
            public InputAction @Sprint => m_Wrapper.m_GameMap_Sprint;
            public InputAction @Jump => m_Wrapper.m_GameMap_Jump;
            public InputActionMap Get() { return m_Wrapper.m_GameMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameMapActions instance)
            {
                if (m_Wrapper.m_GameMapActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @FastAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @StrongAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @Sprint.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnSprint;
                    @Jump.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_GameMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @FastAttack.started += instance.OnFastAttack;
                    @FastAttack.performed += instance.OnFastAttack;
                    @FastAttack.canceled += instance.OnFastAttack;
                    @StrongAttack.started += instance.OnStrongAttack;
                    @StrongAttack.performed += instance.OnStrongAttack;
                    @StrongAttack.canceled += instance.OnStrongAttack;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public GameMapActions @GameMap => new GameMapActions(this);
        public interface IGameMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnFastAttack(InputAction.CallbackContext context);
            void OnStrongAttack(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
