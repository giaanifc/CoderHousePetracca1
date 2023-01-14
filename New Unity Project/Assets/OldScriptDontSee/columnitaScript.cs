using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnitaScript : MonoBehaviour
{

    public string name;
    public int edad;
    public float pesoaprox;
    public double pi;
    [SerializeField] private cubeScript pepe;
    [SerializeField] private int damage;
    public Vector3 algo;
    public Vector3 pepito;
    // Start is called before the first frame update
    void Start()
    {
        damage = 50;
        name = "Petracca";
        edad = 29;
        pesoaprox = 50;
        pi = 31;
        pepe.salud -= damage;
        transform.position += algo;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = pepito;
    }
}
