using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallexEffect;
    public bool isSky;
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallexEffect));
        float dist = (cam.transform.position.x * parallexEffect);
        if (isSky == false)
        {
            transform.position = new Vector3(startpos + dist, 1.78f, transform.position.z);
        }
        if(isSky == true)
        {
            transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        }
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
    
}

