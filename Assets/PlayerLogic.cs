using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour {
	public float curHP;
	public float maxHP = 100f;
	public Animator anim;
	public static bool imDead;
	void Start(){
		imDead = false;
		curHP = 25f;
		anim.SetTrigger("GameStart");
	}
	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.tag == "LevelObject") {
			KillPlayer(1);
		}
		if (col.gameObject.tag == "Food") {			
			UpgradeLvl(col.gameObject.GetComponent<BloodValue>().size);
			col.gameObject.GetComponent<BloodValue>().DestroyObject ();
		}
	}
	void KillPlayer(int dieVariation){
		if (dieVariation == 1) {
			Debug.Log ("Персонаж умер от удара об стену");
			imDead = true;
		}
	}

	void UpgradeLvl(float size){
		Debug.Log("HP += "+size);
		//ВОт тут надо исправить
		GameObject.Find ("HP").GetComponent<HealthScript>().HPChangeLevel(size);
	}
	void Update(){
		if (curHP <= 0 && imDead == false) {
			imDead = true;
			Debug.Log("YouDead");
		}
	}
}
