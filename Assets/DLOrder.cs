using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLOrder : MonoBehaviour
{

    public static List<string> buttonPressed = new List<string>();
    void Start()
    {
        buttonPressed = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        Debug.Log("add list");
    }
    public static string getNext()
    {
        return buttonPressed[0];
    }
    public static void removeFirst()
    {
        buttonPressed.RemoveAt(0);
    }
    public static int count()
    {
        return buttonPressed.Count;
    }

}
