﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float currentstate;
    public float limit;
    public GameObject gameover;
    public GameObject win;
    public Timer time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       if (currentstate >= limit)
        {
            gameover.SetActive(true);
        } 
       if (time.timer > 100f)
        {
            win.SetActive(true);
        }
    }
}
