using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f;
    public EventInteract[] events;
    public int currentevent;
    public bool chosen = false;

    private void Start()
    {
        StartCoroutine("choose");
    }
    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
        
    }
    IEnumerator choose()
    {
        while (true)
        {
            currentevent = Random.Range(0, events.Length);
            events[currentevent].isactive = true;
            yield return new WaitForSeconds(5);
        }
    }
    }

