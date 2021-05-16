using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts
{
    public class Shoter : MonoBehaviour
    {
        public GameObject Bullet;
        public GameObject ShotPoint;

        void Start()
        {
        }

        void Update()
        {
            Shoot();
        }

        private void Shoot()
        {
            if (Input.GetMouseButtonDown((int)EMouseButton.LEFT))
            {
                var bulletInstance = Instantiate(Bullet);
                bulletInstance.transform.position = ShotPoint.transform.position;
                bulletInstance.GetComponent<Bullet>().Shoot(transform);
            }
        }
    }
}