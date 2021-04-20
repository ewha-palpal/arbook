using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using UnityEngine.UI;
//using System;
//using System.Windows.Forms;
public class ButtonTrackingHandler : DefaultTrackableEventHandler
{
    public AudioSource audioSource;
    public Animator bearAnim;
    public Animator quesAnim;
    public Animator bagAnim;

    public GameObject button;
    protected override void Start() {
        base.Start();
        //button.SetActive(false);


    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        audioSource.Play();
        bearAnim.Play(0);
        quesAnim.Play(0);
        bagAnim.Play(0);
        button.SetActive(false);


    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        audioSource.Stop();

    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            button.SetActive(true);
        }
       

    }


}
