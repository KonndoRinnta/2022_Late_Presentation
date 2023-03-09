using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject _firstPanel;
    [SerializeField] GameObject _nextPanel;
    public void Next()
    {
        _firstPanel.SetActive(false);
        _nextPanel.SetActive(true);
    }
    public void End()
    {
        _nextPanel.SetActive(false);
    }
}
