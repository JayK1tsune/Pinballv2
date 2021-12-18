using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawner : MonoBehaviour
{
    public GameObject Pinball;
    public float timeToSpawn;
    private float currentTimeToSpawn;

    private void Start()
    {
    
    }
    private void Update()
    {
        if(currentTimeToSpawn > 0) //&& GameObject.FindGameObjectsWithTag("Pinball").Length < 5) //checking to see how many pinballs are on the map. *Started mass spawning
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }
    public void SpawnObject()
    {
        Instantiate(Pinball, transform.position, transform.rotation);
    }

}

//first attempted at doing the spawner 
//public GameObject PinballPrefab;
//public float respawnTimer = 5.0f;


//private void spawnBall()
//{
//    GameObject a = Instantiate(PinballPrefab) as GameObject;

//}
//IEnumerable pinballs()
//{
//    while (true)
//    {
//        yield return new WaitForSeconds(respawnTimer);
//        spawnBall();
//    }
//}