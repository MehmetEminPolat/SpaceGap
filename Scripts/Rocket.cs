using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag=="UpCollider")
        {
            gameObject.SetActive(false);
            
        }
        if (collision.gameObject.tag=="Meteor")
        {
            gameObject.SetActive(false);
           


        }
    }
}
