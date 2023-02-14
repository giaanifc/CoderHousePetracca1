using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healscript : MonoBehaviour
{
    [SerializeField] float amountToheal;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
        }
        

    }
}
