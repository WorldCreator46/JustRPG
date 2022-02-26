using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using System.Collections.Generic;

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
    private void Start()
    {
        Debug.Log(JsonConvert.SerializeObject(Event.EventList).GetType());
    }
}
