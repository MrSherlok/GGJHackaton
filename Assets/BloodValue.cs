using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodValue : MonoBehaviour {

	public float size;
	private ParticleSystem.EmissionModule partsFX;
	int a = 93;
	void Start () {

	
		partsFX = gameObject.GetComponent<ParticleSystem> ().emission;
		size = Random.Range(0.5f,2.5f);
		gameObject.transform.localScale = new Vector3 (size, size,1);

	}
	public void DestroyObject(){
		partsFX.enabled = false;
		StartCoroutine("AlphaPlus");
	}
	IEnumerator AlphaPlus(){
		for (int i = 0; a>=10; i++) {
			a -= 10;
			gameObject.GetComponentInChildren<SpriteRenderer> ().color = new Color32 (255,225,255,(byte)a);
			yield return new WaitForSeconds(0.2f);
			yield return null;
		}
		Destroy(gameObject);
	}

}
