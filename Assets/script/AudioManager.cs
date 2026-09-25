using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    // public AudioSource musicSource;
    // public AudioSource sfxSource;
    public Button musicToggleBt;
    public Button sfxToggleBt;

    private bool isMusicOn = true;
    private bool isSFXOn = true;


    public void ToggleMusic()
    {

        isMusicOn = !isMusicOn;
        // musicSource.mute = !musicSource.mute;
        musicToggleBt.GetComponent<Image>().sprite = isMusicOn ? Resources.Load<Sprite>("image/music") : Resources.Load<Sprite>("image/music-mute");

    }


    public void ToggleSFX()
    {
        isSFXOn = !isSFXOn;
        // sfxSource.mute = !sfxSource.mute;
        sfxToggleBt.GetComponent<Image>().sprite = isSFXOn ? Resources.Load<Sprite>("image/sfx") : Resources.Load<Sprite>("image/sfx-mute");
    }

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(gameObject.tag);
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}

