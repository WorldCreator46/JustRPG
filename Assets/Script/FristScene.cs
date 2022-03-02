using UnityEngine;
using UnityEngine.SceneManagement;

public class FristScene : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void FirstLoad()
    {
        SceneManager.LoadScene("Ready");
    }
}
