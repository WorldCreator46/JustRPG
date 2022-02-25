using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoOptions()
    {
        SceneManager.LoadScene("OptionMenu");
    }
    public void Goplay()
    {
        SceneManager.LoadScene("Play");
    }
}
