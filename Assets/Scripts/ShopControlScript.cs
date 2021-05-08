using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopControlScript : MonoBehaviour {

    public Text Ball1Price, Ball2Price, Ball3Price, Ball4Price, Ball5Price, Ball6Price;
    public Text Ball7Price, Ball8Price, Ball9Price, Ball10Price, Ball11Price, Ball12Price;

    public Button B1Button, B2Button, B3Button, B4Button, B5Button, B6Button;
    public Button B7Button, B8Button, B9Button, B10Button, B11Button, B12Button;

    //public Button XCButton;
    public GameObject ExchangePanel, ShopPanel;

    public Button BSelect, B1Select, B2Select, B3Select, B4Select, B5Select, B6Select, B7Select, B8Select, B9Select, B10Select, B11Select, B12Select;
    public Text BSelectText, B1SelectText, B2SelectText, B3SelectText, B4SelectText, B5SelectText, B6SelectText, B7SelectText, B8SelectText, B9SelectText, B10SelectText, B11SelectText, B12SelectText;

    public AudioSource TouchSound, CoinSound;



    // Update is called once per frame
    void Update ()
    {
        if (PlayG.TotalKites >= 5 && PlayerPrefs.GetInt("Is10Sold") == 0)
        {
            B1Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is10Sold") == 1)
            {
                Ball1Price.text = "You Got Me!";
                B1Select.interactable = true;
            }
            B1Button.interactable = false;
            B2Button.interactable = false;
            B3Button.interactable = false;
            B4Button.interactable = false;
            B5Button.interactable = false;
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 10 && PlayG.TotalHearts >= 5 && PlayerPrefs.GetInt("Is20Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1)
        {
            B2Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is20Sold") == 1)
            {
                Ball2Price.text = "You Got Me!";
                B2Select.interactable = true;
            }
            B2Button.interactable = false;
            B3Button.interactable = false;
            B4Button.interactable = false;
            B5Button.interactable = false;
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 15 && PlayG.TotalHearts >= 15 && PlayG.TotalDiamonds >= 15 && PlayerPrefs.GetInt("Is50Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1)
        {
            B3Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is50Sold") == 1)
            {
                Ball3Price.text = "You Got Me!";
                B3Select.interactable = true;
            }
            B3Button.interactable = false;
            B4Button.interactable = false;
            B5Button.interactable = false;
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 20 && PlayG.TotalHearts >= 25 && PlayG.TotalDiamonds >= 30 && PlayerPrefs.GetInt("Is100Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1)
        {
            B4Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is100Sold") == 1)
            {
                Ball4Price.text = "You Got Me!";
                B4Select.interactable = true;
            }
            B4Button.interactable = false;
            B5Button.interactable = false;
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 25 && PlayG.TotalHearts >= 35 && PlayG.TotalDiamonds >= 40 && PlayerPrefs.GetInt("Is150Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1)
        {
            B5Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is150Sold") == 1)
            {
                Ball5Price.text = "You Got Me!";
                B5Select.interactable = true;
            }
            B5Button.interactable = false;
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 30 && PlayG.TotalHearts >= 45 && PlayG.TotalDiamonds >= 50 && PlayerPrefs.GetInt("Is200Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1)
        {
            B6Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is200Sold") == 1)
            {
                Ball6Price.text = "You Got Me!";
                B6Select.interactable = true;
            }
            B6Button.interactable = false;
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 35 && PlayG.TotalHearts >= 55 && PlayG.TotalDiamonds >= 60 && PlayerPrefs.GetInt("Is250Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1)
        {
            B7Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is250Sold") == 1)
            {
                Ball7Price.text = "You Got Me!";
                B7Select.interactable = true;
            }
            B7Button.interactable = false;
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 40 && PlayG.TotalHearts >= 65 && PlayG.TotalDiamonds >= 70 && PlayerPrefs.GetInt("Is300Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Is250Sold") == 1)
        {
            B8Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is300Sold") == 1)
            {
                Ball8Price.text = "You Got Me!";
                B8Select.interactable = true;
            }
            B8Button.interactable = false;
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 45 && PlayG.TotalHearts >= 75 && PlayG.TotalDiamonds >= 80 && PlayerPrefs.GetInt("Is350Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Is300Sold") == 1)
        {
            B9Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is350Sold") == 1)
            {
                Ball9Price.text = "You Got Me!";
                B9Select.interactable = true;
            }
            B9Button.interactable = false;
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 50 && PlayG.TotalHearts >= 85 && PlayG.TotalDiamonds >= 90 && PlayerPrefs.GetInt("Is400Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Is300Sold") == 1 && PlayerPrefs.GetInt("Is350Sold") == 1)
        {
            B10Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is400Sold") == 1)
            {
                Ball10Price.text = "You Got Me!";
                B10Select.interactable = true;
            }
            B10Button.interactable = false;
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 55 && PlayG.TotalHearts >= 95 && PlayG.TotalDiamonds >= 100 && PlayerPrefs.GetInt("Is450Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Is300Sold") == 1 && PlayerPrefs.GetInt("Is350Sold") == 1 && PlayerPrefs.GetInt("Is400Sold") == 1)
        {
            B11Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is450Sold") == 1)
            {
                Ball11Price.text = "You Got Me!";
                B11Select.interactable = true;
            }
            B11Button.interactable = false;
            B12Button.interactable = false;
        }

        if (PlayG.TotalKites >= 60 && PlayG.TotalHearts >= 100 && PlayG.TotalDiamonds >= 100 && PlayerPrefs.GetInt("Is500Sold") == 0 && PlayerPrefs.GetInt("Is10Sold") == 1 && PlayerPrefs.GetInt("Is20Sold") == 1 && PlayerPrefs.GetInt("Is50Sold") == 1 && PlayerPrefs.GetInt("Is100Sold") == 1 && PlayerPrefs.GetInt("Is150Sold") == 1 && PlayerPrefs.GetInt("Is200Sold") == 1 && PlayerPrefs.GetInt("Is250Sold") == 1 && PlayerPrefs.GetInt("Is300Sold") == 1 && PlayerPrefs.GetInt("Is350Sold") == 1 && PlayerPrefs.GetInt("Is400Sold") == 1 && PlayerPrefs.GetInt("Is450Sold") == 1)
        {
            B12Button.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("Is500Sold") == 1)
            {
                Ball12Price.text = "You Got Me!";
                B12Select.interactable = true;
            }
            B12Button.interactable = false;
        }

        ////////////////////////////////////////////////////////
        if(PlayerPrefs.GetInt("Character")==0)
        {
            BSelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 1)
        {
            B1SelectText.text = "Selected";

            BSelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 2)
        {
            B2SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 3)
        {
            B3SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 4)
        {
            B4SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 5)
        {
            B5SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 6)
        {
            B6SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 7)
        {
            B7SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 8)
        {
            B8SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 9)
        {
            B9SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 10)
        {
            B10SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 11)
        {
            BSelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
            B12SelectText.text = "Select Me";
        }

        if (PlayerPrefs.GetInt("Character") == 12)
        {
            B12SelectText.text = "Selected";

            B1SelectText.text = "Select Me";
            B2SelectText.text = "Select Me";
            B3SelectText.text = "Select Me";
            B4SelectText.text = "Select Me";
            B5SelectText.text = "Select Me";
            B6SelectText.text = "Select Me";
            B7SelectText.text = "Select Me";
            B8SelectText.text = "Select Me";
            B9SelectText.text = "Select Me";
            B10SelectText.text = "Select Me";
            B11SelectText.text = "Select Me";
            BSelectText.text = "Select Me";
        }
    }


    public void XchangeOpen()
    {
        TouchSound.Play();
        ExchangePanel.SetActive(true);
        ShopPanel.SetActive(false);
    }

    //Character Buying Methods
    public void Buy10()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 5;
        PlayerPrefs.SetInt("Is10Sold",1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        Ball1Price.text = "You Got Me!";
    }

    public void Buy20()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 10;
        PlayG.TotalHearts -= 5;
        PlayerPrefs.SetInt("Is20Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        Ball2Price.text = "You Got Me!";
    }

    public void Buy50()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 15;
        PlayG.TotalHearts -= 15;
        PlayG.TotalDiamonds -= 15;
        PlayerPrefs.SetInt("Is50Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball3Price.text = "You Got Me!";
    }

    public void Buy100()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 20;
        PlayG.TotalHearts -= 25;
        PlayG.TotalDiamonds -= 30;
        PlayerPrefs.SetInt("Is100Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball4Price.text = "You Got Me!";
    }

    public void Buy150()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 25;
        PlayG.TotalHearts -= 35;
        PlayG.TotalDiamonds -= 40;
        PlayerPrefs.SetInt("Is150Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball5Price.text = "You Got Me!";
    }

    public void Buy200()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 30;
        PlayG.TotalHearts -= 45;
        PlayG.TotalDiamonds -= 50;
        PlayerPrefs.SetInt("Is200Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball6Price.text = "You Got Me!";
    }

    public void Buy250()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 35;
        PlayG.TotalHearts -= 50;
        PlayG.TotalDiamonds -= 60;
        PlayerPrefs.SetInt("Is250Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball7Price.text = "You Got Me!";
    }

    public void Buy300()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 40;
        PlayG.TotalHearts -= 65;
        PlayG.TotalDiamonds -= 70;
        PlayerPrefs.SetInt("Is300Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball8Price.text = "You Got Me!";
    }

    public void Buy350()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 45;
        PlayG.TotalHearts -= 75;
        PlayG.TotalDiamonds -= 80;
        PlayerPrefs.SetInt("Is350Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball9Price.text = "You Got Me!";
    }

    public void Buy400()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 50;
        PlayG.TotalHearts -= 85;
        PlayG.TotalDiamonds -= 90;
        PlayerPrefs.SetInt("Is400Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball10Price.text = "You Got Me!";
    }

    public void Buy450()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 55;
        PlayG.TotalHearts -= 95;
        PlayG.TotalDiamonds -= 100;
        PlayerPrefs.SetInt("Is450Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball11Price.text = "You Got Me!";
    }

    public void Buy500()
    {
        CoinSound.Play();
        PlayG.TotalKites -= 60;
        PlayG.TotalHearts -= 100;
        PlayG.TotalDiamonds -= 100;
        PlayerPrefs.SetInt("Is500Sold", 1);
        PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
        PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
        PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
        Ball12Price.text = "You Got Me!";
    }


    //Character Selection Methods Start
    public void CharaterDefaultSelection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 0);
    }

    public void Charater1Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 1);
    }

    public void Charater2Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 2);
    }

    public void Charater3Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 3);
    }

    public void Charater4Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 4);
    }

    public void Charater5Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 5);
    }

    public void Charater6Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 6);
    }

    public void Charater7Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 7);
    }

    public void Charater8Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 8);
    }

    public void Charater9Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 9);
    }

    public void Charater10Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 10);
    }

    public void Charater11Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 11);
    }

    public void Charater12Selection()
    {
        TouchSound.Play();
        PlayerPrefs.SetInt("Character", 12);
    }

    //Character Selection Code End


    public void ExitShop()
    {
        TouchSound.Play();
        SceneManager.LoadScene("Menu");
    }
}
