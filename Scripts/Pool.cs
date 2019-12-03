using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    List<GameObject> meteorsInPool;
    private int pooledAmountMeteor=20;
    public GameObject enemy;

    private void Start()
    {
        meteorsInPool = new List<GameObject>();
        

        for (int i = 0; i < pooledAmountMeteor; i++)
        {
            GameObject item= Instantiate(enemy, transform.position, Quaternion.identity);
            item.SetActive(false);
            meteorsInPool.Add(item);
        }

    }

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < pooledAmountMeteor; i++)
        {
            if (!meteorsInPool[i].activeInHierarchy)
            {
                return meteorsInPool[i];
            }
        }
        return null;
    }

   

}
