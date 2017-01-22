using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	float resistenceSpeed = 1;
	Transform spawnPos;
	void Start () {
		
		StartCoroutine("SpawnEnemy");
	}
	void FixedUpdate(){
		transform.Translate(Vector2.up * resistenceSpeed * Time.deltaTime);
	}
	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds(5f);
		while(!PlayerLogic.imDead){
			
			GameObject pregrada = Instantiate(Resources.Load("pregrada", typeof(GameObject))) as GameObject;	

			Instantiate(pregrada);
			pregrada.transform.position = new Vector3(Random.Range(-8,9),transform.position.y+5,0);

			yield return new WaitForSeconds(3f);
			Destroy (pregrada, 4f);
			yield return null;
		}}
}
