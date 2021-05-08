using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerScript : MonoBehaviour
{
    [SerializeField] AudioClip fart;

   

    public void Click()
    {
        AudioSource fart = GetComponent<AudioSource>();
        Debug.Log("fart");
        fart.Play();
    }
}
