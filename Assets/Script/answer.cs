using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class answer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goanswer()
    {
        SceneManager.LoadScene("soundgame1_O");
    }

    public void goanswer2()
    {
        SceneManager.LoadScene("soundgame2_O");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
