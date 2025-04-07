using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minX = -5f; 
    public float maxX = 5f;  

    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");

        
        float newPosX = transform.position.x + moveX * moveSpeed * Time.deltaTime;

        
        newPosX = Mathf.Clamp(newPosX, minX, maxX);

        
        transform.position = new Vector2(newPosX, transform.position.y);
    }
}