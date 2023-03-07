using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    [Header("�S�[���p�l��")] GameObject _goalPanel;
    private void Awake()
    {
        if (_goalPanel == true)
        {
            _goalPanel.SetActive(false);
        }
    }
    public void Goal()
    {
        _goalPanel.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        Goal();
    }
}
