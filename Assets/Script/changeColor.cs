using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class changeColor : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    public Text myText;
    public Text myText2;
    public AudioClip answerCorrectAudio;
    public AudioClip answerWrongAudio;

    bool mouseDown = false;

    void Start()
    {
        myText2.text = "";
    }

    public void OnMouseDown()
    {
        mouseDown = true;
        string Name = this.gameObject.name;

        //클릭한 버튼이 정답일 때
        if (Name == DLOrder.getNext())
        {
            Debug.Log("removed");
            SoundManager.instance.AudioPlay("correct", answerCorrectAudio);

            DLOrder.removeFirst();
            if (Name == "1") myText.text = "잘했어!";
            if (Name == "2") myText.text = "맞아!";
            if (Name == "3") myText.text = "좋아!";
            if (Name == "4") myText.text = "잘했어!!";
            if (Name == "5") myText.text = "잘하고있어!!";
            if (Name == "6") myText.text = "맞았어!!";
            if (Name == "7") myText.text = "좋아!!";
            if (Name == "8") myText.text = "완벽해!!!";
            if (Name == "9") myText.text = "잘했어!!!";
            if (Name == "10") myText.text = "맞아!!!!";

        }
        //클릭한 버튼이 틀렸을 때
        else
        {
            Debug.Log("wrong");
            SoundManager.instance.AudioPlay("wrong", answerWrongAudio);
            myText.text = "";
            myText2.text = "다시해볼까?";
            StartCoroutine(WaitForSceneLoad());
        }

        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);

    }

    void OnMouseUp()
    {
        mouseDown = false;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
