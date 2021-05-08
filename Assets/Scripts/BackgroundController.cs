using UnityEngine;

public class BackgroundController : MonoBehaviour {

    public GameObject L1BG, L2BG, L3BG, L4BG, L5BG, L6BG, L7BG, L8BG, L9BG, L10BG;

    public void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("LevelNumber") == 1)
        {
            if (Player.colorflag == 0)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L1BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 2)
        {
            if (Player.colorflag == 0)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L2BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 3)
        {
            if (Player.colorflag == 0)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L3BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 4)
        {
            if (Player.colorflag == 0)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L4BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 5)
        {
            if (Player.colorflag == 0)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L5BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 6)
        {
            if (Player.colorflag == 0)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L6BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 7)
        {
            if (Player.colorflag == 0)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L7BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 8)
        {
            if (Player.colorflag == 0)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L8BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 9)
        {
            if (Player.colorflag == 0)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L9BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
        else if (PlayerPrefs.GetInt("LevelNumber") == 10)
        {
            if (Player.colorflag == 0)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            if (Player.colorflag == 1)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 20);
            }
            if (Player.colorflag == 2)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 40);
            }
            if (Player.colorflag == 3)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 60);
            }
            if (Player.colorflag == 4)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 80);
            }
            if (Player.colorflag == 5)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 100);
            }
            if (Player.colorflag == 6)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
            }
            if (Player.colorflag == 7)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 140);
            }
            if (Player.colorflag == 8)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 160);
            }
            if (Player.colorflag == 9)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);
            }
            if (Player.colorflag == 10)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 200);
            }
            if (Player.colorflag == 11)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 220);
            }
            if (Player.colorflag == 12)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 240);
            }
            if (Player.colorflag == 13)
            {
                L10BG.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }
    }
}
