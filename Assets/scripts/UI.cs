using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text distance;
    public Text height;
    public camFollow camFollow;
    public bool isDistance;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDistance == true) {
            distance.text = camFollow.transform.position.x.ToString();
            distance.text = string.Format("{0:00.0} METERS", camFollow.transform.position.x);
        }
        else
        {
            height.text = camFollow.transform.position.y.ToString();
            height.text = string.Format("{0:00.0} METERS", camFollow.transform.position.y);
        }
    }
}
