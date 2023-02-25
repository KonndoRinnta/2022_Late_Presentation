using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    [Header("�ړ����x")] float _speed;

    [SerializeField]
    [Header("�󒆂ł̈ړ����x")] float _airSpeed = 1;

    [SerializeField]
    [Header("�W�����v��")] float _jumpPower;

    [SerializeField]
    [Header("���̃^�O��")] string _groundTag = "Ground";
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
        moveX = Input.GetAxis("Horizontal") * _speed * _airSpeed;
        moveZ = Input.GetAxis("Vertical") * _speed * _airSpeed;
        rb.AddForce(new Vector3(moveX, 0, moveZ));
        if(_isGround == true)
        {
            if(Input.GetKeyDown("space"))
            {
                _airSpeed = 0.2f;
                Debug.Log("a");
                rb.AddForce(0, _jumpPower, 0, ForceMode.Impulse);
                _isGround = false;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == _groundTag)
        {
            _airSpeed = 1;
            _isGround = true;
        }
    }
}
