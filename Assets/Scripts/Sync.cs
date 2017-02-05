using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sync : MonoBehaviour {

    public GameObject leftW;
    public GameObject rightW;
    float timeNoTouch = -5f;
    public Image txt;
    public Sprite three;
    public Sprite two;
    public Sprite one;
    public Sprite none;


    void Update () {
		if (Input.touchCount <= 1) {
			//StartCoroutine("CheckTouch");
			timeNoTouch += Time.deltaTime;
			if (!PlayerLogic.imDead) {
				if (timeNoTouch < 4f) {
					if (Input.touchCount == 0) {
						if (timeNoTouch >= 1 && timeNoTouch <= 2) {
							txt.sprite = three;
						}
						if (timeNoTouch >= 2 && timeNoTouch <= 3) {
							txt.sprite = two;
						}
						if (timeNoTouch >= 3 && timeNoTouch <= 4) {
							txt.sprite = one;
						}
						if (timeNoTouch < 1) {
							txt.sprite = none;
						}
						if (gameObject.transform.rotation.eulerAngles.z != 0 || gameObject.transform.rotation.eulerAngles.z != 360) {
							//transform.Rotate(new Vector3(0, 0, -1f));

							Quaternion target = Quaternion.Euler (0, 0, 0);
							transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * 1.5f);
						}
					}
				} else {
					PlayerLogic.imDead = true;
					txt.sprite = none;
					GameObject.Find ("Komarik").GetComponent<PlayerLogic> ().KillPlayer (2);
				}
			}
		}
            else
            {
                timeNoTouch = 0f;
            }
        }
        //if (PlayerLogic.imDead)
        //{

        //    txt.text = "End";
        //}
        //else
        //{
        //    txt.text = "con";
        //}
	}

    //IEnumerator CheckTouch()
    //{

        //while (timeNoTouch < 3f)
        //{
        //    timeNoTouch++;
        //    if (Input.touchCount == 0)
        //    {
        //        if (gameObject.transform.rotation.eulerAngles.z > 3)
        //        {
        //            transform.Rotate(new Vector3(0, 0, gameObject.transform.rotation.eulerAngles.z / 3f));
        //        }
        //        else
        //        {
        //            if (gameObject.transform.rotation.eulerAngles.z < -3)
        //            {
        //                transform.Rotate(new Vector3(0, 0, gameObject.transform.rotation.eulerAngles.z / 3f * -1f));
        //            }
        //            else transform.Rotate(new Vector3(0, 0, gameObject.transform.rotation.eulerAngles.z * -1));
        //        }
        //        yield return new WaitForSeconds(1f);
        //        yield return null;
        //    }
        //}
        //    PlayerLogic.imDead = true;
        //    timeNoTouch = 0;
            
    //}
