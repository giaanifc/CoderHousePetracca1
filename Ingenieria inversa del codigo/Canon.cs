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
        //shootKeyCode para seleccionar la letra desde unity
        //Aca disparamos 2 veces
        if (Input.GetKeyDown("j"))
        {
            Shoot();
            Shoot();
        }
        //aca disparamos 3 veces
        if (Input.GetKeyDown("k"))
        {
            Shoot();
            Shoot();
            Shoot();
        }
        //aca disparamos 4 veces
        if (Input.GetKeyDown("l"))
        {
            Shoot();
            Shoot();
            Shoot();
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(ball, PointOfShoot);
        Debug.Log("Shoot");
    }
 
}
 