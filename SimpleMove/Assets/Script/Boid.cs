using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{   
    //behaviors
    private float desireSepartion;
    private float alignmentRadius;
    private float cohesionRadius;

    //speed
    public float maxSpeed = 90;
    public float maxForce = 100;

    //wandering
    private int timeLookahead = 4;
    private float wanderingRadius = 60;

    private Rigidbody body;
    
    /*setup semua yang dibutuhkan*/
    private void Awake()
    {
        body = gameObject.GetComponent<Rigidbody>();
        float radius = transform.localScale.x / 2;

        desireSepartion = radius * radius + radius;
        alignmentRadius = radius * radius + 2;
        cohesionRadius = radius * radius + 2;

        HeadInRandomDirection();

    }

    //applied max Force for random direction dari boid
    void HeadInRandomDirection()
    {
        Vector2 rand =  Random.insideUnitCircle;
        Vector3 initialHeading = new Vector3(rand.x, transform.position.y, rand.y);
        body.AddForce(initialHeading * maxForce);
    }

    //Call per frame by group manager. identifikasi boid dengan boid tetangga,
    //memisahkan masing2 supaya tidak terjadi tumbukan 
    public Vector3 Separate()
    {
        Vector3 totalSeparation = Vector3.zero;
        int numNeighbour = 0;
        
        foreach(GameObject boid in GroupManager.boids)
        
    }
}
