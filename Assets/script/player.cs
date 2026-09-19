using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class force : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float strength;
    InputAction Jumpaction;
    private gameLogic gameLogic;
    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();

        Jumpaction = InputSystem.actions.FindAction("Jump");
        Debug.Log(Jumpaction.enabled);
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        gameLogic.GameOver();
        isGameOver = true;
    }



}
