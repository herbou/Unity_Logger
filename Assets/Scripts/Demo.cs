using UnityEngine;

public class Demo : MonoBehaviour
{
    public void LogInfo()
    {
        Debug.Log("This is a normal log message");
    }
    
    public void LogWarning()
    {
        Debug.LogWarning("Warning message");
    }

    public void LogError()
    {
        Debug.LogError("Error: Just kidding :)");
    }

}
