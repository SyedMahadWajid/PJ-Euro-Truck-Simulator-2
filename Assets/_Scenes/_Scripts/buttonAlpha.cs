using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonAlpha : MonoBehaviour
{
    float alpha;
    public Slider volume;
    public GameObject[] buttons;
    public int j;

    void Start(){
        // if(PlayerPrefs.GetFloat("Choice")==0){
        //     if(PlayerPrefs.GetFloat("t00")==1 && j==0){
        //         volume.value = PlayerPrefs.GetFloat("t0",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t11")==1&& j==1){
        //         volume.value = PlayerPrefs.GetFloat("t1",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t22")==1&& j==2){
        //         volume.value = PlayerPrefs.GetFloat("t2",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t33")==1&& j==3){
        //         volume.value = PlayerPrefs.GetFloat("t3",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t44")==1&& j==4){
        //         volume.value = PlayerPrefs.GetFloat("t4",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t55")==1&& j==5){
        //         volume.value = PlayerPrefs.GetFloat("t5",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t66")==1&& j==6){
        //         volume.value = PlayerPrefs.GetFloat("t6",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t77")==1&& j==7){
        //         volume.value = PlayerPrefs.GetFloat("t7",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t88")==1&& j==8){
        //         volume.value = PlayerPrefs.GetFloat("t8",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        //     if(PlayerPrefs.GetFloat("t99")==1&& j==9){
        //         volume.value = PlayerPrefs.GetFloat("t9",alpha);
        //         btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, volume.value);
        //     }
        // }
        // else{
        //     btn.gameObject.transform.GetComponent<Image>().color = new Color (1f,1f,1f, 1f);
        //     print("NothingAlpha");
        // }
        
    }
    void Update()
    {
        //if(PlayerPrefs.GetFloat("Choice")==0){
        //if(j==0){
            alpha = volume.value;
            foreach(GameObject btn in buttons){
                btn.transform.GetComponent<Image>().color = new Color (.4f,.4f,.4f,alpha);
            }
            //btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
            //PlayerPrefs.SetFloat("t0",alpha);
            //PlayerPrefs.SetFloat("t00",1);
        //}
    //     if(j==1){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t1",alpha);
    //         PlayerPrefs.SetFloat("t11",1);
    //     }
    //     if(j==2){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t2",alpha);
    //         PlayerPrefs.SetFloat("t22",1);
    //     }
    //     if(j==3){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t3",alpha);
    //         PlayerPrefs.SetFloat("t33",1);
    //     }
    //     if(j==4){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t4",alpha);
    //         PlayerPrefs.SetFloat("t44",1);
    //     }
    //     if(j==5){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t5",alpha);
    //         PlayerPrefs.SetFloat("t55",1);
    //     }
    //     if(j==6){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t6",alpha);
    //         PlayerPrefs.SetFloat("t66",1);
    //     }
    //     if(j==7){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t7",alpha);
    //         PlayerPrefs.SetFloat("t77",1);
    //     }
    //     if(j==8){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t8",alpha);
    //         PlayerPrefs.SetFloat("t88",1);
    //     }
    //     if(j==9){
    //         alpha = volume.value;
    //         btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
    //         PlayerPrefs.SetFloat("t9",alpha);
    //         PlayerPrefs.SetFloat("t99",1);
    //     }
    //     }
     }
}
