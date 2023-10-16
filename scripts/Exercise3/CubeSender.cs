using System;
using UnityEngine;

namespace Exercise3
{
    public class CubeSender : MonoBehaviour
    {
        public delegate void ApproachEvent();

        public event ApproachEvent OnApproachCylinder;
        public float approachDistance = 5f;
        public GameObject cylinder;

        private void Update()
        {
            var distance = Vector3.Distance(transform.position, cylinder.transform.position);
            if (distance <= approachDistance) OnApproachCylinder?.Invoke();
        }
    }
}
