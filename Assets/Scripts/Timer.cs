using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f;
    public EventInteract[] events;
    public int currentevent;
    bool chosen = false;

    private void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
        if (timer % 5 == 0)
        {
            currentevent = Random.Range(0, events.Length);
            events[currentevent].isactive = true;
        }
    }
<<<<<<< HEAD
    IEnumerator choose ()
    {
        if (chosen == false);
        currentevent = Random.Range(0, events.Length);
        events[currentevent].isactive = true;
        chosen = true;
        yield return new WaitForSeconds(5);
        
    }
=======
>>>>>>> 5b174ba23c7ca111ef6e7188a473cf6cd5d725ec
}
