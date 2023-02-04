using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    [SerializeField] private float multiplierScale = 2;
    private float _currentTime;
    private float timeToChange = 1;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log(message: "harry ha entrado");
            
            if (_currentTime <= Time.time && other.TryGetComponent<HarryController>(out var l_harryController))
            {
                _currentTime = Time.time + timeToChange;
                Debug.Log(message: "harry va a modfiicar");
                l_harryController.ChangeScale(multiplierScale);

            }
        }
    }
    
}
