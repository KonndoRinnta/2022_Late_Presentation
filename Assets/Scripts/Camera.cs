using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    void Start()
    {
        this.player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
        transform.position = player.transform.position + offset;
        
        //float mx = Input.GetAxis("Mouse X");
        //float my = Input.GetAxis("Mouse Y");
        
        //if (Mathf.Abs(mx) > 0.001f)
        //{
        //    transform.RotateAround(player.transform.position, Vector3.up, mx);
        //}

        //if (Mathf.Abs(my) > 0.001f)
        //{
        //    transform.RotateAround(player.transform.position, transform.right, my);
        //}
    }
}
