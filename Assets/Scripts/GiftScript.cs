using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiftScript : MonoBehaviour {

    public GameObject giftPanel;
    public Button giftButton, closeButton;
    public Text starText;
    public int GiftStars;
    public AudioSource TouchSound, CoinSound;

    public Button Gift1, Gift2, Gift3, Gift4, Gift5, Gift6;

    public int min1 = 0, max1 = 100;
    public int min2 = 100, max2 = 200;
    public int min3 = 200, max3 = 300;
    public int min4 = 300, max4 = 400;
    public int min5 = 400, max5 = 500;
    public int min6 = 500, max6 = 1000;

    public Text i;

    void Start ()
    {
        if (PlayerPrefs.GetInt("Gift1Flag") == 1)
        {
            Gift1.interactable = true;
        }
        else
        {
            Gift1.interactable = false;
        }

        if (PlayerPrefs.GetInt("Gift2Flag") == 1)
        {
            Gift2.interactable = true;
        }
        else
        {
            Gift2.interactable = false;
        }

        if (PlayerPrefs.GetInt("Gift3Flag") == 1)
        {
            Gift3.interactable = true;
        }
        else
        {
            Gift3.interactable = false;
        }

        if (PlayerPrefs.GetInt("Gift4Flag") == 1)
        {
            Gift4.interactable = true;
        }
        else
        {
            Gift4.interactable = false;
        }

        if (PlayerPrefs.GetInt("Gift5Flag") == 1)
        {
            Gift5.interactable = true;
        }
        else
        {
            Gift5.interactable = false;
        }

        if (PlayerPrefs.GetInt("Gift6Flag") == 1)
        {
            Gift6.interactable = true;
        }
        else
        {
            Gift6.interactable = false;
        }
    }

    public void Update()
    {
        if (Gift1.IsInteractable() == true || Gift2.IsInteractable() == true || Gift3.IsInteractable() == true || Gift4.IsInteractable() == true || Gift5.IsInteractable() == true || Gift6.IsInteractable() == true)
        {
            giftButton.interactable = true;
            i.enabled = true;
        }
        else
        {
            giftButton.interactable = false;
            i.enabled = false;
        }
    }

    public void GiftPanelButton()
    {
        TouchSound.Play();
        giftPanel.SetActive(true);
    }

	public void YouWon1()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min1, max1);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift1.interactable = false;
        PlayerPrefs.SetInt("Gift1Flag", 0);
    }
    public void YouWon2()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min2, max2);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift2.interactable = false;
        PlayerPrefs.SetInt("Gift2Flag", 0);
    }
    public void YouWon3()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min3, max3);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift3.interactable = false;
        PlayerPrefs.SetInt("Gift3Flag", 0);
    }
    public void YouWon4()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min4, max4);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift4.interactable = false;
        PlayerPrefs.SetInt("Gift4Flag", 0);
    }
    public void YouWon5()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min5, max5);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift5.interactable = false;
        PlayerPrefs.SetInt("Gift5Flag", 0);
    }
    public void YouWon6()
    {
        CoinSound.Play();
        GiftStars = Random.Range(min6, max6);
        starText.text = GiftStars + " Stars!!!";
        GiftStars = PlayerPrefs.GetInt("TotalStars") + GiftStars;
        PlayerPrefs.SetInt("TotalStars", GiftStars);
        Gift6.interactable = false;
        PlayerPrefs.SetInt("Gift6Flag", 0);
    }

    public void Close()
    {
        TouchSound.Play();
        SceneManager.LoadScene("Menu");
    }
}
