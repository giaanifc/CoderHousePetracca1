using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BumpWall : MonoBehaviour
{
   
  
    [SerializeField] private Transform[] newPositions;
    [SerializeField] private float timeToChangePosit = 2;
    private float _currentTime;
    public void OnTriggerStay(Collider other)
    {
        

       if (other.tag == "Player")
        {
            var harry = other.GetComponent<HarryController>();
            Debug.Log(message: "Es harry");
            if (harry != null && _currentTime <= Time.time)
            {
                _currentTime = Time.time + timeToChangePosit;
                Vector3 Randomposition = new Vector3(Random.Range(-10, 11),5,Random.Range(-10,11));
                transform.position = Randomposition;
                transform.rotation = Random.rotation;
                
                Debug.Log(message: "tiene q moverse");

            }
        }
    }
   
}
