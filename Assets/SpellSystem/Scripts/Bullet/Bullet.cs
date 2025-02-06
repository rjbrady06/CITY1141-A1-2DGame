//There are no errors in this script
namespace AbilitySystem
{
    using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private Rigidbody rb => this.GetComponent<Rigidbody>();
        [SerializeField]
        private float speed = 1000;

        // Start is called before the first frame update
        void Start()
        {
            rb.velocity = this.gameObject.transform.forward * speed;
        }
    }
}