using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private float enemySpawnTimer;
    [SerializeField] private float time_to_spawn_enemy;

    [SerializeField] float y_value_to_spawn_enemy_at;

    [SerializeField] private float enemy_vertical_speed;

    void Update()
    {
        enemySpawnTimer += Time.deltaTime;

        if (enemySpawnTimer > time_to_spawn_enemy) {
            enemySpawnTimer = 0;

            GameObject newEnemy = Instantiate(enemyPrefab);
            EnemyBehavior enemyBehavior = newEnemy.GetComponent<EnemyBehavior>();

            float randomX = Random.Range(enemyBehavior.rightBorder, enemyBehavior.leftBorder);
            newEnemy.transform.position = new Vector3(randomX, y_value_to_spawn_enemy_at, 0);

            enemyBehavior.speed_y = enemy_vertical_speed;
        }
    }
}
