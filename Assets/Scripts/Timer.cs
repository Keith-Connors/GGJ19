using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f;
    public EventInteract[] events;
    public int currentevent;

    private void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
<<<<<<< HEAD
        if (timer % 5 == 0)
        {
            currentevent = Random.Range(0, events.Length);
            events[currentevent].isactive = true;
        }
    }
<<<<<<< HEAD
=======
        if (Mathf.RoundToInt (timer) % 5 == 1)
        {
            StartCoroutine("choose");

        }
    }
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
    IEnumerator choose ()
    {
        currentevent = Random.Range(0, events.Length);
        yield return new WaitForSeconds(5);
        events[currentevent].isactive = true;
    }
<<<<<<< HEAD
=======
>>>>>>> 5b174ba23c7ca111ef6e7188a473cf6cd5d725ec
=======
>>>>>>> parent of 937297a... Merge branch 'master' of https://github.com/Keith-Connors/GGJ19
}
