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
            var newTarget = Mathf.Clamp(target.position.y, 1.78f, 10000f);
            Vector3 desiredPosition = new Vector3(target.position.x, newTarget, -10f);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, (cameraSpeed * Time.smoothDeltaTime));
            transform.position = smoothedPosition;
            
        }
    }
}
