using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuUI;   // ������ �������� ����
    public GameObject gameUI;   // ������ �������� UI (coinText � �.�.)

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
        Debug.Log("����� �� ����");
        Application.Quit();
    }
}
