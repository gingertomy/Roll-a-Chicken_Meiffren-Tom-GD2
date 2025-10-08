using System;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    //Fonction appelée à chaque activation du mono behaviour
    private void OnEnable()
    {
        //bind entre la fonction update score et l'action OnTargetCollected
        Player_Collect.OnTargetCollected += UpdateScore;
    }
    //Fonction appelée à chaque désactivation du mono behaviour
    private void OnDisable()
    {
        Player_Collect.OnTargetCollected -= UpdateScore;
    }
    private void Start()
    {
        UpdateScore(0);
    }

    
    public void UpdateScore(int newScore)
    {
        _scoreText.text = $"Score : {newScore.ToString()}";
    }
}