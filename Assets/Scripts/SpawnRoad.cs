using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float spriteHeight; 
    public Transform otherRoad; 

    private void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        spriteHeight = sr.bounds.size.y;
    }

    private void Update()
    {
        transform.Translate(Vector2.down * scrollSpeed * Time.deltaTime);

        if (transform.position.y < -spriteHeight)
        {
            float newY = otherRoad.position.y + spriteHeight;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}
