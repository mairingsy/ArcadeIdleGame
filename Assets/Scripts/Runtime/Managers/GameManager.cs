using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public Joystick _joystick;
        private Vector3 _commandDirection;
        public GameObject Player;
        public Rigidbody PlayerRb;
        public float playerSpeed = 20;
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            
        }

        private void Start()
        {
            //if (Player)
            //{
            //    PlayerRb = Player.GetComponent<Rigidbody>();
            //}
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                JoyStickMovement();
            }


            if (Input.GetMouseButtonUp(0))
            {
                PlayerRb.velocity = Vector3.zero;
            }
        }
        void JoyStickMovement()
        {
            var deltaPosition = _joystick.Direction;

            _commandDirection = deltaPosition.normalized;

            _commandDirection = new Vector3(_commandDirection.x, 0, _commandDirection.y);

            var playerPos = Player.transform.position;

            var playerlookatPosition = playerPos + _commandDirection;

            Vector3 targetDir = playerlookatPosition - playerPos;

            Player.transform.rotation = Quaternion.LookRotation(targetDir);

            Vector3 targetVelocity = (Player.transform.forward * playerSpeed);

            targetVelocity.y = PlayerRb.velocity.y;

            PlayerRb.velocity = targetVelocity;

            float magnitude = PlayerRb.velocity.magnitude;
        }
    }
}