using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    float speed = 0.001f;
    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(LeftWing.leftDelta - RightWing.rightDelta) > 0.3f)
        {
            if (LeftWing.leftDelta > RightWing.rightDelta)
            {
                transform.Rotate(new Vector3(0, 0, -0.5f));
            }
            else
            {
                if (LeftWing.leftDelta < RightWing.rightDelta)
                {
                    transform.Rotate(new Vector3(0, 0, 0.5f));
                }
            }
        } else
        {
            speed += 0.0002f;
        }
        if(!Sync.Stope)
        gameObject.transform.Translate(Vector3.up * speed);
    }
}
