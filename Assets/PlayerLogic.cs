using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLogic : MonoBehaviour {
	public float curHP;
	public float maxHP = 100f;
	public Animator anim;public Animator animScreen;
	public static bool imDead;

    public Text txt;

	public SpriteRenderer ass;
	public Sprite ass1;
	public Sprite ass2;
	public Sprite ass3;

	//UI elements
	public Image hpBar;
	public Image hpBarHolder;
	public Image returnButton;
	public GameObject lose;
	public GameObject waves; 

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
	public void KillPlayer(int dieVariation){
		if (dieVariation == 1) {
			Debug.Log ("Персонаж умер от удара об стену");
			imDead = true;
//            txt.text = "wall";
			anim.SetTrigger("Die1");
        }

		if (dieVariation == 2) {
			imDead = true;
			Debug.Log ("Персонаж умер от бездействия");
			anim.SetTrigger("Die2");
		}
		HideScreen ();

	}

	void UpgradeLvl(float size){
		Debug.Log("HP += "+size);
		//ВОт тут надо исправить
		GameObject.Find ("HP").GetComponent<HealthScript>().HPChangeLevel(size);
	}
	void Update(){
		if (curHP <= 0 && imDead == false) {
			imDead = true;

			HideScreen();
            //txt.text = "low hp";
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
	void HideScreen(){
		lose.SetActive (true);
		hpBar.enabled = false;
		hpBarHolder.enabled = false;
		returnButton.enabled = false;
		Debug.Log ("YouDie");
		animScreen.SetTrigger("CloseDS");
		waves.SetActive(false);
	}
}
