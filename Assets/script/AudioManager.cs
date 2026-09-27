using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioSource JumpSfx;
    public AudioSource LaserSfx;
    public AudioSource PowerUpSfx;
    public AudioSource scoreSfx;
    public AudioSource GameOverSfx;




    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(gameObject.tag);
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void ToggleSfx(bool togglesfx)
    {
        JumpSfx.mute = togglesfx;
        LaserSfx.mute = togglesfx;
        PowerUpSfx.mute = togglesfx;
        scoreSfx.mute = togglesfx;
        GameOverSfx.mute = togglesfx;
    }

    public void PlayJumpSfx()
    {
        JumpSfx.Play();
    }

    public void PlayLaserSfx()
    {
        LaserSfx.Play();
    }

    public void PlayPowerUpSfx()
    {
        PowerUpSfx.Play();

    }
    public void PlayScoreSfx()
    {
        scoreSfx.Play();
    }
    public void PlayGameOverSfx()
    {
        GameOverSfx.Play();

    }
}

