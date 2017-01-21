using UnityEngine;

public class Moving : MonoBehaviour
{
   public float speed = 10f;
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
            if (speed < 20f)
                speed += Time.deltaTime;
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
            else transform.Rotate(new Vector3(0, 0, -0.7f));
        }

        if (LeftWing.leftRot - RightWing.rightRot < 30 && RightWing.rightRot < 10 && RightWing.rightRot > -10)
            if (speed < 20f)
            {
                speed += Time.deltaTime;
            }
        else
            {
                if(LeftWing.leftRot - RightWing.rightRot < 30 && RightWing.rightRot < 190 && RightWing.rightRot > 170)
                    if (speed > 7f)
                        speed -= Time.deltaTime;
            }
        if (LeftWing.leftDeltaT > 0.3 || RightWing.rightDeltaT > 0.3)
        {
            if (speed < 20f)
                speed += Time.deltaTime/10;
        }
        if ((LeftWing.leftRot - RightWing.rightRot < 160 && LeftWing.leftRot - RightWing.rightRot > 200))
            if (speed > 7f)
                speed -= Time.deltaTime;
        if (!Sync.Stope)
            gameObject.transform.Translate(Vector3.up * speed*Time.deltaTime);
    }
}
