using UnityEngine;
using UnityEngine.UI;

public class Sync : MonoBehaviour {

    public GameObject leftW;
    public GameObject rightW;
    float timeNoTouch = 0;
    public Text txt;
    public static bool Stope = false;

    void Update () {
        //if ((leftW.transform.eulerAngles.z - (rightW.transform.eulerAngles.z * -1)) > 20)
        //{
        //    ttime += Time.deltaTime;
        //    if(ttime>1)
        //        Stope = true;
        //}
        if (Input.touchCount == 0)
        {
            timeNoTouch += Time.deltaTime;
            if (timeNoTouch < 3f)
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
            } else
            {
                Stope = true;
            }
        } else
        {
            timeNoTouch = 0;
        }
        if (Stope)
        {
            txt.text = "End";
        }
        else
        {
            txt.text = "con";
        }
	}
}
