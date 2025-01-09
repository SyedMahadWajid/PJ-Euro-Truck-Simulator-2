using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficScript : MonoBehaviour
{
    private Animator barrier;
   bool coins;
    // Start is called before the first frame update
    void Start()
    {
         
        
    }

    void OnTriggerStay(Collider col)
	{
        if(col.gameObject.tag=="stop")
		{
            if(	coins==false)
			{
				coins=true;
				barrier=col.gameObject.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Animator>();
				barrier.SetBool("AnimOn",true);
                barrier.SetBool("AnimOff",false);
			}
		}
         
      
    }
    void OnTriggerExit(Collider col)
	{
        if(col.gameObject.tag=="stop")
		{
            coins=false;
		    barrier.SetBool("AnimOn",false);
            barrier.SetBool("AnimOff",true);
		}
       

    }
}
