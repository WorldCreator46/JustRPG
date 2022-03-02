using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Event : MonoBehaviour
{
    public static Dictionary<string, object> EventList = new Dictionary<string, object>()
    {
        {"Tutorial", false}
    };
    public static string GetEvent()
    {
        return JsonConvert.SerializeObject(Event.EventList);
    }
    public static void SetEvent(string json)
    {
        EventList = JsonConvert.DeserializeObject<Dictionary<string,object>>(json);
    }
}
