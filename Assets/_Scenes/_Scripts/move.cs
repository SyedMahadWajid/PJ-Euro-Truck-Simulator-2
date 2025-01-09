using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Animator Char;
    public GameObject Character;
    // Start is called before the first frame update
    void Start()
    {
       Char = Character.GetComponent<Animator>();
    }
    void Update()
    {
    if(PlayerScript.Move)
    {
      Char.SetBool("salute",true);
      //transform.LookAt(GameObject.FindGameObjectWithTag("walk").transform);  
    }
  }
}
