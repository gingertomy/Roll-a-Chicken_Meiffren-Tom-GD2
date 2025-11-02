using UnityEngine;

[CreateAssetMenu(fileName = "ScoreDatas", menuName = "Scriptable Objects/ScoreDatas")]
public class ScoreDatas : ScriptableObject
{
    public int ScoreValue = 0;
    public int Inventory = 0;
    public int Life = 3;
        
    public void ResetData()
    {
        ScoreValue = 0;
        Life = 3;
        Inventory = 0;
    }
}
