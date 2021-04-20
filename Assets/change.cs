using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Correct()
    {
        SceneManager.LoadScene("1game_O");
    }

    public void Uncorrect()
    {
        SceneManager.LoadScene("1game_X");
    }

    public void Return()
    {
        SceneManager.LoadScene("AR-BOOK");
    }

    public void Game()
    {
        SceneManager.LoadScene("1game");
    }
    public void Game_2()
    {
        SceneManager.LoadScene("2game");
    }
    public void SoundGame()
    {
        SceneManager.LoadScene("soundgame");
    }
    public void Review() {
        SceneManager.LoadScene("DrawLine");

    }
    public void reviewmenu()
    {
        SceneManager.LoadScene("review");
    }
    public void TrainGame() {
        SceneManager.LoadScene("2game");

    }

    public void Soundgame_1()
    {
        SceneManager.LoadScene("soundgame 1");

    }

    public void Soundgame_2()
    {
        SceneManager.LoadScene("soundgame 2");

    }
    public void DrawLine2()
    {
        SceneManager.LoadScene("DrawLine2");

    }

    public void AppStart()
    {
        SceneManager.LoadScene("app-start");

    }
  
}
