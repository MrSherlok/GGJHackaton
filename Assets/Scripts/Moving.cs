using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
   public static float speed = 8f;
    public Text txt;
    // Update is called once per frame
    void FixedUpdate()
    {

        if (Mathf.Abs(LeftWing.leftDelta) - Mathf.Abs(RightWing.rightDelta) > 0.3f)
        {
            if (LeftWing.leftDelta > RightWing.rightDelta && (LeftWing.leftDeltaT < 0.3 || RightWing.rightDeltaT < 0.3))
            {
                transform.Rotate(new Vector3(0, 0, -0.7f));
            }
            if (LeftWing.leftDelta < RightWing.rightDelta && (LeftWing.leftDeltaT < 0.3 || RightWing.rightDeltaT < 0.3))
            {
                transform.Rotate(new Vector3(0, 0, 0.7f));
            }
        }
        else
        {
            //if (speed < (8 * 2f))
            //{
            //    Debug.Log("low delta t+");
            //    speed += Time.deltaTime;
            //}
        }
        //if ((LeftWing.leftRot - 160 - RightWing.rightRot > 15) && (LeftWing.leftDeltaT < 0.3 || RightWing.rightDeltaT < 0.3))
        //{
        //    transform.Rotate(new Vector3(0, 0, -0.7f));
        //}
        //if (LeftWing.leftRot - 160 - RightWing.rightRot < -15 && (LeftWing.leftDeltaT < 0.3 || RightWing.rightDeltaT < 0.3))
        //{
        //    transform.Rotate(new Vector3(0, 0, 0.7f));
        //}


        if ((LeftWing.leftRot - RightWing.rightRot > 160 && LeftWing.leftRot - RightWing.rightRot < 200))
        {
            if(RightWing.rightRot > 90)
            transform.Rotate(new Vector3(0, 0, 0.7f));
            else
                transform.Rotate(new Vector3(0, 0, -0.7f));
        }

        if ((RightWing.rightRot + LeftWing.leftRot < 30f || RightWing.rightRot + LeftWing.leftRot > 340f) && RightWing.rightRot < 20f && RightWing.rightRot > -20f)
            if (speed < (8 * 2f))
            {
                Debug.Log("wing 0 t+");
                speed += Time.deltaTime*2f;
            }
        if ((LeftWing.leftRot + RightWing.rightRot < 30f || (LeftWing.leftRot + RightWing.rightRot > 330f)) && RightWing.rightRot < 200f && RightWing.rightRot > 160f)
            if (speed > (8 * 0.8f))
            {
                Debug.Log("wing 180 t-");
                speed -= Time.deltaTime*2f;
            }
        if (LeftWing.leftDeltaT > 0.3 || RightWing.rightDeltaT > 0.3)
        {
            if (speed < (8 * 2f))
            {
                Debug.Log("no move more 0.3s t+");
                speed += Time.deltaTime;
            }
        }
        if ((LeftWing.leftRot - RightWing.rightRot < 160 && LeftWing.leftRot - RightWing.rightRot > 200))
            if (speed > (8 * 0.8f))
            {
                Debug.Log("Rot more/less 180 t-");
                speed -= Time.deltaTime;
            }
        txt.text = ((int)speed).ToString();
        if (!PlayerLogic.imDead)
            gameObject.transform.Translate(Vector3.up * speed*Time.deltaTime);
    }
}
