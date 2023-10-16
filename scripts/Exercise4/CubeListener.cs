using UnityEngine;

namespace Exercise4
{
    public class CubeListener : MonoBehaviour
    {
        public SphereSender[] sphereSenders;
        public int points;

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
            Debug.Log($"Current points: {points}");
        }
    }
}
