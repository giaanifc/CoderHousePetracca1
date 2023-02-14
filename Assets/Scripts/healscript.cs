using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healscript : MonoBehaviour
{
    [SerializeField] float amountToheal;
    [SerializeField] LayerMask layertoheal;

    void OnTriggerEnter(Collider other)
    {
        var rabbit = other.GetComponent<PlayerController>();
        if (other.gameObject.tag == "Player" || other.gameObject.layer == layertoheal)
        {
            Debug.Log(message: "must heal");
            rabbit.HealthMethod(amountToheal);
        }
        

    }
}
