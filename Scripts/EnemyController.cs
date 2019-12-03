using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    private float enemyGenerateMaxPosX = 2.34f;
    private float enemyGenerateMinPosX = -2.37f;
    public float fireTime = 0.3f;

    
    private void Start()
    {
        InvokeRepeating("Fire", fireTime, fireTime);
    }

    void Fire()
    {
        float randomx = Random.Range(enemyGenerateMinPosX, enemyGenerateMaxPosX);
        enemy = GameObject.Find("MeteorPool").GetComponent<Pool>().GetPoolObject();
        Vector2 enemyGenaratePosition = new Vector2(randomx, gameObject.transform.position.y);
        enemy.transform.position = enemyGenaratePosition;
        enemy.SetActive(true);
        

      
    }

  

}



