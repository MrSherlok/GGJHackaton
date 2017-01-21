using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{

    public void Reload()
    {
        Sync.Stope = false;
        LeftWing.leftDelta = 0;
        LeftWing.leftDeltaT = 0;
        LeftWing.leftRot = 240;
        RightWing.rightDelta = 0;
        RightWing.rightDeltaT = 0;
        RightWing.rightRot = 90;
        SceneManager.LoadScene(0);
    }
}
