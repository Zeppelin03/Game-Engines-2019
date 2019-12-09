using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    AudioSource audioSource;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.pitch > 0)
        {
            rend.material.SetColor("_color", Random.ColorHSV());
        }
    }
}
