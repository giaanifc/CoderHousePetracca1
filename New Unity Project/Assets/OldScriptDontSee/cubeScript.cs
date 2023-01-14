using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{

    public float velocity;
    public int salud;
    public Vector3 movement;
    public string name;


    private void Awake()
    {
        name = "Gianluca";

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name+"Petracca");
        salud = 100;
        heal(100); // aca tendria 200 vida
        attack(10); //aca 190 de vida
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = (transform.position + movement)*velocity; desafioentregable |1|
        mover(movement);//lo muevo con este metodo pasandole la variable desde unity
    }


    
    private void heal(int healing)
    {
        salud += healing;
    }


    public void attack(int damage)
    {
        salud -= damage;
    }

    public void mover(Vector3 movimientometodo)
    {
        transform.position = movimientometodo;
    }
}
