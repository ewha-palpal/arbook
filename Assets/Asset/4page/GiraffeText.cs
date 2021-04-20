using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiraffeText : MonoBehaviour
{
    Animator anim;
    public Text myText;
    public GameObject arrow;
    public static bool showText;
    void Start()
    {
        showText = false;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (showText)
        {
            myText.text = "기린을 눌러봐!";
            arrow.SetActive(true);
            anim.Play(0);

        }
        else
        {
            myText.text = "";
            arrow.SetActive(false);
        }
    }
 
}
