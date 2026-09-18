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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Jumpaction = InputSystem.actions.FindAction("Jump");
        Debug.Log(Jumpaction.enabled);
        Jumpaction.Enable();

    }

    // Update is called once per frame
    void Update()
    {

        if (Jumpaction.triggered)
        {
            //Debug.Log("jump");
            Rigidbody.AddForceY(strength, ForceMode2D.Force);
        }
    }
    
    

}
