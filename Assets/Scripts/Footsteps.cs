using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public CharacterController character;
    public AudioSource source;
    public AudioClip steps;
    void Start()
    {
        
    }

    void Update()
    {
     if (character.velocity != Vector3.zero)
        {
            print("tea");
            source.Play();
        }   
     if (character.velocity == Vector3.zero)
        {
            source.Stop();
        }
    }
}
