using Exercise4;
using UnityEngine;

namespace Exercise5
{
    public class CubeListener : MonoBehaviour
    {
        public SphereSender[] sphereSenders;
        public int points;

        public delegate void PointsChangeEvent(int newPoints);

        public event PointsChangeEvent OnPointsChange;

        private void Awake()
        {
            foreach (var sphereSender in sphereSenders)
            {
                sphereSender.OnHit += AddPoints;
            }
        }

        private void OnDestroy()
        {
            foreach (var sphereSender in sphereSenders)
            {
                if (sphereSender != null)
                    sphereSender.OnHit -= AddPoints;
            }
        }

        private void AddPoints(int pointsAmount)
        {
            points += pointsAmount;
            OnPointsChange?.Invoke(points);
        }
    }
}
