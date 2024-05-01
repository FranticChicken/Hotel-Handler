using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class NPC : MonoBehaviour
{
    AIDestinationSetter NPCDestinationSetter;
    public Transform lineUpPos1;

    // Start is called before the first frame update
    void Start()
    {
        NPCDestinationSetter = GetComponent<AIDestinationSetter>();

        NPCDestinationSetter.target = lineUpPos1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
