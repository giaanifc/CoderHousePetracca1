using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private float healamount;
    [SerializeField] private Vector3 PortalScale;
    [SerializeField] private float timetochange = 2f;
    private float _currentTime;
    [SerializeField] private Transform[] newPositions;
    public void OnTriggerStay(Collider other)
    {
        if (_currentTime <= Time.time && TryGetComponent< HarryController > (out var c_wall))
        {
            _currentTime = Time.time + timetochange;
            GetPosition();
        }
    }
    public Transform GetPosition()
    {
        return newPositions[Random.Range(0, newPositions.Length)];
    }
}
