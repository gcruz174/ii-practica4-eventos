using TMPro;
using UnityEngine;

namespace Exercise5
{
    public class TextListener : MonoBehaviour
    {
        public CubeListener cubeListener;
        private TMP_Text _text;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
            cubeListener.OnPointsChange += OnPointsChange;
        }

        private void OnDestroy()
        {
            if (cubeListener != null)
                cubeListener.OnPointsChange -= OnPointsChange;
        }

        private void OnPointsChange(int newPoints)
        {
            _text.text = $"Points: {newPoints}";
        }
    }
}
