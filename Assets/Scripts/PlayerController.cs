using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Health;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float horizontalMouseSpeed;
    [SerializeField] private float verticalMouseSpeed;
    [SerializeField] private float healamount;


    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        MouseView();
        AttackEnemy();
    }
    private void Movement()
    {
        var horizontal = Input.GetAxis("Horizontal") * (speed * Time.deltaTime);
        var vertical = Input.GetAxis("Vertical") * (rotationSpeed * Time.deltaTime);
        if (Health > 0)
        {
            transform.Translate(horizontal, 0, vertical);
            
            
        }

    }
    private void MouseView()
    {
        float h = horizontalMouseSpeed * Input.GetAxis("Mouse X");
        float v = verticalMouseSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
    public void HealthMethod(float a)
    {
        Health += a;
    }
    public void AttackEnemy()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("Attack01");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal" && other.GetComponent<healscript>())
        {
            Debug.Log(message: "must heal");
            HealthMethod(healamount);
        }
    }
}
