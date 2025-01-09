using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoliceMen : MonoBehaviour {
    public static PoliceMen _instance;
    bool MoveTowords;
    public float Distance;
    public Transform[] MoveToW;
    public float speed;
    public int count;
    Animator anim;
    public Transform[] look;
    public GameObject Bag;

    // Use this for initialization
    void Start() {
        if (!_instance)
        {
            _instance = this;
        }

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, MoveToW[count].position, Time.deltaTime * speed);
        //transform.LookAt (look[count]);
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count < MoveToW.Length - 6) {

            count++;

        }
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count < MoveToW.Length - 5)
        {

            //anim.SetBool("Walk", false);
            //anim.SetBool("Idle", true);
            //MoveTowords = false;

        }
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count < MoveToW.Length - 4)
        {

        }
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count < MoveToW.Length - 2)
        {

            count++;

        }
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count < MoveToW.Length - 1)
        {

            count++;

        }
        if (Vector3.Distance(transform.position, MoveToW[count].position) <= Distance && count == MoveToW.Length - 1) {

            //anim.SetBool ("Walk", false);
            //anim.SetBool("Sitting", true);
            transform.LookAt(look[count]);
            //MoveTowords = false;

        }
   
}
    IEnumerator Luggage()
    {
        yield return new WaitForSeconds(4.0f);

        count++;
        anim.SetBool("Putting", true);
        anim.SetBool("Luggage", false);
      
        yield return new WaitForSeconds(1.0f);
        Bag.SetActive(false);
       
        yield return new WaitForSeconds(2.0f);
        MoveTowords = true;
        anim.SetBool("Putting", false);
        anim.SetBool("Walk", true);
       
        
        //yield return new WaitForSeconds(4.5f);
        //counting++;
        //anim.SetBool("Putting", true);
        //anim.SetBool("Luggage", false);
        //transform.LookAt(look[counting]);
        //yield return new WaitForSeconds(1.0f);
        //
        //Truck_Control.ins.Pick_Camera.SetBool("Door_Open", false);
        // Truck_Control.ins.Pick_Camera.SetBool("Door_Close", true);

        // GameManager.instance.Rc_Cam.GetComponent<Camera>().enabled = true;
        // yield return new WaitForSeconds(1.0f);

        // RCC_Camera.instance.useOrbitInTPSCameraMode = true;
    }
    public void Bag_Process()
    {

        StartCoroutine(Luggage());
        anim.SetBool("Idle", false);
        anim.SetBool("Luggage", true);

    }


    public void Passenger_Walk(){
		MoveTowords = true;
        anim.SetBool ("Walk",true);
	}

    

}
