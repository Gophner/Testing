using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public float damage;

    private Rigidbody2D rigidbody;

    [SerializeField] float distance_to_top_of_screen, distance_to_bottom_of_screen;

    void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rigidbody.linearVelocity = direction * speed;
    }

    void Update()
    {
        if (transform.position.y > distance_to_top_of_screen || transform.position.y < distance_to_bottom_of_screen){
            Destroy(gameObject);
        }
    }
}
