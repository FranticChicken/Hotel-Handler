using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PlayerGFX : MonoBehaviour
{

    public AIPath aiPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if moving to the right
        if(aiPath.desiredVelocity.x >= 0.1f)
        {
            //turn player to the right
            transform.localScale = new Vector3(-1, 1f, 1f);
        }
        //if moving to the left
        else if(aiPath.desiredVelocity.x <= -0.1f)
        {
            //turn player left 
            transform.localScale = new Vector3(-1, 1f, 1f);
        }


        
    }
}
