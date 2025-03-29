using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.Controllers
{
    public class CameraFollowController : MonoBehaviour
    {
        [SerializeField] Transform _target;
        [SerializeField] [Range(0.3f, 4f)] float _smoothSpeed;

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _smoothSpeed * Time.deltaTime);
        }
    }
}