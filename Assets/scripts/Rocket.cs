using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private float CurrentFuel;

    public float StartFuel = 100f;
    public float thrust = 2f;

    public Rigidbody2D RB;

    // Start is called before the first frame update

    public void Awake()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        CurrentFuel = StartFuel;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CurrentFuel > 0)
        {
            RB.AddForce(Vector2.up * thrust);
            CurrentFuel -= 1f * Time.deltaTime;
        }
        else
        {
            return;
        }
    }
}
