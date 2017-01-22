using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorovkaSpawn : MonoBehaviour {

	float resistenceSpeed = 1;
	Transform spawnPos;
	void Start () {

		Invoke ("SpawnEnemy",20f);
	}

	void SpawnEnemy(){
		
		while(!PlayerLogic.imDead){

			GameObject sonechko = Instantiate(Resources.Load("sonechko", typeof(GameObject))) as GameObject;	

			Instantiate(sonechko);
			sonechko.transform.position = gameObject.transform.position;


			Destroy (sonechko, 7f);

		}}
}