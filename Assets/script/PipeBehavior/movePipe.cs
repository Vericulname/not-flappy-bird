using UnityEngine;

public class movePipe : MonoBehaviour
{
    public float speed = 2f;
    public float destroyX = -10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
            // Debug.Log("destroyed");
        }
    }
}
