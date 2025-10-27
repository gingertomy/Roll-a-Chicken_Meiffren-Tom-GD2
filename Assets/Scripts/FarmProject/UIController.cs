using System;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _nbFertilizer;
    
    private void OnEnable()
    {
        Collector.OnTargetCollected += UpdateScore;
        Collector.FertilizerCollected  += UpdateInventory;
    }
    private void OnDisable()
    {
        Collector.OnTargetCollected -= UpdateScore;
        Collector.FertilizerCollected  -= UpdateInventory;
    }
    private void Start()
    {
        UpdateScore(0);
        UpdateInventory(0);
    }

    
    public void UpdateScore(int newScore)
    {
        _scoreText.text = $"Score : {newScore.ToString()}/10";
    }

    public void UpdateInventory(int newInventory)
    {
        _nbFertilizer.text = $"{newInventory.ToString()}";
    }
}