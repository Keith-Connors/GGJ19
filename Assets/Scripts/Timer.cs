using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
    }
}
