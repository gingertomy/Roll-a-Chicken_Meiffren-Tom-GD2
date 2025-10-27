using UnityEngine;
using System;

public class Fertilizer : MonoBehaviour
{
    [SerializeField] private int _inventoryValuePlus = 1;
    [SerializeField] private int _inventoryValueMin = -1;
    [SerializeField] private Collector _collector;
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            other.gameObject.GetComponent<Collector>().UpdateInventory(_inventoryValuePlus);
            Destroy(gameObject);
        }
    }

    public void UsedFertilizer()
    {
        _collector.UpdateInventory(_inventoryValueMin);
    }
    
}