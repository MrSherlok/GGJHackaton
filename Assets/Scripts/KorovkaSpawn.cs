using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorovkaSpawn : MonoBehaviour
{

    float resistenceSpeed = 1;
    public GameObject point;
    public GameObject player;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", Random.Range(12f,20f), Random.Range(3f,10f));
    }

    void SpawnEnemy()
    {

        if (!PlayerLogic.imDead)
        {
            point.transform.position = new Vector3(player.transform.position.x, point.transform.position.y, point.transform.position.z);
            gameObject.GetComponent<Animator>().SetTrigger("Attack");

            //GameObject sonechko = Instantiate(Resources.Load("sonechko", typeof(GameObject))) as GameObject;	

            //sonechko.transform.position = gameObject.transform.position;


            //Destroy (sonechko, 7f);

        }
    }
}