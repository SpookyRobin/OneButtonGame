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
    public Slider slider;
    public Cannon cannon;
    public bool sliderChange;
    

    // Start is called before the first frame update
    void Start()
    {
        sliderChange = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sliderChange)
        {
            slider.value = cannon.power;
                
        }
        

        if (camFollow.target != null)
        {
            distance.text = camFollow.target.transform.position.x.ToString();
            distance.text = string.Format("DISTANCE = {0:00.0} METERS", camFollow.target.transform.position.x);



            height.text = camFollow.target.transform.position.y.ToString();
            height.text = string.Format("HEIGHT = {0:00.0} METERS", camFollow.target.transform.position.y);
        }
    }
}
