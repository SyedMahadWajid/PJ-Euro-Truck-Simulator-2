using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSystemSet : MonoBehaviour
{
    public AudioSource MusicClip,SoundClip;
    public bool Gameplay;
    public AudioSource[] SoundClipS;
    
    void Start()
    {
        if(Gameplay){
            if(PlayerPrefs.GetFloat("Music00")==1){
            SoundClipS[0].volume = PlayerPrefs.GetFloat("Music");
            SoundClipS[1].volume = PlayerPrefs.GetFloat("Music");
            SoundClipS[2].volume = PlayerPrefs.GetFloat("Music");
            //SoundClipS[3].volume = PlayerPrefs.GetFloat("Music");
            }
        }
        if(PlayerPrefs.GetFloat("Music00")==1){
            MusicClip.volume = PlayerPrefs.GetFloat("Music");
        }
        if(PlayerPrefs.GetFloat("Sound00")==1){
            SoundClip.volume = PlayerPrefs.GetFloat("Sound");
        }
    }
  
}
