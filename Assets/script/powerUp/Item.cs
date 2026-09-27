using UnityEngine;

public abstract class Item : MonoBehaviour
{
    private AudioManager audioManager;

    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioManager.PlayPowerUpSfx();
            OnCollect(collision.gameObject);
            Destroy(gameObject);
        }
    }

    protected abstract void OnCollect(GameObject player);
}
