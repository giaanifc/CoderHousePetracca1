using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    [SerializeField] private KeyCode shootKeyCode;



    public GameObject ball;
    public Transform PointOfShoot;


    private void Update()
    {
        
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(ball, PointOfShoot);
        Debug.Log("Shoot");
    }
 
}
 