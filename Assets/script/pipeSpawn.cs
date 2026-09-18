using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    public float heightOffset = 10f;
    private float timer = 0f;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            timer = 0f;
            spawnPipe();
        }
        timer += Time.deltaTime;
    }
    void spawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        float y = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, y, transform.position.z), transform.rotation);
    }
}
