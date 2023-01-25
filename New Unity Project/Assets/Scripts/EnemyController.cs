using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private EnemyStates state;
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private float distanceToPlayer;
    [SerializeField] private float rotationspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ChangeState();
    }
    public enum EnemyStates
    {
        justSeePlayer,chase
    }
    private void ChangeState()
    {
        switch (state)
        {
            case EnemyStates.justSeePlayer:
                LookAtPlayer();
                break;
            case EnemyStates.chase:
                ChasePlayer(); 
                break;
            default: Debug.LogError(message: "You´ve broken the game");
                break;
        }
    }

    

    private void ChasePlayer()
    {
        var VectorToPlayer = player.position - transform.position;
        // VectorToPlayer.Normalize();
        var distance = VectorToPlayer.magnitude;
        //transform.LookAt(player);
        var mirar = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, mirar, Time.deltaTime * rotationspeed);
        if (distance > distanceToPlayer)   //si la distancia del vector al jugador es mayor a la distancia que indiquemos, lo persigue
        {
            transform.position += VectorToPlayer.normalized * (speed * Time.deltaTime);  //seguimos al player, agarrando el transform y le sumamos la distancia al player normailzado
        }
       
    }

   

    private void LookAtPlayer ()
    {
        var mirar = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, mirar, Time.deltaTime * rotationspeed);
    }

    
}
