using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("Controls/Player Movement")]

public class CamFollow : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        transform.position = player.transform.position;
    }

}
