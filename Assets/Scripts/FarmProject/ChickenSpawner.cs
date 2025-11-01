using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _chickenPrefab;   
    [SerializeField] private Transform[] _spawnPoints;    
    [SerializeField] private ScoreDatas _scoreData;        

    public void SpawnChicken()
    {
        if (_spawnPoints.Length == 0) return;

        int score = _scoreData.ScoreValue;

        
        int maxIndex = Mathf.Min(score, _spawnPoints.Length - 1);
        int spawnIndex = Random.Range(0, maxIndex + 1);

        Transform spawnPoint = _spawnPoints[spawnIndex];

        Instantiate(_chickenPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}

