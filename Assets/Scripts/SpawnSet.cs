using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSet : MonoBehaviour
{
    [SerializeField] Collider _spawnPointCollider;
    [SerializeField] Transform _spawnPoint;
    public Transform SpawnPoint => _spawnPoint;
    StageManager _stageManager;

    public void Init(StageManager stageManager)
    {
        _stageManager = stageManager;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _stageManager.SetSpawnPoint(_spawnPoint);
            _spawnPointCollider.enabled = false;
        }
    }
}
