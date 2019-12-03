using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    private Rigidbody2D backGroundBody;
    private BoxCollider2D backGroundCollider;
    private float groundVerticalLength;
    public  float scrollSpeed=-1.5f;
   

  
    void Start()
    {
        
        backGroundBody = GetComponent<Rigidbody2D>();
        backGroundBody.velocity = new Vector2(0f, scrollSpeed * 2f);

        backGroundBody = GetComponent<Rigidbody2D>();
        backGroundBody.velocity = new Vector2(0f, scrollSpeed);


        backGroundCollider = GetComponent<BoxCollider2D>();
        groundVerticalLength = backGroundCollider.size.y;

    }

    private void Update()
    {
        if (transform.position.y < -groundVerticalLength)
        {
            RePositionBackGround();
        }

    }

    private void RePositionBackGround()
    {
        Vector3 groundNewPosition = new Vector3(0, groundVerticalLength * 2f,0);
        transform.position = transform.position + groundNewPosition;
    }


}
