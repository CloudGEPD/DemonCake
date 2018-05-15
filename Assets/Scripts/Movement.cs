using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[AddComponentMenu("Controls/Player Movement")]

public class Movement : MonoBehaviour
{
    Transform mc;
    public float speed0;

    private void Update()
    {
        
        {
            mc.Translate(transform.forward * Input.GetAxis("Vertical"));
            mc.Translate(transform.right *Input.GetAxis("Horizontal"));
        }
        //float h = speed0 * (Input.GetAxis("A, D"));
     
    }
    void HorizontalSpeed()
    {
       // float h 
    }
    
}
