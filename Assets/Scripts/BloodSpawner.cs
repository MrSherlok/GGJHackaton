using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpawner : MonoBehaviour
{
    //Transform spawnPos;
    float ttime = 0;
    //void Start()
    //{
    //StartCoroutine("SpawnBlood");
    //}

    private void Update()
    {
        ttime += Time.deltaTime;
        if (!PlayerLogic.imDead && ttime > 0.5f)
        {
            ttime = 0f;
            //Debug.Log("ISpawn");
            GameObject eda = Instantiate(Resources.Load("eda1", typeof(GameObject))) as GameObject;

            eda.transform.position = new Vector3(Random.Range(-7, 7), transform.position.y, 0);
        }
    }

    //IEnumerator SpawnBlood()
    //{
    //    while (!PlayerLogic.imDead)
    //    {
    //        //Debug.Log("ISpawn");
    //        GameObject eda = Instantiate(Resources.Load("eda", typeof(GameObject))) as GameObject;

    //        Instantiate(eda);
    //        eda.transform.position = new Vector3(Random.Range(-1, 12), transform.position.y, 0);

    //        yield return new WaitForSeconds(0.5f);
    //        //Destroy (eda, 4f);
    //        yield return null;
    //    }
    //}

}
