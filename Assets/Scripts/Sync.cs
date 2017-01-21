using UnityEngine;
using UnityEngine.UI;

public class Sync : MonoBehaviour {

    public GameObject leftW;
    public GameObject rightW;
    float timeNoTouch = 0;
    public Text txt;

    void Update () {
        if (Input.touchCount <= 1)
        {
            timeNoTouch += Time.deltaTime;
            if (timeNoTouch < 3f)
            {
                if (Input.touchCount == 0)
                {
                    if (gameObject.transform.rotation.eulerAngles.z > 3)
                    {
                        transform.Rotate(new Vector3(0, 0, 0.25f));
                    }
                    else
                    {
                        if (gameObject.transform.rotation.eulerAngles.z < -3)
                        {
                            transform.Rotate(new Vector3(0, 0, -0.25f));
                        }
                        else transform.Rotate(new Vector3(0, 0, gameObject.transform.rotation.eulerAngles.z * -1));
                    }
                }
            }
            else
            {
                PlayerLogic.imDead = true;
            }
        }
        else
        {
            timeNoTouch = 0;
        }
        Debug.Log(timeNoTouch);
        if (PlayerLogic.imDead)
        {
            txt.text = "End";
        }
        else
        {
            txt.text = "con";
        }
	}
}
