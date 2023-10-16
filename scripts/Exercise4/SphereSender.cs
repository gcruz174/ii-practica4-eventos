using UnityEngine;

namespace Exercise4
{
    public class SphereSender : MonoBehaviour
    {
        public delegate void AddPointsEvent(int pointAmount);

        public event AddPointsEvent OnHit;

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            
            var pointsToAdd = 0;
            if (gameObject.CompareTag("EsferaGrupo1")) pointsToAdd = 5;
            else if (gameObject.CompareTag("EsferaGrupo2")) pointsToAdd = 10;
            OnHit?.Invoke(pointsToAdd);
            Destroy(gameObject);
        }
    }
}
