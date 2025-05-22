using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed_x, speed_y; 
    private int direction = 1;
    public float rightBorder, leftBorder;

    private Rigidbody2D rigidbody;

    private float bulletTimer;
    [SerializeField] private float time_to_shoot_bullet;
    [SerializeField] private GameObject bulletPrefab;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.x > rightBorder) {
            direction = -1;
        } else if (transform.position.x < leftBorder) {
            direction = 1;
        }

        rigidbody.linearVelocity = new Vector2(speed_x * direction,-speed_y);

        Shoot_Bullet();
    }

    void Shoot_Bullet(){
        bulletTimer += Time.deltaTime;
        if (bulletTimer > time_to_shoot_bullet) {
            bulletTimer = 0;
            GameObject enemyBullet = Instantiate(bulletPrefab);
            enemyBullet.transform.position = transform.position + new Vector3(0,-1,0);
            enemyBullet.transform.rotation = Quaternion.Euler(0,0,180);
            
            enemyBullet.tag = "Enemy_Bullet";

            BulletBehavior bulletBehavior = enemyBullet.GetComponent<BulletBehavior>();
            bulletBehavior.direction = Vector2.down;
        }
    }

        void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player_Bullet") {
            Debug.Log("Enemy hit by bullet");
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}
