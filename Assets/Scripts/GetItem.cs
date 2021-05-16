using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public class GetItem : MonoBehaviour
    {
        public string TagObject;
        public GameObject ActionColider;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(TagObject))
            {
                ActionColider.GetComponent<IActionColider>().Colision();
                Destroy(collision.gameObject);
            }
        }
    }
}