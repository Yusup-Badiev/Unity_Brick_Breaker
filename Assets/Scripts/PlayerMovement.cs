using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float left_right = 0f;
        if (Keyboard.current[Key.LeftArrow].isPressed)
        {
            left_right = -1f;
        }
        if (Keyboard.current[Key.RightArrow].isPressed)
        {
            left_right = 1f;
        }
        transform.Translate(Vector2.right * left_right * speed * Time.deltaTime);
    }  
}
