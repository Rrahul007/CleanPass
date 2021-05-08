using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour {

    public static bool ispause = false;
    public GameObject PauseMenu, GameOverPanel;
    public AudioSource TouchSound, CloseSound;

    public GameObject Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10;

    public void Start()
    {
        switch (PlayerPrefs.GetInt("LevelNumber"))
        {
            case 1:
                Level1.SetActive(true);
                break;

            case 2:
                Level2.SetActive(true);
                break;

            case 3:
                Level3.SetActive(true);
                break;

            case 4:
                Level4.SetActive(true);
                break;

            case 5:
                Level5.SetActive(true);
                break;

            case 6:
                Level6.SetActive(true);
                break;

            case 7:
                Level7.SetActive(true);
                break;

            case 8:
                Level8.SetActive(true);
                break;

            case 9:
                Level9.SetActive(true);
                break;

            case 10:
                Level10.SetActive(true);
                break;
        }
    }

    public void GoHome()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("LevelsActive", 1);
        SceneManager.LoadScene("Menu");
    }

    public void NewGame()
    {
        TouchSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }
        
    public void Resume()
    {
        TouchSound.Play();
        PauseMenu.SetActive(false);
        Time.timeScale=1f;
        ispause = false;
    }

    public void Pause()
    {
        TouchSound.Play();
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        ispause = true;
    }

}
