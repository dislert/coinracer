using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCoinCollector : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public AudioClip coinPickupSound; 
    private AudioSource audioSource;

    private int coinCount = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateCoinUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);

            if (coinPickupSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinPickupSound);
            }

            UpdateCoinUI();
        }
    }

    private void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }
}