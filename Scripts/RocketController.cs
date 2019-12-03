using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    
    JoyButton joyButton;
    private GameObject rocket;
    public static int rocketCount = 20;
    public  bool canFire;
    public float coolDownDuration=0.5f;
    private void Start()
    {
        joyButton = FindObjectOfType<JoyButton>();
    }
    private void Update()
    {
        if (joyButton.preesed && !canFire)
        {
            Fire();
            StartCoroutine(ReleaseFire());
            
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            StartCoroutine(ReleaseFire());
        }
    }

    private IEnumerator ReleaseFire()
    {
        yield return new WaitForSeconds(coolDownDuration);
        canFire = false;
    }
    private void Fire()
    {
        if (rocketCount > 0 )
        {
            rocket = GameObject.Find("RocketPool").GetComponent<RocketPool>().GetPoolObject();
            Vector2 rocketGeneratePosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            rocket.transform.position = rocketGeneratePosition;
            rocket.SetActive(true);
            rocketCount--;
            canFire = true;
          
        }

    }

}
