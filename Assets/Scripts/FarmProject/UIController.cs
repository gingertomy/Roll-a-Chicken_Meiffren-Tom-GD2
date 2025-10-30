using System;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _nbFertilizer;
    [SerializeField] private TMP_Text _Timer;
    
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
        _scoreText.text = $"Chicken : {newScore.ToString()}/10";
    }

    public void UpdateInventory(int newInventory)
    {
        _nbFertilizer.text = $"{newInventory.ToString()}";
    }
    
    public void DisplayTime(float timeDisplay)
    {
        timeDisplay += 1;
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        _Timer.text= $"{minutes:00}:{seconds:00}";
    }
}