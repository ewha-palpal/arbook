using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound: MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClipKnock;
    public AudioClip audioClipApplause;

    public static Sound instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if(Sound.instance == null)
        {
            Sound.instance = this;
        }
    }

    public void PlayKnockSound()
    {
        audioSource.PlayOneShot(audioClipKnock);
    }

    public void PlayApplauseSound()
    {
        audioSource.PlayOneShot(audioClipApplause);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
