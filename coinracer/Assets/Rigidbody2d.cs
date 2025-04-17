using UnityEngine;

public class Rigidbody2d : MonoBehaviour
{
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.gravityScale = 0f;
            rb.simulated = true;
        }
        else
        {
            Debug.LogWarning("Rigidbody2D не найден на объекте " + gameObject.name);
        }
    }
}
