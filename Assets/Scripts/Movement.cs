using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("Controls/Player Movement")]

public class Movement : MonoBehaviour
{
    public float speed0 = 1.0f;

    private void Update()
    {
        if (Input.GetButton("Dash"))
        {
            transform.Translate(transform.forward * Input.GetAxis("Vertical"));
            transform.Translate(transform.right *Input.GetAxis("Horizontal"));
        }
        float h = speed0 * (Input.GetAxis("A, D"));
     
    }
    
}
