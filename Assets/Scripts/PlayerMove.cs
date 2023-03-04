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
    [SerializeField]float _distans = 1.0f;
    private Rigidbody _rb;
    private bool _isGround = false;
    float moveX;
    float moveZ;
    Vector3 _dir = Vector3.zero;
    Camera _camera = null;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }
    void Update()
    {
        _dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        _dir = _camera.transform.rotation * _dir;
        _rb.AddForce(_dir * _speed);
        Vector3 vel = _rb.velocity.normalized;


        Vector3 rayPosition = transform.position + new Vector3();
        Ray ray = new Ray(rayPosition, Vector3.down);
        _isGround = Physics.Raycast(ray, _distans);
        Debug.DrawRay(rayPosition, Vector3.down * _distans, Color.red);
        if (Input.GetKeyDown("space"))
        {
            if (_isGround)
            {
                Debug.Log("a");
                _rb.AddForce(0, _jumpPower, 0, ForceMode.Impulse);
            }
        }
    }
}
