using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runtime.Managers;

namespace Runtime.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] Rigidbody _rb;
        [SerializeField] Animator _animator;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            float speed = _rb.velocity.magnitude;
            _animator.SetFloat("Speed", speed);
        }
    }
}