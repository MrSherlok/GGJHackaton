using UnityEngine;
using UnityEngine.UI;

public class LeftWing : ParentWings
{
    public static float leftDelta = 0;
    public static float leftDeltaT = 0;
    public static float leftRot = 0;
    public Text txt;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.x <= Screen.width / 3)
            {
                touch = Input.GetTouch(0);
                initTouch = true;
            }
            else
            {
                if (Input.GetTouch(1).position.x <= Screen.width / 3)
                {
                    touch = Input.GetTouch(1);
                    initTouch = true;
                }
            }
            if (initTouch)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    startpos = touch.position;
                    prevPos = touch.position;
                    moving = true;
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    moving = false;
                    initTouch = false;
                }
                if (moving)
                {
                    //txt.text = touch.deltaPosition.ToString();
                    leftDelta = touch.deltaPosition.y;
                    leftDeltaT = touch.deltaTime;
                    leftRot = transform.eulerAngles.z;
                    txt.text = leftRot.ToString();

                    deltaZ = (prevPos.y - touch.position.y);
                    prevPos = touch.position;
                    //if (transform.eulerAngles.z+deltaZ >= 60 && transform.eulerAngles.z + deltaZ <= 160)
                    //{
                    transform.Rotate(new Vector3(0, 0, deltaZ / 2.5f));
                    //}
                }
            }
        }
        if (!initTouch)
        {
            //deltaZ = (transform.position.y-90)*-1;
            //transform.Rotate(new Vector3(0, 0, deltaZ / 3));
            Quaternion target = Quaternion.Euler(0, 0, -90);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10f);
        }
    }
}
