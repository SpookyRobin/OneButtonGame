using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 2f;
    public GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        target = null;
        if (target == null){
            Debug.Log("target = null");
        }
        player = GameObject.Find("Box(Clone)");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, (cameraSpeed * Time.smoothDeltaTime));
            transform.position = smoothedPosition;
            
        }
    }
}
