using System.Collections;
using UnityEngine;

public class BloodValue : MonoBehaviour {

	public float size;
	//private ParticleSystem.EmissionModule partsFX;

	void Start () {	
		//partsFX = gameObject.GetComponent<ParticleSystem> ().emission;
		size = Random.Range(0.5f,2.5f);
		gameObject.transform.localScale = new Vector3 (size, size,1);
        StartCoroutine("AlphaPlus");
    }

	public void DestroyObject(){
        //partsFX.enabled = false;
        Destroy(gameObject);
	}

	IEnumerator AlphaPlus(){  
			yield return new WaitForSeconds(3f);	
            DestroyObject();
	}
}
