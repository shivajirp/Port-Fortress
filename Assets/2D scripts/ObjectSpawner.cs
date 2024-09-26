using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Rock;

    public void SpwanRock()
    {
        int spawnPointX = Random.Range(-400, 400);
        
        Vector2 spwanPosition = new Vector2(spawnPointX, 0);

        Instantiate(Rock, spwanPosition, Quaternion.identity);
    }

}
