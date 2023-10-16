using System;
using UnityEngine;

namespace Exercise1
{
    public class SphereListener : MonoBehaviour
    {
        public CylinderSender cylinderCollision;

        private Renderer _renderer;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            cylinderCollision.OnCollideWithCube += OnCollideWithCube;
        }

        private void OnDestroy()
        {
            if (cylinderCollision != null)
                cylinderCollision.OnCollideWithCube -= OnCollideWithCube;
        }

        private void OnCollideWithCube()
        {
            if (gameObject.CompareTag("EsferaGrupo1"))
            {
                _renderer.material.color = Color.magenta;
            } 
            else if (gameObject.CompareTag("EsferaGrupo2"))
            {
                transform.position = cylinderCollision.transform.position;
            }
        }
    }
}
