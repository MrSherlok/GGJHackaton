using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sync : MonoBehaviour {

    public GameObject leftW;
    public GameObject rightW;
    float timeNoTouch = 0;
    public Text txt;

    void Update () {
        if(Input.touchCount <= 1)
        {
            //StartCoroutine("CheckTouch");
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
                    //txt.text = "touch 0";
                }
            }
            else
            {
                timeNoTouch = 0f;
            }
            txt.text = timeNoTouch.ToString();
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
