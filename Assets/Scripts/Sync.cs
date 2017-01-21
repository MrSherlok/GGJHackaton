using UnityEngine;
using UnityEngine.UI;

public class Sync : MonoBehaviour {

    public GameObject leftW;
    public GameObject rightW;
    public Text txt;
    public static bool Stope = false;

    void Update () {
        //if ((leftW.transform.eulerAngles.z - (rightW.transform.eulerAngles.z * -1)) > 20)
        //{
        //    ttime += Time.deltaTime;
        //    if(ttime>1)
        //        Stope = true;
        //}
            
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
