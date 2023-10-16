using System;
using UnityEngine;

namespace Exercise3
{
    public class SphereListener : MonoBehaviour
    {
        public CubeSender cubeSender;
        public Transform lookTarget;
        public float jumpForce = 2.5f;
    
        private Renderer _renderer;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _renderer = gameObject.GetComponent<Renderer>();
            _rigidbody = gameObject.GetComponent<Rigidbody>();
            cubeSender.OnApproachCylinder += OnApproachCylinder;
        }

        private void OnDestroy()
        {
            if (cubeSender != null)
                cubeSender.OnApproachCylinder -= OnApproachCylinder;
        }

        private void Update()
        {
            Debug.DrawRay(transform.position, transform.forward * 2.5f, Color.green);
        }

        private void OnApproachCylinder() 
        {
            if (gameObject.CompareTag("EsferaGrupo1")) 
            {
                _renderer.material.color = Color.red;
                _rigidbody.AddForce(Vector3.up * jumpForce);
            }
            else if (gameObject.CompareTag("EsferaGrupo2")) 
            {
                transform.LookAt(lookTarget);
            }
        }
    }
}
