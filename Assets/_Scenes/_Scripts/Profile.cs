using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    public Text Nametext,Nameholder,Menunameholder,Jobnameholder;
    public GameObject ProfilePanel,editprofilepnl,mainpnl,fillpnl;
    public Image ProfileImage,MenuProfileImage,JobProfileImage;
    string PlayerName;
    int GenderStatus,ProfileIndex;
    public GameObject[] CheckMarkGender;
    public Sprite[] Picture;

    void Start()
    {
        Menunameholder.text = PlayerPrefs.GetString("PlayerName");
        Jobnameholder.text = PlayerPrefs.GetString("PlayerName");
        Nameholder.text = PlayerPrefs.GetString("PlayerName");
        if(PlayerPrefs.GetInt("Gender") == 1){
            CheckMarkGender[0].SetActive(true);
            CheckMarkGender[1].SetActive(false);

        }else if(PlayerPrefs.GetInt("Gender") == 2){
            CheckMarkGender[0].SetActive(false);
            CheckMarkGender[1].SetActive(true);

        }
        if(PlayerPrefs.GetInt("Setit")==1){
            ProfileImage.GetComponent<Image>().sprite = Picture[PlayerPrefs.GetInt("Profile")];
            MenuProfileImage.GetComponent<Image>().sprite = Picture[PlayerPrefs.GetInt("Profile")];
            JobProfileImage.GetComponent<Image>().sprite = Picture[PlayerPrefs.GetInt("Profile")];
        }
        ProfileIndex = PlayerPrefs.GetInt("Profile");
        GenderStatus = PlayerPrefs.GetInt("Gender");
        
    }
    public void Gender(int G){
        GenderStatus = G;
    }


    public void save(){
        if(Nametext.text!= null && CheckMarkGender[0].activeInHierarchy || CheckMarkGender[1].activeInHierarchy && ProfileImage.GetComponent<Image>().sprite == Picture[ProfileIndex]){
            print("666");
             if(Nametext.text == ""){
            PlayerName = Nameholder.text;
        }
        else{
            PlayerName = Nametext.text;
        }
            PlayerPrefs.SetString("PlayerName" ,PlayerName);
            PlayerPrefs.SetInt("Gender",GenderStatus);
            PlayerPrefs.SetInt("Profile",ProfileIndex);
            PlayerPrefs.SetInt("Setit",1);
            MenuProfileImage.GetComponent<Image>().sprite = Picture[PlayerPrefs.GetInt("Profile")];
            JobProfileImage.GetComponent<Image>().sprite = Picture[PlayerPrefs.GetInt("Profile")];
            Menunameholder.text = PlayerPrefs.GetString("PlayerName");
            Jobnameholder.text = PlayerPrefs.GetString("PlayerName");
            editprofilepnl.SetActive(false);
            mainpnl.SetActive(true);
        }
        else{
            print("jjj");
            fillpnl.SetActive(true);
        }
        
    }
    public void EditProfile(){
        ProfilePanel.SetActive(true);
        
    }
    public void ok(){
        fillpnl.SetActive(false);
        editprofilepnl.SetActive(true);
        
    }
    public void SelectProfile(int pro){
        ProfileIndex = pro;
        ProfileImage.GetComponent<Image>().sprite = Picture[ProfileIndex];
        ProfilePanel.SetActive(false);
    }
}
