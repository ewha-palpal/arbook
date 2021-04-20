using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using UnityEngine.UI;
//using System;
//using System.Windows.Forms;
public class customTrackingHandler : DefaultTrackableEventHandler
{
    public AudioSource audioSource;
    public Animator bearAni;
    public Animator giraffeAni;

    protected override  void OnTrackingFound()
    {
        base.OnTrackingFound();
        audioSource.Play();
        bearAni.Play(0);
        giraffeAni.Play(0);

        Invoke("changeShowText", audioSource.clip.length);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        audioSource.Stop();

    }

    void  Update()
    {
       
    }
    void changeShowText() {
        GiraffeText.showText = true;


    }

}
