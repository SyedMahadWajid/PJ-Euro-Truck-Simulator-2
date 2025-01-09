using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Posiions : MonoBehaviour
{
  public GameObject[] levels,control;
  public static bool fail,complete;
  public Camera myCamera;
  
 
    void Start()
    {
      Time.timeScale =1f;
      fail=false;
      complete=false;
      levels[MenuScene.LevelNo].SetActive(true);
    if(MenuScene.camfar==0){
      myCamera.farClipPlane = 200f;
    }
    if(MenuScene.camfar==1){
      myCamera.farClipPlane = 300f;
    }
    if(MenuScene.camfar==2){
      myCamera.farClipPlane = 400f;
    }
    if(MenuScene.controlNumber==0){
      control[0].SetActive(true);
      control[1].SetActive(false);
    }
     if(MenuScene.controlNumber==1){
      control[1].SetActive(true);
      control[0].SetActive(false);
    }  
  }
 
}
