using UnityEngine;

namespace Exercise2
{
    public class CubeSender : MonoBehaviour
    {
        public delegate void CollisionEvent();

        public event CollisionEvent OnCollideWithGroup1;
        public event CollisionEvent OnCollideWithNotGroup1;
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("EsferaGrupo1"))
                OnCollideWithGroup1?.Invoke();
            else
                OnCollideWithNotGroup1?.Invoke();
        }
    }
}
