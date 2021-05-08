using UnityEngine;
using UnityEngine.UI;

public class ExchangeScript : MonoBehaviour {

    public Text StarAmountText;
    public Text DiamondAmountText, HeartAmountText, KiteAmountText;
    public AudioSource TouchSound, CoinSound;
    public GameObject ExchangePanel, MsgPanel, ShopPanel;

    public void BuyKite()
    {
        TouchSound.Play();
        if (PlayG.TotalStars >= 1)
        {
            CoinSound.Play();
            PlayG.TotalStars -= 1;
            PlayG.TotalKites++;
            PlayerPrefs.SetInt("TotalKites", PlayG.TotalKites);
            PlayerPrefs.SetInt("TotalStars", PlayG.TotalStars);
        }
        else
        {
            ExchangePanel.SetActive(false);
            MsgPanel.SetActive(true);
        }
    }

    public void BuyHeart()
    {
        TouchSound.Play();
        if (PlayG.TotalStars >= 2)
        {
            CoinSound.Play();
            PlayG.TotalStars -= 2;
            PlayG.TotalHearts++;
            PlayerPrefs.SetInt("TotalHearts", PlayG.TotalHearts);
            PlayerPrefs.SetInt("TotalStars", PlayG.TotalStars);
        }
        else
        {
            ExchangePanel.SetActive(false);
            MsgPanel.SetActive(true);
        }
    }

    public void BuyDiamond()
    {
        TouchSound.Play();
        if (PlayG.TotalStars >= 3)
        {
            CoinSound.Play();
            PlayG.TotalStars -= 3;
            PlayG.TotalDiamonds++;
            PlayerPrefs.SetInt("TotalDiamonds", PlayG.TotalDiamonds);
            PlayerPrefs.SetInt("TotalStars", PlayG.TotalStars);
        }
        else
        {
            ExchangePanel.SetActive(false);
            MsgPanel.SetActive(true);
        }
    }

    public void Back()
    {
        TouchSound.Play();
        ExchangePanel.SetActive(false);
        ShopPanel.SetActive(true);
    }

    public void Okay()
    {
        TouchSound.Play();
        MsgPanel.SetActive(false);
        ExchangePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update ()
    {
        StarAmountText.text = PlayerPrefs.GetInt("TotalStars").ToString();
        KiteAmountText.text = PlayerPrefs.GetInt("TotalKites").ToString();
        HeartAmountText.text = PlayerPrefs.GetInt("TotalHearts").ToString();
        DiamondAmountText.text = PlayerPrefs.GetInt("TotalDiamonds").ToString();
    }
}
