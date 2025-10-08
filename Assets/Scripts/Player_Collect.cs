using System;
using UnityEngine;

public class Player_Collect : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private UIController _uiController;
   //Defintion de l'action (Event Dispatcher) avec l'input entre <> ici un int 
    public static Action<int> OnTargetCollected;

    public void UpdateScore(int value)
    {
        _scoreData.ScoreValue = Mathf.Clamp(_scoreData.ScoreValue + value, min: 0, max: _scoreData.ScoreValue + value); 
        //Call event dispatcher (invoke avec l'input entre parenthèse)
        OnTargetCollected?.Invoke(_scoreData.ScoreValue);
    }
}