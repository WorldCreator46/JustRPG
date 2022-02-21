using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReady : MonoBehaviour
{
    void Start()
    {
        GoTitle();
    }
    void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
