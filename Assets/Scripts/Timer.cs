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
        if (Mathf.RoundToInt (timer) % 5 == 1)
        {
            StartCoroutine("choose");

        }
    }
    IEnumerator choose ()
    {
        if (chosen == false);
        currentevent = Random.Range(0, events.Length);
        events[currentevent].isactive = true;
        chosen = true;
        yield return new WaitForSeconds(5);
        
    }
}
