using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UI UI;
    public Cannon cannon;
    public camFollow camFollow;

    public float endTime = 1.5f;

    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        cannon.targetRB = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (cannon.targetRB != null)
        {
            if (cannon.targetRB.velocity == Vector2.zero )
            {
                UI.End();
                
            }
        }
    }
}
