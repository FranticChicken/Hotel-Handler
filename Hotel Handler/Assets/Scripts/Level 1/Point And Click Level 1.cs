using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PointAndClickLevel1 : MonoBehaviour
{
    public AIDestinationSetter playerAIDestSet;
    private Vector3 ourTarget;
    public Transform room1Detect;
    public Transform room2Detect;
    public Transform frontDeskDetect;
    public Transform room1StandPos;
    public Transform room2StandPos;
    public Transform frontDeskStandPos; 

   
    // Start is called before the first frame update
    void Start()
    {
        playerAIDestSet = GetComponent<AIDestinationSetter>();
    }

    // Update is called once per frame
    void Update()
    {

        
            //use 0 for left mouse button and 1 for right mouse button
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && ( playerAIDestSet.target == null || Vector2.Distance(playerAIDestSet.target.position,transform.position) < 0.1f))
            {
               
                if (hit.collider.gameObject.transform == room1Detect)
                {
                    playerAIDestSet.target = room1StandPos;
                }
                else if (hit.collider.gameObject.transform == room2Detect)
                {
                    playerAIDestSet.target = room2StandPos;
                }
                else if (hit.collider.gameObject.transform == frontDeskDetect)
                {
                    playerAIDestSet.target = frontDeskStandPos;
                }
            }
            else
            {
                Debug.Log("no collider");
            }

            
        }

           
    }
}
