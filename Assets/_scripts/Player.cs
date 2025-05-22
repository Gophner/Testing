using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private int hp = 10;

    [SerializeField] private GameObject bulletPrefab;  
    [SerializeField] private float speed;

    void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        rigidbody.linearVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) {
            rigidbody.linearVelocity += speed*Vector2.up;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.linearVelocity += speed*Vector2.down;
        }
        if (Input.GetKey(KeyCode.A)) {
            rigidbody.linearVelocity += speed*Vector2.left;
        }
        if (Input.GetKey(KeyCode.D)) {
            rigidbody.linearVelocity += speed*Vector2.right;
        }

        if (rigidbody.linearVelocity.magnitude > 5){
                rigidbody.linearVelocity *= 1/Mathf.Sqrt(2);
        }

        Debug.Log(rigidbody.linearVelocity.magnitude);

        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnBullet();
        }

        void SpawnBullet()
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position + new Vector3(0,1,0);
            newBullet.tag = "Player_Bullet";
        }

    }

        void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Enemy_Bullet") {
            Debug.Log("Player hit by bullet");
            Destroy(collider.gameObject);

            hp--;
            if (hp <= 0) {
                Destroy(gameObject);
            }
        }
    }
    
}

