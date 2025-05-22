using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Vector3 teleportPoint;
    [SerializeField] private Vector3 pointToTeleportFrom;
    [SerializeField] private float speed;
    private Rigidbody2D rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = Vector2.down * speed;
    }

    void Update()
    {
            if (transform.position.y <= pointToTeleportFrom.y) {
                transform.position = teleportPoint;
            }
    }
}
