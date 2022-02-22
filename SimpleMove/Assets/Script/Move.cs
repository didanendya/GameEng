using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 goal;
    float speed = 1.0f;
    float accucary = 1.0f;

    float rotSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        goal = this.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            goal = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
        }

        //this.transform.LookAt(goal);
        Vector3 direction = goal - this.transform.position;

        if(Vector3.Distance(transform.position, goal) > accucary)
        {
            /*
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, 
            Quaternion.LookRotation(direction), Time.deltaTime*rotSpeed);
            */
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
            Quaternion.LookRotation(direction), Time.deltaTime*rotSpeed);
            this.transform.Translate(0,0, speed*Time.deltaTime);
        }
             
        /*RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            Vector3 newPosition = new Vector3(hit.point.x, this.transform.position.y,hit.point.z);
            this.transform.position = newPosition;
            Debug.Log("Posisi sekarang : " + newPosition.ToString());
        }*/
    }
}
