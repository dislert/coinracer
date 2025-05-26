using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;       // UI ������ �����
    public AudioSource engineSound;      // ������ �� ���� ���������

    void Start()
    {
        pauseMenuUI.SetActive(false);

        if (engineSound != null)
            engineSound.Play(); // �������, ��� ���� �������� ��� ������ ����
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenuUI.activeSelf)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

        if (engineSound != null)
            engineSound.UnPause();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

        if (engineSound != null)
            engineSound.Pause();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        if (engineSound != null)
            engineSound.Stop();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
