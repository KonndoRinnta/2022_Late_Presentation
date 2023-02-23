using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateStageData")]
public class StageData : ScriptableObject
{
    [SerializeField] StageParameter[] _stageParms;
    public GameObject GetStage(StageType stageType)
    {
        GameObject stagePrefab = null;

        foreach (var param in _stageParms)
        {
            if (stageType == param.StageType)
            {
                Instantiate(param.Stage);
                break;
            }
        }

        return stagePrefab;
    }
}

[System.Serializable]
class StageParameter
{
    public StageType StageType => _stageType;
    public GameObject Stage => _stage;
    [SerializeField] StageType _stageType;
    [SerializeField] GameObject _stage;

}
public enum StageType
{
    Tutorial,
    Stage1,
    Stage2
}
