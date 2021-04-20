using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game2_text : MonoBehaviour
{
    public static Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void addText(string buttonName) {
        if (buttonName == "1") myText.text = "ㄱ";
        if (buttonName == "2") myText.text = "기";
        if (buttonName == "3") myText.text = "기ㅊ";
        if (buttonName == "4") myText.text = "기차";
    }
    
}
