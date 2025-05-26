using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuUI;   // ������� ����
    public GameObject gameUI;   // ������� UI (������� ����� � �.�.)
    public AudioSource engineSound; // ������ �� ���� ���������

    private void Start()
    {
        Time.timeScale = 0f;
        menuUI.SetActive(true);
        gameUI.SetActive(false);

        if (engineSound != null)
            engineSound.Stop(); // �� ������ ������
    }

    public void StartGame()
    {
        menuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1f;

        if (engineSound != null)
            engineSound.Play(); // ����������� ���� ���������
    }

    public void ExitGame()
    {
        Debug.Log("����� �� ����");
        Application.Quit();
    }
}
