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
        if ((playerAIDestSet.target == null || Vector2.Distance(playerAIDestSet.target.position, transform.position) < 0.1f) && Input.GetMouseButtonDown(1))
        {
            //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D[] colliders = Physics2D.OverlapPointAll(worldPoint);
            bool found = false;
            for (int i = 0; i < colliders.Length; i++)
            {
                Collider2D currentCollider = colliders[i];
                Debug.Log("Collider Overlap[" + i + "]: " + currentCollider.gameObject.name);
                if (currentCollider.gameObject.transform == room1Detect)
                {
                    found = true;
                    playerAIDestSet.target = room1StandPos;
                    break;
                }
                else if (currentCollider.gameObject.transform == room2Detect)
                {
                    found = true;
                    playerAIDestSet.target = room2StandPos;
                    break;
                }
                else if (currentCollider.gameObject.transform == frontDeskDetect)
                {
                    found = true;
                    playerAIDestSet.target = frontDeskStandPos;
                    break;
                }
            }

            if(!found)
            {
                Debug.Log("no collider");
            }

            
        }

        //these 3 lines show the use of a raycast in the scene window
        Vector2 otherWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, otherWorldPoint - (Vector2)transform.position);

        Debug.DrawLine(transform.position, hit.point, Color.red);


    }
}
