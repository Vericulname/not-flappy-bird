using UnityEngine;

public abstract class Item : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            OnCollect(collision.gameObject);
            Destroy(gameObject);
        }
    }

    protected abstract void OnCollect(GameObject player);
}
