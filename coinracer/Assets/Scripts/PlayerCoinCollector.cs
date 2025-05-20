using UnityEngine;
using TMPro;

public class PlayerCoinCollector : MonoBehaviour
{
    public TextMeshProUGUI coinText; // UI текст
    private int coinCount = 0;

    private void Start()
    {
        UpdateCoinUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
            UpdateCoinUI();
        }
    }

    private void UpdateCoinUI()
    {
        coinText.text = coinCount.ToString();
    }

    public void ResetCoins()
    {
        coinCount = 0;
        UpdateCoinUI();
    }
}
