using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpawner : MonoBehaviour
{
    Transform spawnPos;
    void Start()
    {
        StartCoroutine("SpawnBlood");
    }

    IEnumerator SpawnBlood()
    {
        while (!PlayerLogic.imDead)
        {
            //Debug.Log("ISpawn");
            GameObject eda = Instantiate(Resources.Load("eda", typeof(GameObject))) as GameObject;

            Instantiate(eda);
            eda.transform.position = new Vector3(Random.Range(-1, 12), transform.position.y, 0);

            yield return new WaitForSeconds(0.5f);
            //Destroy (eda, 4f);
            yield return null;
        }
    }

}
