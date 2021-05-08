using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    
    public Rigidbody2D rb;
    public int score = 0;
    public Text ScoreText,HighScoreText;
    public int flag = 0, kflag = 0, hflag = 0, dflag = 0;
    public GameObject GameOverPanel;
    public AudioSource TouchSound, CloseSound, HighScoreSound;
    public Button pauseButton;
    public Text YourScore;

    public int kiteCount, heartCount, diamondCount;

    public Sprite c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12;
    public GameObject playball;

    public static int colorflag = 0;


    public void Start()
    {
        colorflag = 0;
        if (PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Character") == 1)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c1;
        }
        else if (PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Character") == 2)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c2;
        }
        else if (PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Character") == 3)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c3;
        }
        else if (PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Character") == 4)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c4;
        }
        else if (PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Character") == 5)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c5;
        }
        else if (PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Character") == 6)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c6;
        }
        else if (PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Character") == 7)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c7;
        }
        else if (PlayerPrefs.GetInt("Is300Sold") == 1 && PlayerPrefs.GetInt("Character") == 8)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c8;
        }
        else if (PlayerPrefs.GetInt("Is350Sold") == 1 && PlayerPrefs.GetInt("Character") == 9)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c9;
        }
        else if (PlayerPrefs.GetInt("Is400Sold") == 1 && PlayerPrefs.GetInt("Character") == 10)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c10;
        }
        else if (PlayerPrefs.GetInt("Is450Sold") == 1 && PlayerPrefs.GetInt("Character") == 11)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c11;
        }
        else if (PlayerPrefs.GetInt("Is500Sold") == 1 && PlayerPrefs.GetInt("Character") == 12)
        {
            playball.GetComponent<SpriteRenderer>().sprite = c12;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        //Vector2 pointer = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        Vector2 pointer = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.position = pointer;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Star"))
        {
            Destroy(col.gameObject);
            if (PlayerPrefs.GetInt("HSPass") == 1)
            {
                HighScoreSound.Play();
                PlayerPrefs.SetInt("HSPass", 0);
            }
            else
            {
                TouchSound.Play();
            }
            flag = 1;
        }
        {/*if (col.gameObject.CompareTag("Kite"))
        {
            Destroy(col.gameObject);
            TouchSound.Play();
            flag = 1;
            kflag = 1;
        }
        if (col.gameObject.CompareTag("Heart"))
        {
            Destroy(col.gameObject);
            TouchSound.Play();
            flag = 1;
            hflag = 1;
        }
        if (col.gameObject.CompareTag("Diamond"))
        {
            Destroy(col.gameObject);
            TouchSound.Play();
            flag = 1;
            dflag = 1;
        }*/
        }
        if (col.gameObject.CompareTag("Enemy"))
        {
            CloseSound.Play();
            GameOver();
        }
    }

    public void GameOver()
    {
        pauseButton.interactable = !pauseButton.interactable;
        GameOverPanel.SetActive(true);
        YourScore.text = (score).ToString();
        Time.timeScale = 0f;
    }

    private void FixedUpdate()
    {

        if (flag == 1)
        {
            score++;
            PlayG.TotalStars++;
            PlayerPrefs.SetInt("TotalStars", PlayG.TotalStars);
            ScoreText.text = (score).ToString();
            flag = 0;

            //Background Color change code
            {
                if (score >= 0 && score < 5)
                {
                    colorflag = 0;
                }
                if (score >= 5 && score < 10)
                {
                    colorflag = 1;
                }
                if (score >= 10 && score < 15)
                {
                    colorflag = 2;
                }
                if (score >= 15 && score < 20)
                {
                    colorflag = 3;
                }
                if (score >= 20 && score < 25)
                {
                    colorflag = 4;
                }
                if (score >= 25 && score < 30)
                {
                    colorflag = 5;
                }
                if (score >= 30 && score < 35)
                {
                    colorflag = 6;
                }
                if (score >= 35 && score < 40)
                {
                    colorflag = 7;
                }
                if (score >= 40 && score < 45)
                {
                    colorflag = 8;
                }
                if (score >= 45 && score < 50)
                {
                    colorflag = 9;
                }
                if (score >= 50 && score < 60)
                {
                    colorflag = 10;
                }
                if (score >= 60 && score < 80)
                {
                    colorflag = 11;
                }
                if (score >= 80 && score < 100)
                {
                    colorflag = 12;
                }
                if (score >= 100)
                {
                    colorflag = 13;
                }
            }
            //Code ends


            //Gift Button Enabling flag code Start
            {
                if (score >= 100 && score < 200)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                }
                if (score >= 200 && score < 300)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                    PlayerPrefs.SetInt("Gift2Flag", 1);
                }
                if (score >= 300 && score < 400)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                    PlayerPrefs.SetInt("Gift2Flag", 1);
                    PlayerPrefs.SetInt("Gift3Flag", 1);
                }
                if (score >= 400 && score < 500)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                    PlayerPrefs.SetInt("Gift2Flag", 1);
                    PlayerPrefs.SetInt("Gift3Flag", 1);
                    PlayerPrefs.SetInt("Gift4Flag", 1);
                }
                if (score >= 500 && score < 1000)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                    PlayerPrefs.SetInt("Gift2Flag", 1);
                    PlayerPrefs.SetInt("Gift3Flag", 1);
                    PlayerPrefs.SetInt("Gift4Flag", 1);
                    PlayerPrefs.SetInt("Gift5Flag", 1);
                }
                if (score >= 1000)
                {
                    PlayerPrefs.SetInt("Gift1Flag", 1);
                    PlayerPrefs.SetInt("Gift2Flag", 1);
                    PlayerPrefs.SetInt("Gift3Flag", 1);
                    PlayerPrefs.SetInt("Gift4Flag", 1);
                    PlayerPrefs.SetInt("Gift5Flag", 1);
                    PlayerPrefs.SetInt("Gift6Flag", 1);
                }
            }
            //Gift Button Enabling flag code End

            //Level High Score Setting code ***FINAL
            {
                if (PlayerPrefs.GetInt("LevelNumber") == 1)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL1HighScore"))
                        {
                            PlayerPrefs.SetInt("EL1HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if(PlayerPrefs.GetInt("PlayMid")==1)
                    {
                        if (score > PlayerPrefs.GetInt("ML1HighScore"))
                        {
                            PlayerPrefs.SetInt("ML1HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL1HighScore"))
                        {
                            PlayerPrefs.SetInt("HL1HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 2)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL2HighScore"))
                        {
                            PlayerPrefs.SetInt("EL2HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML2HighScore"))
                        {
                            PlayerPrefs.SetInt("ML2HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL2HighScore"))
                        {
                            PlayerPrefs.SetInt("HL2HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 3)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL3HighScore"))
                        {
                            PlayerPrefs.SetInt("EL3HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML3HighScore"))
                        {
                            PlayerPrefs.SetInt("ML3HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL3HighScore"))
                        {
                            PlayerPrefs.SetInt("HL3HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 4)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL4HighScore"))
                        {
                            PlayerPrefs.SetInt("EL4HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML4HighScore"))
                        {
                            PlayerPrefs.SetInt("ML4HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL4HighScore"))
                        {
                            PlayerPrefs.SetInt("HL4HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 5)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL5HighScore"))
                        {
                            PlayerPrefs.SetInt("EL5HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML5HighScore"))
                        {
                            PlayerPrefs.SetInt("ML5HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL5HighScore"))
                        {
                            PlayerPrefs.SetInt("HL5HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 6)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL6HighScore"))
                        {
                            PlayerPrefs.SetInt("EL6HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML6HighScore"))
                        {
                            PlayerPrefs.SetInt("ML6HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL6HighScore"))
                        {
                            PlayerPrefs.SetInt("HL6HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 7)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL7HighScore"))
                        {
                            PlayerPrefs.SetInt("EL7HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML7HighScore"))
                        {
                            PlayerPrefs.SetInt("ML7HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL7HighScore"))
                        {
                            PlayerPrefs.SetInt("HL7HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 8)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL8HighScore"))
                        {
                            PlayerPrefs.SetInt("EL8HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML8HighScore"))
                        {
                            PlayerPrefs.SetInt("ML8HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL8HighScore"))
                        {
                            PlayerPrefs.SetInt("HL8HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 9)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL9HighScore"))
                        {
                            PlayerPrefs.SetInt("EL9HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML9HighScore"))
                        {
                            PlayerPrefs.SetInt("ML9HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL9HighScore"))
                        {
                            PlayerPrefs.SetInt("HL9HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("LevelNumber") == 10)
                {
                    if (PlayerPrefs.GetInt("PlayEasy") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("EL10HighScore"))
                        {
                            PlayerPrefs.SetInt("EL10HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayMid") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("ML10HighScore"))
                        {
                            PlayerPrefs.SetInt("ML10HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                    else if (PlayerPrefs.GetInt("PlayHard") == 1)
                    {
                        if (score > PlayerPrefs.GetInt("HL10HighScore"))
                        {
                            PlayerPrefs.SetInt("HL10HighScore", score);
                            PlayerPrefs.SetInt("HSPass", 1);
                        }
                    }
                }

            }
            //Level High Score Setting code end ***FINAL

        }

        //Showing Highscore in Gameplay ***FINAL
        {
            if (PlayerPrefs.GetInt("LevelNumber") == 1)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL1HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML1HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL1HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 2)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL2HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML2HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL2HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 3)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL3HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML3HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL3HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 4)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL4HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML4HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL4HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 5)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL5HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML5HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL5HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 6)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL6HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML6HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL6HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 7)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL7HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML7HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL7HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 8)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL8HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML8HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL8HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 9)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL9HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML9HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL9HighScore")).ToString();
                }
            }
            else if (PlayerPrefs.GetInt("LevelNumber") == 10)
            {
                if (PlayerPrefs.GetInt("PlayEasy") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("EL10HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayMid") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("ML10HighScore")).ToString();
                }
                else if (PlayerPrefs.GetInt("PlayHard") == 1)
                {
                    HighScoreText.text = (PlayerPrefs.GetInt("HL10HighScore")).ToString();
                }
            }
        }
        //Showing Highscore in Gameplay ***FINAL


        {//if (kflag == 1)
         //{
         //    kiteCount++;
         //    PlayG.TotalKites++;
         //    PlayerPrefs.SetInt("KiteCount", PlayG.TotalKites);
         //    kflag = 0;
         //}
         //if (hflag == 1)
         //{
         //    heartCount++;
         //    PlayG.TotalHearts++;
         //    PlayerPrefs.SetInt("HeartCount", PlayG.TotalHearts);
         //    hflag = 0;
         //}
         //if (dflag == 1)
         //{
         //    diamondCount++;
         //    PlayG.TotalDiamonds++;
         //    PlayerPrefs.SetInt("DiamondCount", PlayG.TotalDiamonds);
         //    dflag = 0;
         //}
        }
    }
}
