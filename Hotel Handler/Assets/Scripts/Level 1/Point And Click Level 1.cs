using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PointAndClickLevel1 : MonoBehaviour
{
    public AIDestinationSetter aiDestSet;
    private Vector3 ourTarget;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            //use 0 for left mouse button and 1 for right mouse button
            if (Input.GetMouseButtonDown(1))
        {
            ourTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ourTarget.z = transform.position.z;

            aiDestSet.target = ourTarget;
        }

           
    }
}
