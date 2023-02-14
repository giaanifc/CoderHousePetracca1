using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instanciateGameManager;
    public bool dontDestroy;
    private int score;
    public int _Score => score;

    private void Awake()
    {
        if (instanciateGameManager != null)
        {
            Destroy(gameObject);
        }
        else { 
            instanciateGameManager = this;
            if (dontDestroy)
                DontDestroyOnLoad(this);
            
            
        }
    }
    public void ScoreManager(int scoreToAdd)
    {
        score += scoreToAdd;

    }
    void Start()
    {

    }

  

}