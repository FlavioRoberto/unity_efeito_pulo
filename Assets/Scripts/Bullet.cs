using UnityEngine;

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour
    {
        public float Velocity;
        private Rigidbody _rigidBody;

        public Bullet()
        {
            Velocity = 100;
        }

        public void Shoot(Transform transform)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * Velocity, ForceMode.Impulse);
        }
    }
}
