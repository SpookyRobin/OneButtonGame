using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 spawnpos;
    public Transform partToRotate;
    public float turnSpeed = 10f;
    public float minRot, maxRot;
    public camFollow camFollow;

    // Start is called before the first frame update
    void Start()
    {
        spawnpos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
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
        


        if (Input.GetMouseButtonUp(0))
        {

            Shoot();
            

        }
    }

    void Shoot()
    {
        var instance = Instantiate(prefab, spawnpos, Quaternion.identity);
        instance.GetComponent<Rigidbody2D>().AddForce(this.transform.right * 1000);
        camFollow.target = instance.transform;
    }
}
