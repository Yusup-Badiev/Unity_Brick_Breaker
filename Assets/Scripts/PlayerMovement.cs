using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float left_right = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * left_right * speed * Time.deltaTime);
    }
}
