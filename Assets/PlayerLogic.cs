using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLogic : MonoBehaviour {
	public float curHP;
	public float maxHP = 100f;
	public Animator anim;
	public static bool imDead;

    public Text txt;

	public SpriteRenderer ass;
	public Sprite ass1;
	public Sprite ass2;
	public Sprite ass3;

	void Start(){
		ass.sprite = ass1;
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
			//Debug.Log ("Персонаж умер от удара об стену");
			imDead = true;
            txt.text = "wall";
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
            txt.text = "low hp";
		}
		if (curHP < 33 && ass.sprite != ass1) {
			ass.sprite = ass1;
		}
		if (curHP > 33 && ass.sprite != ass2 && curHP < 70) {
			ass.sprite = ass2;
		}
		if (curHP > 70 && ass.sprite != ass3) {
			ass.sprite = ass3;
		}
	}
}
