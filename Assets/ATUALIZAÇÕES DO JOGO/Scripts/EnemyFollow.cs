using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 2f;
    public float visionRange = 6f;
    public float obstacleAvoidDistance = 0.5f;
    public Transform player;

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= visionRange)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, obstacleAvoidDistance);

            if (hit.collider != null && hit.collider.CompareTag("Wall"))
            {
               
                Vector2 right = Vector2.Perpendicular(direction);
                transform.position += (Vector3)right * speed * Time.deltaTime;
            }
            else
            {
                
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
        }
    }
}
