using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private bool paralyzed;
    [SerializeField] private float health;
    [SerializeField] private float damage;
    [SerializeField] private float speedrotation;
    

    void Start()
    {
        ReceiveDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        var direction = new Vector3(horizontal, 0, vertical);
        Move(direction);
        if (direction != Vector3.zero)
        {
            var newRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedrotation * Time.deltaTime);
        }
        


    }
    private void Move(Vector3 movedirection)
    {
        transform.position += movedirection * (speed * Time.deltaTime);
    }

    private void IamAlive()
    {
        if (health <= 0) {
            Debug.Log(message: "death");
        }
    }

    private void ReceiveDamage(float dmg)
    {
        health -= dmg;
    }
}
