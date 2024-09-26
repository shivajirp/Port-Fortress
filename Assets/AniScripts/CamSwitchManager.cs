using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchManager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V) && cam1.enabled)
        {
            cam1.enabled=false;
            cam2.enabled=true;
        }

        if(Input.GetKeyUp(KeyCode.V) && cam2.enabled)
        {
            cam1.enabled = true;
            cam2.enabled=false;
        }
    }
}
