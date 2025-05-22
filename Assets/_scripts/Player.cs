using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    [SerializeField] private GameObject bulletPrefab;  

    void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        rigidbody.linearVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) {
            rigidbody.linearVelocity += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.linearVelocity += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A)) {
            rigidbody.linearVelocity += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D)) {
            rigidbody.linearVelocity += Vector2.right;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnBullet();
        }

        void SpawnBullet()
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position + new Vector3(0,1,0);
        }

    }

    
}

