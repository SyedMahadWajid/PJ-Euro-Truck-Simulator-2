using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingArrows : MonoBehaviour
{
    public GameObject one, two, three;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(load());
    }

    IEnumerator load() {
        one.SetActive(true);
        two.SetActive(false);
        three.SetActive(false);
        yield return new WaitForSeconds(speed);
        one.SetActive(false);
        two.SetActive(true);
        three.SetActive(false);
        yield return new WaitForSeconds(speed);
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(true);
        yield return new WaitForSeconds(speed);
        StartCoroutine(load());
    }
}
