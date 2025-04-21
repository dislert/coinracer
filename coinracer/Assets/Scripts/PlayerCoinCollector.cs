using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    public int coinsCollected = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
            Debug.Log("Монета собрана! Всего: " + coinsCollected);
            Destroy(other.gameObject);
        }
    }
}
