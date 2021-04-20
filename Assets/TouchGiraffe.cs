using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchGiraffe : MonoBehaviour
{
    public GameObject buttontrain;
    Animator anim;
    //public Text myText;
    void Start()
    {
        anim = GetComponent<Animator>();
        buttontrain.SetActive(false);
        anim.SetBool("isClicked", false);

    }



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                anim.SetBool("isClicked", true);

                Debug.Log(hit.transform.gameObject);
                hit.transform.gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("wow");
                GiraffeText.showText = false;
                buttontrain.SetActive(true);
            }
        }
        
       

    }
}
