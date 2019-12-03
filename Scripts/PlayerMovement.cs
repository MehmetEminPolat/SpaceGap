using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //float horizontal;
    //float vertical;
    //public float forceMagnitude = 0.1f;

    Joystick joyStick;


    private void Start()
    {
        joyStick = FindObjectOfType<Joystick>();


    }
    void Update()
    {

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(joyStick.Horizontal * 2f,0f);



        //horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");

        //transform.position += transform.up * vertical * forceMagnitude;
        //transform.position += transform.right * horizontal * forceMagnitude;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            GameObject userInterface = GameObject.FindGameObjectWithTag("UserInterface");
            userInterface.GetComponent<UIManager>().OpenGameOverMenu();

        }

    }


}
