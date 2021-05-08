using UnityEngine;
using UnityEngine.UI;

public class AudioControllerScript : MonoBehaviour {

    public Button MusicButton;
    public Sprite MusicOnSprite, MusicOffSprite;

    public void Start()
    {
        UpdateVolume();
    }

    public void PauseMusic()
    {
        ToggleSound();
        UpdateVolume();
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }

    void UpdateVolume()
    {
        if(PlayerPrefs.GetInt("Muted",0)==0)
        {
            AudioListener.volume = 1;
            MusicButton.GetComponent<Image>().sprite = MusicOnSprite;
        }
        else
        {
            AudioListener.volume = 0;
            MusicButton.GetComponent<Image>().sprite = MusicOffSprite;
        }
    }
}
