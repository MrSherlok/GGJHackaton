using UnityEngine;

public class ParentWings : MonoBehaviour
{

    protected Vector2 startpos;
    protected Vector2 prevPos;
    protected bool moving = false;
    protected bool initTouch = false;
    protected float deltaZ = 0f;
    protected Touch touch;
}
