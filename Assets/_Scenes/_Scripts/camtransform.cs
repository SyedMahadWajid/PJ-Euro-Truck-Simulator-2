using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camtransform : MonoBehaviour
{
    public float speed;
    public Transform[] campos; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trucksCustom.grillpos == true)
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.Slerp(transform.position, campos[0].position, step);
            transform.rotation = Quaternion.Lerp(transform.rotation, campos[0].transform.rotation, step);
           trucksCustom. originalpos = false;
            trucksCustom.interiorpos = false;
            trucksCustom.hoodpos = false;
            StartCoroutine(waitinggrill());
        }
        if (trucksCustom.originalpos == true)
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.Slerp(transform.position, campos[1].position, step);
            transform.rotation = Quaternion.Lerp(transform.rotation, campos[1].transform.rotation, step);
            trucksCustom.grillpos = false;
            trucksCustom.interiorpos = false;
            trucksCustom.hoodpos = false;
            StartCoroutine(originalpso());
        }
        if (trucksCustom.interiorpos == true)
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.Slerp(transform.position, campos[2].position, step);
            transform.rotation = Quaternion.Lerp(transform.rotation, campos[2].transform.rotation, step);
            trucksCustom.grillpos = false;
            trucksCustom.originalpos = false;
            trucksCustom.hoodpos = false;
            StartCoroutine(interiorpos());
        }
        if (trucksCustom.hoodpos == true)
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.Slerp(transform.position, campos[3].position, step);
            transform.rotation = Quaternion.Lerp(transform.rotation, campos[3].transform.rotation, step);
            trucksCustom.originalpos = false;
           trucksCustom.interiorpos = false;
            trucksCustom.grillpos = false;
            StartCoroutine(hood());
        }

    }
   IEnumerator waitinggrill()
    {
        yield return new WaitForSeconds(2f);
        trucksCustom.grillpos = false;
        
    }
    IEnumerator originalpso()
    {
        yield return new WaitForSeconds(2f);
        trucksCustom.originalpos = false;
        
    }
    IEnumerator interiorpos()
    {
        yield return new WaitForSeconds(2f);
        trucksCustom.interiorpos = false;

    }
    IEnumerator hood()
    {
        yield return new WaitForSeconds(2f);
        trucksCustom.hoodpos = false;

    }

}

