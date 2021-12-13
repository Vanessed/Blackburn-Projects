using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera BlueCamera;
    public Camera RedCamera;

    // Start is called before the first frame update

    void Start()
    {
        RedCamera.enabled = true;
        BlueCamera.enabled = false;
        //if (Random.Range(0.0f,1.0f) > 0.5f)
        //{
        //    BlueCamera.enabled = true;
        //    RedCamera.enabled = false;
        //} else
        //{
        //    RedCamera.enabled = true;
        //    BlueCamera.enabled = false;

        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
