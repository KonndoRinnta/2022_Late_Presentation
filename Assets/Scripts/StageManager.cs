using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    GameObject _playerObj;
    [SerializeField] SpawnSet[] _spawnPoint;
    Transform _currentSpawnPoint;
    private void Start()
    {
        Init();
        PlayerSpawn();
    }
    void PlayerSpawn()
    {
        _currentSpawnPoint = _spawnPoint[0].SpawnPoint;
        _playerObj = Instantiate(_player, _currentSpawnPoint.position, Quaternion.identity);
        Debug.Log(_currentSpawnPoint.name);
    }
    public void SetSpawnPoint(Transform nextPoint)
    {
        _currentSpawnPoint = nextPoint;
        _playerObj.transform.position = _currentSpawnPoint.position;
        Debug.Log(_currentSpawnPoint.name);
    }
    public void Init()
    {
        foreach(var spawn in _spawnPoint)
        {
            spawn.Init(this);
        }
    }
}
