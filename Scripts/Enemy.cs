using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject destroyEffect;
  

    private void Awake()
    {
      
    }
    private void Start()
    {
        destroyEffect = Resources.Load("MeteorDestroy_Effect") as GameObject;
     
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="FrameCollider")
        {
            gameObject.SetActive(false);
           
        }
        if (collision.gameObject.tag=="Meteor")//üst üste gelen enemy'lerin yok edilmesi için.
        {
            gameObject.SetActive(false);
            
            
        }
        if (collision.gameObject.tag=="Rocket")
        {
            gameObject.SetActive(false);
            Instantiate(destroyEffect, transform.localPosition, Quaternion.identity);
            
            
        }
       
    }

    



    //private void OnEnable()
    //{
    //    Invoke("SetActiveFalse", 4f);

    //}

    //private void SetActiveFalse()
    //{
    //    gameObject.SetActive(false);
    //}


    //private void OnDisable()
    //{
    //    CancelInvoke();
    //}

}
