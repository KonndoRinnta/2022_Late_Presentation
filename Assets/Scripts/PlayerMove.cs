using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    [Header("移動速度")] float _speed;

    [SerializeField]
    [Header("ジャンプ力")] float _jumpPower;

    [SerializeField]
    [Header("床のタグ名")] string _groundTag = "Ground";
    private Rigidbody rb;
    private bool _isGround = false;
    float moveX;
    float moveZ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * _speed;
        moveZ = Input.GetAxis("Vertical") * _speed;
        rb.AddForce(new Vector3(moveX, 0, moveZ));
        if(_isGround == true)
        {
            if(Input.GetKeyDown("space"))
            {
                Debug.Log("a");
                rb.AddForce(new Vector3(0, _jumpPower, 0));
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == _groundTag)
        {
            _isGround = true;
        }
    }
}
