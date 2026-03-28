using UnityEngine;

public class BrickBreak : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.name == "Ball")
        {
            Destroy(gameObject);
        }
    }
}
