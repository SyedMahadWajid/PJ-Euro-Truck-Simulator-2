using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSystem : MonoBehaviour
{
    float volumessss;
    public Slider Music,Sound;
    public AudioSource MusicClip,SoundClip;
    int S;
    
    void Start()
    {
        if(PlayerPrefs.GetFloat("Music00")==1){
            Music.value = PlayerPrefs.GetFloat("Music");
        }
        if(PlayerPrefs.GetFloat("Sound00")==1){
            Sound.value = PlayerPrefs.GetFloat("Sound");
        }
    }

    void Update(){
        if(S==1){
            volumessss = Music.value;
            PlayerPrefs.SetFloat("Music",volumessss);
            PlayerPrefs.SetFloat("Music00",1);
            MusicClip.volume = volumessss;
        }
        if(S==2){
            volumessss = Sound.value;
            PlayerPrefs.SetFloat("Sound",volumessss);
            PlayerPrefs.SetFloat("Sound00",1);
            SoundClip.volume = volumessss;
        }
        
	}


    public void Button(int i){
       S=i;
    }
}
