using UnityEngine;
using System;

public class Collector : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;

    [SerializeField] private UIController _uiController;

  
    public static Action<int> OnTargetCollected;
    public static Action<int> FertilizerCollected;
    
    public void UpdateScore(int value)
    {
        _scoreData.ScoreValue = Mathf.Clamp(_scoreData.ScoreValue + value, min: 0, max: _scoreData.ScoreValue + value);
        OnTargetCollected?.Invoke(_scoreData.ScoreValue);
        
    }
    
    public void UpdateInventory(int inventoryValue)
    {
        _scoreData.Inventory = Mathf.Clamp(_scoreData.Inventory + inventoryValue, min: 0, max: _scoreData.Inventory + inventoryValue);
        FertilizerCollected?.Invoke(_scoreData.Inventory);
    }

}
