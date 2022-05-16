using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Obstacle", menuName ="ScriptableObjects/Obstacles")]
public class Obstacles : ScriptableObject
{
    public GameObject prefab;
    public float velocity;
}
