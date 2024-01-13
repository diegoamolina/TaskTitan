using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.IO;

public class SC_Audio : MonoBehaviour
{
    public AudioClip[] allClips;
    private AudioSource theSource;

    private void Start()
    {
        theSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlaySFX()
    {
        theSource.clip = allClips[Random.Range(0, allClips.Length)];
        theSource.Play();
    }
}
