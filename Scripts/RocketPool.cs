using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPool : MonoBehaviour
{
    List<GameObject> rocketsInPool;
    private int pooledAmountRocket = 20;
    public GameObject rocket;

    private void Start()
    {
        rocketsInPool = new List<GameObject>();


        for (int i = 0; i < pooledAmountRocket; i++)
        {
            
            GameObject item = Instantiate(rocket,transform.position, Quaternion.identity);
            item.SetActive(false);
            rocketsInPool.Add(item);
        }

    }

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < pooledAmountRocket; i++)
        {
            if (!rocketsInPool[i].activeInHierarchy)
            {
                return rocketsInPool[i];
            }
        }
        return null;
    }
}
