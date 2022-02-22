using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupManager : MonoBehaviour
{
    public Camera camera;

    [SerializeField] private bool alignmentEnabled = false;
    [SerializeField] private bool separtionEnabled = false;
    [SerializeField] private bool cohesionEnabled = false;
    [SerializeField] private bool seekEnabled = false;
    [SerializeField] private bool wonderEnabled = false;

    [SerializeField] private float aligmentWeight = 1.0f; //makin besar nilainya makin relative pada boid lain
    [SerializeField] private float separationtWeight = 2.0f;
    [SerializeField] private float cohesionWeight = 1.5f;
    [SerializeField] private float seekWeight = 1.0f;
    [SerializeField] private float wonderWeight = 1.0f;

    //spwaning boid
    public static int numBoidSwapn = 50;
    public static List<GameObject> boids;

    [SerializeField] private GameObject boidPrefab;
    private float boidRadius;

    //spwan boid location
    private float minX = 200;
    private float minY = 200;
}

