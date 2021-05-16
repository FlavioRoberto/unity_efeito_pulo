using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Pontuation : MonoBehaviour, IActionColider
    {
        private int _score;
        public Text Score;

        public Pontuation()
        {
            _score = 0;
        }

        private void Update()
        {
            Score.text = $"X {_score}";
        }

        public void Colision()
        {
            _score += 1;
        }
    }
}
