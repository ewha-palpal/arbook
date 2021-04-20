using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soundgame_goback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goback()
    {
        SceneManager.LoadScene("soundgame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
