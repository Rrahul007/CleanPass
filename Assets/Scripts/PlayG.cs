using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayG : MonoBehaviour {

    public GameObject MainPanel, StarPanel, LevelPanel, DisplayPanel, HelpPanel;
    public Text TotalText, highScore;
    public static int TotalStars = 0, TotalKites = 0, TotalHearts = 0, TotalDiamonds = 0;
    public static int isMute = 0;
    public Button EL1, EL2, EL3, EL4, EL5, EL6, EL7, EL8, EL9, EL10;
    public Button ML1, ML2, ML3, ML4, ML5, ML6, ML7, ML8, ML9, ML10;
    public Button HL1, HL2, HL3, HL4, HL5, HL6, HL7, HL8, HL9, HL10;


    public Sprite c, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12;
    public Image Character;

    public AudioSource TouchSound;
    
    public void Start()
    {
        TotalStars = PlayerPrefs.GetInt("TotalStars");
        TotalKites = PlayerPrefs.GetInt("TotalKites");
        TotalHearts = PlayerPrefs.GetInt("TotalHearts");
        TotalDiamonds = PlayerPrefs.GetInt("TotalDiamonds");
        PlayerPrefs.SetInt("PlayEasy", 0);
        PlayerPrefs.SetInt("PlayMid", 0);
        PlayerPrefs.SetInt("PlayHard", 0);

        if (PlayerPrefs.GetInt("LevelsActive") == 1)
        {
            LevelPanel.SetActive(true);
            MainPanel.SetActive(false);
            DisplayPanel.SetActive(false);
            PlayerPrefs.SetInt("LevelsActive", 0);
        }


        //Display Image code start
        {
            if (PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Character") == 1)
            {
                Character.sprite = c1;
            }
            else if (PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Character") == 2)
            {
                Character.sprite = c2;
            }
            else if (PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Character") == 3)
            {
                Character.sprite = c3;
            }
            else if (PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Character") == 4)
            {
                Character.sprite = c4;
            }
            else if (PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Character") == 5)
            {
                Character.sprite = c5;
            }
            else if (PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Character") == 6)
            {
                Character.sprite = c6;
            }
            else if (PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Character") == 7)
            {
                Character.sprite = c7;
            }
            else if (PlayerPrefs.GetInt("Is300Sold") == 1 && PlayerPrefs.GetInt("Character") == 8)
            {
                Character.sprite = c8;
            }
            else if (PlayerPrefs.GetInt("Is350Sold") == 1 && PlayerPrefs.GetInt("Character") == 9)
            {
                Character.sprite = c9;
            }
            else if (PlayerPrefs.GetInt("Is400Sold") == 1 && PlayerPrefs.GetInt("Character") == 10)
            {
                Character.sprite = c10;
            }
            else if (PlayerPrefs.GetInt("Is450Sold") == 1 && PlayerPrefs.GetInt("Character") == 11)
            {
                Character.sprite = c11;
            }
            else if (PlayerPrefs.GetInt("Is500Sold") == 1 && PlayerPrefs.GetInt("Character") == 12)
            {
                Character.sprite = c12;
            }
            else
            {
                Character.sprite = c;
            }
        }
        //Display Image code end

        //Easy Level Unlocker code start
        if (PlayerPrefs.GetInt("EL1HighScore") >= 10)
        {
            EL2.interactable = true;
            if (PlayerPrefs.GetInt("EL2HighScore") >= 10)
            {
                EL3.interactable = true;
                if (PlayerPrefs.GetInt("EL3HighScore") >= 10)
                {
                    EL4.interactable = true;
                    if (PlayerPrefs.GetInt("EL4HighScore") >= 10)
                    {
                        EL5.interactable = true;
                        if (PlayerPrefs.GetInt("EL5HighScore") >= 10)
                        {
                            EL6.interactable = true;
                            if (PlayerPrefs.GetInt("EL6HighScore") >= 10)
                            {
                                EL7.interactable = true;
                                if (PlayerPrefs.GetInt("EL7HighScore") >= 10)
                                {
                                    EL8.interactable = true;
                                    if (PlayerPrefs.GetInt("EL8HighScore") >= 10)
                                    {
                                        EL9.interactable = true;
                                        if (PlayerPrefs.GetInt("EL9HighScore") >= 10)
                                        {
                                            EL10.interactable = true;
                                        }
                                        else
                                        {
                                            EL10.interactable = false;
                                        }

                                    }
                                    else
                                    {
                                        EL9.interactable = false;
                                        EL10.interactable = false;
                                    }

                                }
                                else
                                {
                                    EL8.interactable = false;
                                    EL9.interactable = false;
                                    EL10.interactable = false;
                                }

                            }
                            else
                            {
                                EL7.interactable = false;
                                EL8.interactable = false;
                                EL9.interactable = false;
                                EL10.interactable = false;
                            }

                        }
                        else
                        {
                            EL6.interactable = false;
                            EL7.interactable = false;
                            EL8.interactable = false;
                            EL9.interactable = false;
                            EL10.interactable = false;
                        }

                    }
                    else
                    {
                        EL5.interactable = false;
                        EL6.interactable = false;
                        EL7.interactable = false;
                        EL8.interactable = false;
                        EL9.interactable = false;
                        EL10.interactable = false;
                    }

                }
                else
                {
                    EL4.interactable = false;
                    EL5.interactable = false;
                    EL6.interactable = false;
                    EL7.interactable = false;
                    EL8.interactable = false;
                    EL9.interactable = false;
                    EL10.interactable = false;
                }

            }
            else
            {
                EL3.interactable = false;
                EL4.interactable = false;
                EL5.interactable = false;
                EL6.interactable = false;
                EL7.interactable = false;
                EL8.interactable = false;
                EL9.interactable = false;
                EL10.interactable = false;
            }

        }
        else
        {
            EL2.interactable = false;
            EL3.interactable = false;
            EL4.interactable = false;
            EL5.interactable = false;
            EL6.interactable = false;
            EL7.interactable = false;
            EL8.interactable = false;
            EL9.interactable = false;
            EL10.interactable = false;
        }
        //Easy Level Unlocker code end

        //Medium Level Unlocker code start
        if (PlayerPrefs.GetInt("ML1HighScore") >= 20)
        {
            ML2.interactable = true;
            if (PlayerPrefs.GetInt("ML2HighScore") >= 20)
            {
                ML3.interactable = true;
                if (PlayerPrefs.GetInt("ML3HighScore") >= 20)
                {
                    ML4.interactable = true;
                    if (PlayerPrefs.GetInt("ML4HighScore") >= 20)
                    {
                        ML5.interactable = true;
                        if (PlayerPrefs.GetInt("ML5HighScore") >= 20)
                        {
                            ML6.interactable = true;
                            if (PlayerPrefs.GetInt("ML6HighScore") >= 20)
                            {
                                ML7.interactable = true;
                                if (PlayerPrefs.GetInt("ML7HighScore") >= 20)
                                {
                                    ML8.interactable = true;
                                    if (PlayerPrefs.GetInt("ML8HighScore") >= 20)
                                    {
                                        ML9.interactable = true;
                                        if (PlayerPrefs.GetInt("ML9HighScore") >= 20)
                                        {
                                            ML10.interactable = true;
                                        }
                                        else
                                        {
                                            ML10.interactable = false;
                                        }
                                    }
                                    else
                                    {
                                        ML9.interactable = false;
                                        ML10.interactable = false;
                                    }
                                }
                                else
                                {
                                    ML8.interactable = false;
                                    ML9.interactable = false;
                                    ML10.interactable = false;
                                }
                            }
                            else
                            {
                                ML7.interactable = false;
                                ML8.interactable = false;
                                ML9.interactable = false;
                                ML10.interactable = false;
                            }
                        }
                        else
                        {
                            ML6.interactable = false;
                            ML7.interactable = false;
                            ML8.interactable = false;
                            ML9.interactable = false;
                            ML10.interactable = false;
                        }
                    }
                    else
                    {
                        ML5.interactable = false;
                        ML6.interactable = false;
                        ML7.interactable = false;
                        ML8.interactable = false;
                        ML9.interactable = false;
                        ML10.interactable = false;
                    }
                }
                else
                {
                    ML4.interactable = false;
                    ML5.interactable = false;
                    ML6.interactable = false;
                    ML7.interactable = false;
                    ML8.interactable = false;
                    ML9.interactable = false;
                    ML10.interactable = false;
                }
            }
            else
            {
                ML3.interactable = false;
                ML4.interactable = false;
                ML5.interactable = false;
                ML6.interactable = false;
                ML7.interactable = false;
                ML8.interactable = false;
                ML9.interactable = false;
                ML10.interactable = false;
            }
        }
        else
        {
            ML2.interactable = false;
            ML3.interactable = false;
            ML4.interactable = false;
            ML5.interactable = false;
            ML6.interactable = false;
            ML7.interactable = false;
            ML8.interactable = false;
            ML9.interactable = false;
            ML10.interactable = false;
        }
        //Medium Level Unlocker code end

        //Hard Level Unlocker code start
        if (PlayerPrefs.GetInt("HL1HighScore") >= 30)
        {
            HL2.interactable = true;
            if (PlayerPrefs.GetInt("HL2HighScore") >= 30)
            {
                HL3.interactable = true;
                if (PlayerPrefs.GetInt("HL3HighScore") >= 30)
                {
                    HL4.interactable = true;
                    if (PlayerPrefs.GetInt("HL4HighScore") >= 30)
                    {
                        HL5.interactable = true;
                        if (PlayerPrefs.GetInt("HL5HighScore") >= 30)
                        {
                            HL6.interactable = true;
                            if (PlayerPrefs.GetInt("HL6HighScore") >= 30)
                            {
                                HL7.interactable = true;
                                if (PlayerPrefs.GetInt("HL7HighScore") >= 30)
                                {
                                    HL8.interactable = true;
                                    if (PlayerPrefs.GetInt("HL8HighScore") >= 30)
                                    {
                                        HL9.interactable = true;
                                        if (PlayerPrefs.GetInt("HL9HighScore") >= 30)
                                        {
                                            HL10.interactable = true;
                                        }
                                        else
                                        {
                                            HL10.interactable = false;
                                        }
                                    }
                                    else
                                    {
                                        HL9.interactable = false;
                                        HL10.interactable = false;
                                    }
                                }
                                else
                                {
                                    HL8.interactable = false;
                                    HL9.interactable = false;
                                    HL10.interactable = false;
                                }
                            }
                            else
                            {
                                HL7.interactable = false;
                                HL8.interactable = false;
                                HL9.interactable = false;
                                HL10.interactable = false;
                            }
                        }
                        else
                        {
                            HL6.interactable = false;
                            HL7.interactable = false;
                            HL8.interactable = false;
                            HL9.interactable = false;
                            HL10.interactable = false;
                        }
                    }
                    else
                    {
                        HL5.interactable = false;
                        HL6.interactable = false;
                        HL7.interactable = false;
                        HL8.interactable = false;
                        HL9.interactable = false;
                        HL10.interactable = false;
                    }
                }
                else
                {
                    HL4.interactable = false;
                    HL5.interactable = false;
                    HL6.interactable = false;
                    HL7.interactable = false;
                    HL8.interactable = false;
                    HL9.interactable = false;
                    HL10.interactable = false;
                }
            }
            else
            {
                HL3.interactable = false;
                HL4.interactable = false;
                HL5.interactable = false;
                HL6.interactable = false;
                HL7.interactable = false;
                HL8.interactable = false;
                HL9.interactable = false;
                HL10.interactable = false;
            }
        }
        else
        {
            HL2.interactable = false;
            HL3.interactable = false;
            HL4.interactable = false;
            HL5.interactable = false;
            HL6.interactable = false;
            HL7.interactable = false;
            HL8.interactable = false;
            HL9.interactable = false;
            HL10.interactable = false;
        }
        //Hard Level Unlocker code end
    }

    public void Update()
    {
        //Setting Highest Score
        {
            if (PlayerPrefs.GetInt("EL1HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL1HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL2HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL2HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL3HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL3HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL4HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL4HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL5HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL5HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL6HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL6HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL7HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL7HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL8HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL8HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL9HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL9HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("EL10HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("EL10HighScore"));
                PlayerPrefs.SetInt("HighColor", 1);
            }
            if (PlayerPrefs.GetInt("ML1HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML1HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML2HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML2HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML3HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML3HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML4HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML4HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML5HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML5HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML6HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML6HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML7HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML7HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML8HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML8HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML9HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML9HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("ML10HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("ML10HighScore"));
                PlayerPrefs.SetInt("HighColor", 2);
            }
            if (PlayerPrefs.GetInt("HL1HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL1HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL2HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL2HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL3HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL3HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL4HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL4HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL5HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL5HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL6HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL6HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL7HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL7HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL8HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL8HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL9HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL9HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }
            if (PlayerPrefs.GetInt("HL10HighScore") > PlayerPrefs.GetInt("Highest"))
            {
                PlayerPrefs.SetInt("Highest", PlayerPrefs.GetInt("HL10HighScore"));
                PlayerPrefs.SetInt("HighColor", 3);
            }

            switch (PlayerPrefs.GetInt("HighColor"))
            {
                case 1:
                    highScore.GetComponent<Text>().color = new Color32(59, 218, 37, 255);
                    break;

                case 2:
                    highScore.GetComponent<Text>().color = new Color32(255, 146, 0, 255);
                    break;

                case 3:
                    highScore.GetComponent<Text>().color = new Color32(255, 0, 0, 255);
                    break;
                default:
                    highScore.GetComponent<Text>().color = new Color32(0, 0, 0, 255);
                    break;
            }

            highScore.text = (PlayerPrefs.GetInt("Highest").ToString());
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }


    public void PlayEasy()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy2()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy3()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 3);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy4()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 4);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy5()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 5);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy6()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 6);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy7()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 7);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy8()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 8);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy9()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 9);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayEasy10()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayEasy", 1);
        PlayerPrefs.SetInt("LevelNumber", 10);
        Time.timeScale = 1f;
        SceneManager.LoadScene("BeginerLevel");
    }

    public void PlayMid()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid2()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid3()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 3);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid4()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 4);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid5()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 5);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid6()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 6);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid7()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 7);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid8()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 8);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid9()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 9);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayMid10()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayMid", 1);
        PlayerPrefs.SetInt("LevelNumber", 10);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intermediate");
    }

    public void PlayHard()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard2()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard3()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 3);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard4()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 4);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard5()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 5);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard6()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 6);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard7()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 7);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard8()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 8);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard9()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 9);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayHard10()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("PlayHard", 1);
        PlayerPrefs.SetInt("LevelNumber", 10);
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }

    public void PlayPanelOkay()
    {
        TouchSound.Play();
        LevelPanel.SetActive(false);
        MainPanel.SetActive(true);
        DisplayPanel.SetActive(true);
    }

    public void StarPanelOkay()
    {
        TouchSound.Play();
        StarPanel.SetActive(false);
        MainPanel.SetActive(true);
        DisplayPanel.SetActive(true);
    }

    public void LevelSelection()
    {
        TouchSound.Play();
        LevelPanel.SetActive(true);
        MainPanel.SetActive(false);
        DisplayPanel.SetActive(false);
    }

    public void TotalCollection()
    {
        TouchSound.Play();
        TotalText.text = (TotalStars).ToString();
        StarPanel.SetActive(true);
        MainPanel.SetActive(false);
        DisplayPanel.SetActive(false);
    }

    public void GoStore()
    {
        TouchSound.Play();
        SceneManager.LoadScene("ShopScene");
    }

    public void Help()
    {
        TouchSound.Play();
        HelpPanel.SetActive(true);
        MainPanel.SetActive(false);
        DisplayPanel.SetActive(false);
    }

    public void HelpOkay()
    {
        TouchSound.Play();
        HelpPanel.SetActive(false);
        MainPanel.SetActive(true);
        DisplayPanel.SetActive(true);
    }

    public void ResetPlayerPrefs()
    {
        TouchSound.Play();
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Menu");
    }
}
