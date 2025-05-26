using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuUI;   // Главное меню
    public GameObject gameUI;   // Игровой UI (счётчик монет и т.д.)
    public AudioSource engineSound; // Ссылка на звук двигателя

    private void Start()
    {
        Time.timeScale = 0f;
        menuUI.SetActive(true);
        gameUI.SetActive(false);

        if (engineSound != null)
            engineSound.Stop(); // На старте молчит
    }

    public void StartGame()
    {
        menuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1f;

        if (engineSound != null)
            engineSound.Play(); // Запускается звук двигателя
    }

    public void ExitGame()
    {
        Debug.Log("Выход из игры");
        Application.Quit();
    }
}
