using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float _timeRemaining = 120f;
    private bool _timerIsRunning = false;
    [SerializeField] private UIController _uiController;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private ScoreDatas _scoreDatas;
    [SerializeField] private Canvas _looseCanvas;
    [SerializeField] private Canvas _winCanvas;
    [SerializeField] private AudioSource _bgdMusic;
    [SerializeField] private AudioClip _win;
    [SerializeField] private AudioClip _loose;
    private bool _winPlayed = false;
    private bool _losePlayed = false;

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
            if (_scoreDatas.ScoreValue >= 10 && !_winPlayed)
            {
                _winPlayed = true;
                _timerIsRunning = false;
                _winCanvas.gameObject.SetActive(true);
                _bgdMusic.Stop();
                _bgdMusic.loop = false;
                AudioSource.PlayClipAtPoint(_win, Camera.main.transform.position, 0.3f);
                _scoreDatas.ResetData();
                _playerMovement.StopMovement();

            }

            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;
                _uiController.DisplayTime(_timeRemaining);
                _scoreDatas.ResetData();
            }
            else if (!_losePlayed)
            {
                _losePlayed = true;
                _timerIsRunning = false;
                if (_scoreDatas.ScoreValue < 10)
                {
                   LoseTimer();
              
                }
            }
        }

    }

    public void LoseTimer()
    {
        _looseCanvas.gameObject.SetActive(true);
        _bgdMusic.Stop();
        _bgdMusic.loop = false;
        AudioSource.PlayClipAtPoint(_loose, Camera.main.transform.position, 0.3f);
        _playerMovement.StopMovement();
        _scoreDatas.ResetData();
    }
}


