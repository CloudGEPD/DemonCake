using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("Controls/Player Movement")]

public class Movement : MonoBehaviour
{
    public float speed0 = 0f;
    public float speed1 = 0f;

    private void Update()
    {
        if (Input.GetButton("Dash"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * Input.GetAxis("Vertical") * speed1);
            transform.Translate(Vector2.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed0);
        }
        else
            transform.Translate(Vector2.up * Time.deltaTime * Input.GetAxis("Vertical") * speed0);
            transform.Translate(Vector2.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed0);
    }
}
