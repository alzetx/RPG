using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace RPG.Units.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField, Range(1, 100)] private float _speed; //todo
        [SerializeField, Range(1, 100)] private float _velocityJump; //todo
        private StatsAssistant _stats;
        private float _speedNow;
        private float _speedSprint;
        private Rigidbody _rigidBody;
        private PlayerControls _controls;
       

        private void Awake()
        {
            _speedNow = _speed;
            _speedSprint = _speed * 10f;
            _rigidBody = GetComponent<Rigidbody>();
            _controls = new PlayerControls();
            _controls.GameMap.FastAttack.performed += OnFastAttack;
            _controls.GameMap.StrongAttack.performed += OnStrongAttack;
            _controls.GameMap.Jump.performed += OnJump;
        }

        private void OnSprint()
        {
            var velocity = _controls.GameMap.Sprint.ReadValue<float>();
            if (velocity == 0)
            {
                _speedNow = _speed;
                return;
            }
            _speedNow = _speedSprint;
        }

        private void OnJump(CallbackContext context)
        {
            _rigidBody.AddForce(transform.up * _velocityJump, ForceMode.Impulse);
        }

        private void OnFastAttack(CallbackContext context)
        {
            //todo
        }
        private void OnStrongAttack(CallbackContext context)
        {
            //todo
        }
        private void Update()
        {
            OnMovement();
            OnSprint();
        }

        private void OnMovement()
        {
            var direction = _controls.GameMap.Movement.ReadValue<Vector2>();
            var velocity = new Vector3(direction.x, 0f, direction.y);
            transform.position += velocity * _speedNow * Time.deltaTime;
        }

        private void OnDestroy()
        {
            _controls.Dispose();
        }
        private void OnEnable()
        {
            _controls.Enable();
        }
        private void OnDisable()
        {
            _controls.Disable();
        }

    }
}
