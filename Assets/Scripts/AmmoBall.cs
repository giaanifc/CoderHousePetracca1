using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBall : MonoBehaviour
{
    public float speed;
    public int damage;
    private float lifetime = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
        CountToDissapear();
        MakeBigger();
    }

    private void CountToDissapear()
    {
        lifetime -=Time.deltaTime;
        if(lifetime <=0 )
        {
            DissapearBullet();
        }
    }
    private void DissapearBullet()
    {
        Destroy(gameObject);
    }

    private void MakeBigger()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += Vector3.one * Time.deltaTime;
        }
    }
}
