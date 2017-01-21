using UnityEngine;
using UnityEngine.UI;

public class RightWing : ParentWings
{
    public static float rightDelta = 0;
    public Text txt;
    float tim=0;
    float tt=0;
    void Update()
    { 
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.x >= (Screen.width - (Screen.width / 3)))
            {
                touch = Input.GetTouch(0);
                initTouch = true;
            }
            else
            {
                if (Input.GetTouch(1).position.x >= (Screen.width - (Screen.width / 3)))
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
                    if (Mathf.Abs(touch.deltaPosition.y) < 0.3f)
                    {
                        tim += Time.deltaTime;
                        if (tim > 1)
                        {
                            Sync.Stope = true;
                        }
                        else
                        {
                            Sync.Stope = false;
                        }
                    }
                    else
                    {
                        tim = 0;
                    }
                    rightDelta = touch.deltaPosition.y;
                    deltaZ = (prevPos.y - touch.position.y) * -1f;
                        prevPos = touch.position;
                    //if (transform.eulerAngles.z + deltaZ >= 220 && transform.eulerAngles.z + deltaZ <= 325)
                    //{
                        transform.Rotate(new Vector3(0, 0, deltaZ / 2.5f));
                    //}
                    
                }
            }
        }
        if (!initTouch)
        {
            //deltaZ = (transform.position.y + 90) * -1;
            //transform.Rotate(new Vector3(0, 0, deltaZ / 3));
            Quaternion target = Quaternion.Euler(0, 0, -90);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10f);
        }
    }
}
