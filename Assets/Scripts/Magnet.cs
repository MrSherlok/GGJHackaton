using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour {
    GameObject obj;
    public GameObject player;
    bool trans = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col != null)
        {
           
            if(col.gameObject.tag == "Food")
            {
                obj = col.gameObject;
                trans = true;
            }
        }
    }
    void Update()
    {
        if (trans)
        {
            if (obj != null)
            {
                obj.transform.position = Vector2.MoveTowards(obj.transform.position, new Vector2(player.transform.position.x, obj.transform.position.y), 0.2f);

                if (obj.transform.position.x == transform.position.x)
                {
                    trans = false;
                }
            }
            else
                trans = false;
        }
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y+1.5f, player.transform.position.z);
    }
    }
