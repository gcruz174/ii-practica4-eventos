using UnityEngine;

namespace Exercise2
{
    public class SphereListener : MonoBehaviour
    {
        public Transform cylinderTransform;
        public CubeSender cubeCollision;
        public float scaleChange = 2.0f;

        private void Awake()
        {
            cubeCollision.OnCollideWithGroup1 += OnCollideWithGroup1;
            cubeCollision.OnCollideWithNotGroup1 += OnCollideWithNotGroup1;
        }

        private void OnDestroy()
        {
            if (cubeCollision == null) return;
            cubeCollision.OnCollideWithGroup1 -= OnCollideWithGroup1;
            cubeCollision.OnCollideWithNotGroup1 -= OnCollideWithNotGroup1;
        }

        private void OnCollideWithGroup1()
        {
            if (gameObject.CompareTag("EsferaGrupo2"))
            {
                transform.localScale *= scaleChange;
            }
        }
        
        private void OnCollideWithNotGroup1()
        {
            if (gameObject.CompareTag("EsferaGrupo1"))
            {
                transform.position = cylinderTransform.position;
            }
        }
    }
}
