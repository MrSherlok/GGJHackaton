using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;

public class Move : MonoBehaviour {

    public Vector2 startpos;
    public Vector2 prevPos;
    public bool directionChosen = false;
    float deltaY = 0f;
    public Text txt;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startpos = touch.position;
                prevPos = touch.position;
                directionChosen = true;
                txt.text = "start";
            }
            if (touch.phase == TouchPhase.Ended)
            {
                startpos = new Vector2(0, 0);
                directionChosen = false;
                txt.text = "end";
            }
            if (directionChosen)
            {
                txt.text = "move";
                deltaY = (prevPos.y - touch.position.y) * -1f;
                prevPos = touch.position;
                //Quaternion target = Quaternion.Euler(0, 0, transform.rotation.z + deltaY);
                //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10);
                transform.Rotate(new Vector3(0, 0, deltaY / 7));
            }


        }
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    startpos = Input.mousePosition;
        //    prevPos = Input.mousePosition;
        //    directionChosen = true;
        //}
        //if (Input.GetButtonUp("Fire1"))
        //{
        //    startpos = new Vector2(0,0);
        //    directionChosen = false;
        //}
        //if (directionChosen)
        //{

        //    deltaY = (prevPos.y - Input.mousePosition.y)*-1f;
        //    prevPos = Input.mousePosition;
        //    //Quaternion target = Quaternion.Euler(0, 0, transform.rotation.z + deltaY);
        //    //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10);
        //    transform.Rotate(new Vector3(0, 0, deltaY/7));
        //}

    }
        //void FixedUpdate()
        //{
        //    if (Input.touchCount > 0) {
        //        Touch touch = Input.GetTouch(0);
        //        // Track a single touch as a direction control.
        //        //Vector2 delta = Input.GetTouch(0).deltaPosition;

            //        //vect = gameObject.transform.rotation.z + delta.y;

            //        if (touch.phase == TouchPhase.Began)
            //        {
            //            previousPos = touch.position;
            //        }
            //        float deltaY = previousPos.y - touch.position.y;
            //        //transform.Rotate( new Vector3(0,0, deltaY));
            //        Quaternion target = Quaternion.Euler(0, 0, deltaY);
            //        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 0);
            //    }
            //}
    }
