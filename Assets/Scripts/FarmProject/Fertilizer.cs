using UnityEngine;
using System;

public class Fertilizer : MonoBehaviour
{
    [SerializeField] private int _inventoryValuePlus = 1;
    [SerializeField] private int _inventoryValueMin = -1;
    [SerializeField] private Collector _collector;
    [SerializeField] private AudioClip _collectSound;
    [SerializeField] private GameObject _fertilizerUI;
    private bool _collected = false;
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            if (!_collected)
            {
                _collected = true;
                other.gameObject.GetComponent<Collector>().UpdateInventory(_inventoryValuePlus);
                _fertilizerUI.SetActive(true);
                AudioSource.PlayClipAtPoint(_collectSound, transform.position);
                Destroy(gameObject);

            }
        }
    }

    public void UsedFertilizer()
    {
        _collector.UpdateInventory(_inventoryValueMin);
    }
    
}