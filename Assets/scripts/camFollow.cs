using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 2f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        target = null;
        if (target == null){
            Debug.Log("target = null");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, -10f);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, (cameraSpeed * Time.smoothDeltaTime));
            transform.position = smoothedPosition;
            
        }
    }
}
