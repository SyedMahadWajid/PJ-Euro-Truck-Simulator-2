using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeman : MonoBehaviour
{
    private Animator Police;
    public GameObject Character;
   void Start()
    {
       Police = Character.GetComponent<Animator>();
    }
    void Update()
    {
        if(PlayerScript.policemove){
            Police.SetBool("walk",true);
            transform.LookAt(GameObject.FindGameObjectWithTag("talk").transform);
        }
        if(PlayerScript.policeTalk){
            Police.SetBool("walk",false);
            Police.SetBool("talk",true);
        }
         if(PlayerScript.policemove1){
            transform.LookAt(GameObject.FindGameObjectWithTag("walk").transform);  
        }
    }
    // void OnTriggerEnter(Collider col){
    //     	if(col.gameObject.tag=="walk"){
    //             print("ppp");
	// 		Destroy(col.gameObject);
	// 		PlayerScript.policemove1=true;
    //         PlayerScript.policeTalk=false;
	// 	}
    // }
}
