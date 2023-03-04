using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalNavi : MonoBehaviour
{
    [SerializeField] Transform _goal;
    void Start()
    {
        _goal = GameObject.FindWithTag("Goal").transform;
    }
    void Update()
    {
        this.gameObject.transform.LookAt(_goal);
    }
}

