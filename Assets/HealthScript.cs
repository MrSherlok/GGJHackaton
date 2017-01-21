using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {
	private Image hpBar;
	public GameObject player;

	float hpAmount;
	void Start () {
		hpBar = gameObject.GetComponent<Image>();
		StartCoroutine("HpHungry");
	}
	IEnumerator HpHungry(){
		while (hpBar.fillAmount > 0) {
			
			yield return new WaitForSeconds(0.25f);
			player.GetComponent<PlayerLogic> ().curHP -= 0.2f;
			hpBar.fillAmount = player.GetComponent<PlayerLogic> ().curHP / 100;
			yield return null;
		}
	}
	public void HPChangeLevel(float HPAmount){
		hpAmount =  HPAmount;
		StartCoroutine("HPChange");
	}
	public IEnumerator HPChange(){
		Debug.Log("+++++hp");
		for (int i = 0; i < hpAmount; i++) {
			yield return new WaitForSeconds (0.1f);
			player.GetComponent<PlayerLogic> ().curHP++ ;
			hpBar.fillAmount = player.GetComponent<PlayerLogic> ().curHP / 100;
			yield return null;
		}
	}
}
