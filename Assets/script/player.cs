using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerScript : MonoBehaviour
{
    public GameObject shieldEffect;
    public GameObject laserPrefab;
    public Rigidbody2D Rigidbody;
    public float strength;
    InputAction Jumpaction;
    private gameLogic gameLogic;
    private bool isGameOver = false;

    public bool isShieldActive = false;

    public float duration = 4f;
    public bool isLaserActive = false;

    public float chargeTime = 5f;



    private int obstacleLayer;
    void Start()
    {

        obstacleLayer = LayerMask.NameToLayer("obstacle");
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();

        Jumpaction = InputSystem.actions.FindAction("Jump");
        // Debug.Log(Jumpaction.enabled);
        Jumpaction.Enable();

    }

    // Update is called once per frame
    void Update()
    {

        if (Jumpaction.triggered && !isGameOver)
        {
            //Debug.Log("jump");
            Rigidbody.AddForceY(strength, ForceMode2D.Force);
        }
        //TODO: can toi uu (dua no sang sript hoac gameobject khac)
        if (isShieldActive)
        {
            shieldEffect.SetActive(true);

            duration -= Time.deltaTime;

            gameObject.GetComponent<Collider2D>().enabled = false;

            if (duration < 0)
            {

                gameObject.GetComponent<Collider2D>().enabled = true;
                shieldEffect.SetActive(false);
                // Destroy(gameObject);
                Debug.Log("Shield Deactivated");
                isShieldActive = false;
                duration = 5f;
            }
        }

        if (isLaserActive)
        {
            chargeTime -= Time.deltaTime;
            if (chargeTime < 0)
            {
                isLaserActive = false;

                GameObject laser = Instantiate(laserPrefab, transform.position + Vector3.right * 8.5f, new Quaternion(0, 0, 0, 0));
                chargeTime = 5f;
                Destroy(laser, 0.2f);
                Debug.Log("Laser Deactivated");
            }


        }

        if (gameObject.transform.position.y <= -4.7f || gameObject.transform.position.y > 4.7f)
        {
            gameLogic.GameOver();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == obstacleLayer && isShieldActive == false)
        {
            gameLogic.GameOver();
            isGameOver = true;
        }
    }



}
