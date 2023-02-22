using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateStageData")]
public class StageData : ScriptableObject
{
    [SerializeField] List<StagePair> _stageList = new List<StagePair>();

    public GameObject GetStage(PlayStage stage)
    {
        GameObject stagePrefab = null;

        foreach (var pair in _stageList)
        {
            //if(stage == pair._playStage)
            //{

            //    break;
            //}
        }

        return stagePrefab;
    }
}

[System.Serializable]
class StagePair
{
    [SerializeField] PlayStage _playStage;
    [SerializeField] GameObject _stage;


}
public enum PlayStage
{
    Tutorial,
    Stage1,
    Stage2
}
