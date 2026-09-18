using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public gameLogic gameLogic;
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}

