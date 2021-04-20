using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_start : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }

    public void gobook()
    {

        StartCoroutine("Delay_btn1");
        

    }

    public void goreviewgame()
    {
        StartCoroutine("Delay_btn2");
    }

    IEnumerator Delay_btn1()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("AR-BOOK");
    }

    IEnumerator Delay_btn2()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("review");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
