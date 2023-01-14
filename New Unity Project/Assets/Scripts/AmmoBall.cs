using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBall : MonoBehaviour
{
    public float speed;
    public int damage;
    public Vector3 Direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Direction * speed;
    }
}
