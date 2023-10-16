using UnityEngine;

namespace Exercise1
{
    public class CylinderSender : MonoBehaviour
    {
        public delegate void CollisionEvent();
        public event CollisionEvent OnCollideWithCube;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.name == "Cube")
            {
                OnCollideWithCube?.Invoke();
            }
        }
    }
}
