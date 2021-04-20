using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game2Order : MonoBehaviour
{

    public static List<string> buttonPressed = new List<string>();
    void Start()
    {
        buttonPressed = new List<string>() {"1","2","3","4" };
        Debug.Log("add list");
    }
    public static string getNext() {
        return buttonPressed[0];
    }
    public static void removeFirst() {
        buttonPressed.RemoveAt(0);
    }
    //public static void reset() {
    //    buttonPressed.Add("1");
    //    buttonPressed.Add("2");
    //    buttonPressed.Add("3");
    //    buttonPressed.Add("4");        
    //}
    public static int count() {
        return buttonPressed.Count; 
    }

}
