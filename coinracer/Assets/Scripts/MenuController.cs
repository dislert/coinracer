using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuUI;   // Панель главного меню
    public GameObject gameUI;   // Панель игрового UI (coinText и т.д.)

    private void Start()
    {
        Time.timeScale = 0f;
        menuUI.SetActive(true);
        gameUI.SetActive(false);
    }

    public void StartGame()
    {
        menuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Debug.Log("Выход из игры");
        Application.Quit();
    }
}
