using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFor : MonoBehaviour {

	public float smoothTransformation;
	public GameObject father;
	void Update () {
		transform.position = Vector2.Lerp(transform.position,father.transform.position,smoothTransformation);
	}
}
