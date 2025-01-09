using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelrotator : MonoBehaviour
{
	public float speed;
  public bool x,y,z;
    // Update is called once per frame
    void Update()

    {
      if(x){
        transform.Rotate( speed * Time.deltaTime,0, 0);   
      }
      if(y){
        	transform.Rotate(0, speed * Time.deltaTime, 0);
      }
      if(z){
        	transform.Rotate(0,0,speed * Time.deltaTime); 
      }
    }
}
