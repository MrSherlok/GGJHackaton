using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{

    public void Reload()
    {
        Sync.Stope = false;
        SceneManager.LoadScene(0);
    }
}
