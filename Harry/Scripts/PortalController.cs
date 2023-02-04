using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //var harry = other.GetComponent<HarryController>();

        if (other.CompareTag("Player"))
        {
            Debug.Log(message: "harry ha entrado");
        }
    }
}
