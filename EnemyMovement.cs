using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    private Vector2 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x - startPos.x) > moveDistance)
        {
            direction *= -1;

            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthSpeler playerHealth = other.GetComponent<HealthSpeler>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(2);
            }
        }
    }
}
