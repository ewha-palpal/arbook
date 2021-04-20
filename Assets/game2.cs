using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game2 : MonoBehaviour
{
    public Text myText;
    public AudioClip answerCorrectAudio;
    public AudioClip answerWrongAudio;
    void Start()
    {
        myText.text = "";
    }
    public void CheckButtons()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        //클릭한 버튼이 정답일 때
        if (ButtonName == game2Order.getNext())
        {
            Debug.Log("removed");
            SoundManager.instance.AudioPlay("correct", answerCorrectAudio);

            game2Order.removeFirst();
            if (ButtonName == "1") myText.text = "ㄱ";
            if (ButtonName == "2") myText.text = "ㄱ ㅣ";
            if (ButtonName == "3") myText.text = "ㄱ ㅣ  ㅊ";
            if (ButtonName == "4") { 
                myText.text = "ㄱ ㅣ  ㅊ ㅏ";

            }
            
        }
        //클릭한 버튼이 틀렸을 때
        else
        {
            Debug.Log("wrong");
            SoundManager.instance.AudioPlay("wrong", answerWrongAudio);
        }
        if (game2Order.count() == 0) {
          //  game2Order.reset();
            Debug.Log("finish!!");
            StartCoroutine(WaitForSceneLoad());
        }
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
     SceneManager.LoadScene("2game_O");

    }
   
}
