using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public class Pontuation : MonoBehaviour, IActionColider
    {
        public int Score;

        public Pontuation()
        {
            Score = 0;
        }

        public void Colision()
        {
            Score += 10;
        }
    }
}
