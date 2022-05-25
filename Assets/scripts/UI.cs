using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameManager GM;
    

    public Text distance;
    public Text height;
    public bool isDistance;
    public Slider slider;
    public bool sliderChange;

    public GameObject endPanel;
    public float endTime = 1.5f;

    public GameObject shopPanel;

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
            slider.value = GM.cannon.power;
                
        }
        

        if (GM.target != null)
        {
            distance.text = GM.target.transform.position.x.ToString();
            distance.text = string.Format("DISTANCE = {0:00.0} METERS", GM.target.transform.position.x);



            height.text = GM.target.transform.position.y.ToString();
            height.text = string.Format("HEIGHT = {0:00.0} METERS", GM.target.transform.position.y);
        }
        

        
    }

    public void End()
    {
        endTime -= Time.deltaTime;
        if (endTime <= 0f)
            endPanel.SetActive(true);
    }

    public void Shop()
    {
        endPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
