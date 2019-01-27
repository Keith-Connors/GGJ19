using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInteract : MonoBehaviour
{
    public bool isactive = false;
    public float timer;
    public AudioSource audio;
    public EnemyAI ai;

    public void Update()
    {
        if (isactive == true)
        {
            timer += Time.deltaTime;
            float seconds = timer % 60;
            ai.currentstate += timer/200;
        }
        if (isactive == false)
        {
            ai.currentstate -= timer / 200;
        }
        if (isactive == true && audio.isPlaying == false)
        {
            audio.Play();
        }
    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
             {
                isactive = false;
                audio.Stop();
            }
        }
    }
}
