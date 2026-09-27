using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Button musicToggleBt;
    public Button sfxToggleBt;


    private bool isSFXoff = false;

    public AudioManager audioManager;
    public void StartGame()
    {
        Debug.Log("Start Game");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void ToggleMusic()
    {


        audioManager.MusicSource.mute = !audioManager.MusicSource.mute;
        musicToggleBt.GetComponent<Image>().sprite = !audioManager.MusicSource.mute ? Resources.Load<Sprite>("image/music") : Resources.Load<Sprite>("image/music-mute");
        Debug.Log("Music is " + audioManager.MusicSource.mute);

    }


    public void ToggleSFX()
    {
        isSFXoff = !isSFXoff;
        Debug.Log("Sfx is " + isSFXoff);
        audioManager.ToggleSfx(isSFXoff);
        sfxToggleBt.GetComponent<Image>().sprite = !isSFXoff ? Resources.Load<Sprite>("image/sfx") : Resources.Load<Sprite>("image/sfx-mute");
    }
}
