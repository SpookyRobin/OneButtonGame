using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnpos;
    public Transform partToRotate;
    public float turnSpeed = 10f;
    public float minRot = 0f;
    public float maxRot = 75f;
    public camFollow camFollow;
    public int minPower, maxPower;
    public float speed;
    public UI ui;
    
    public float power;
    [SerializeField]
    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = mousePos - transform.position;

        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        rotation.z = Mathf.Clamp(rotation.z, minRot, maxRot);
        partToRotate.rotation = Quaternion.Euler(0f, 0f, rotation.z);







            if (Input.GetMouseButton(0))
            {
                Debug.Log("Holding...");
                power = Mathf.SmoothStep(minPower, maxPower, Mathf.PingPong(Time.time  * speed, 1));
                ui.slider.gameObject.SetActive(true);
            }

        if (Input.GetMouseButtonUp(0))
        {
            if(canShoot == true)
            Shoot();

            canShoot = false;
            ui.sliderChange = false;
            ui.slider.gameObject.SetActive(false);
        }
    }

    void Shoot()
    {
        var instance = Instantiate(prefab, spawnpos.position, partToRotate.rotation);
        instance.GetComponent<Rigidbody2D>().AddForce(this.transform.right * power);
        camFollow.target = instance.transform;
    }
}
