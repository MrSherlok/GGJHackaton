using UnityEngine;

public class ScrollingScript : MonoBehaviour
{	

	//public Vector2 speed = new Vector2(10, 10);
	//public Vector2 direction = new Vector2(-1, 0);
	public GameObject player;

    	
	void FixedUpdate()
	{	
		/* Movement
		Vector3 movement = new Vector3(
			speed.x * direction.x,
			speed.y * direction.y,
			0);
		
		movement *= Time.deltaTime;
		transform.Translate(movement);
		*/
		transform.position = new Vector3 (-5f,player.transform.position.y,0);
	}
}