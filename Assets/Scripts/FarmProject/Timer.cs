using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float _timeRemaining = 120f;
    private bool _timerIsRunning = false;
    [SerializeField] private UIController _uiController;
    [SerializeField] private ScoreDatas _scoreDatas;
    [SerializeField] private Canvas _looseCanvas;
    [SerializeField] private Canvas _winCanvas;
    
    public void StartTimer()
    {
        _timerIsRunning = true;
    }

    void Start()
    {
        _timerIsRunning = true;
    }

    void Update()
    {
        if (_timerIsRunning)
        {
            if (_scoreDatas.ScoreValue == 10)
            {
                _winCanvas.gameObject.SetActive(true);
            }
            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;
                _uiController.DisplayTime(_timeRemaining);
            }
            else
            {
                _timeRemaining = 0;
                _timerIsRunning = false;
                if (_scoreDatas.ScoreValue < 10)
                {
                    _looseCanvas.gameObject.SetActive(true);
                }
                
            }
        }
    }
}


