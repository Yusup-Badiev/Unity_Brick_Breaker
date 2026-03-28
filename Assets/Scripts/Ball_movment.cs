using UnityEngine;

public class Ball_movment : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 currentDirection = Vector2.down;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Running Start method");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.down * speed;
    }

    void Update()
    {
        currentDirection = GetComponent<Rigidbody2D>().linearVelocity.normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with 2d");
        Vector2 reflectedDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = reflectedDirection * speed;
    }
}
