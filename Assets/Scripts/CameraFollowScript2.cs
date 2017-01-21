using UnityEngine;
using System.Collections;

public class CameraFollowScript2 : MonoBehaviour {
	private Vector2 velocity;

	public float camLevelChangeSmooth;


	GameObject player;

	void Start () {
		player =  GameObject.Find("Komarik");
	}
	void FixedUpdate () {
        gameObject.transform.position = Vector3.Lerp(new Vector3(player.transform.position.x, transform.position.y, transform.position.z), new Vector3(0f, player.transform.position.y+4f, transform.position.z), camLevelChangeSmooth);
	}
}
