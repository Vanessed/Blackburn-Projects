using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSquareController : MonoBehaviour
{
    public bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // void OnMouseDown()
    // {
    //         pressed = !pressed;
    //         GameObject.Find("Board" + gameObject.name).GetComponent<Renderer>().enabled = pressed;
    // }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Board" + gameObject.name).GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
        GameObject.Find("Board" + gameObject.name).GetComponent<Renderer>().enabled = true;
    }
}
