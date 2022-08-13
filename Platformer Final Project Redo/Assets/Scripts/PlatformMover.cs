using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    private bool isMovingTowardsTarget;
    private Vector3 ObjectToMoveStartingPosition;
    public float MoveSpeed;
    // add specific target for platform variants  
    public Transform Target;
     public Transform ObjectToMove;
   
    // Start is called before the first frame update
    void Start()
    {
        ObjectToMoveStartingPosition = ObjectToMove.position;
        isMovingTowardsTarget = true;  
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingTowardsTarget)
        {
            ObjectToMove.position = Vector3.MoveTowards(ObjectToMove.position, Target.position, Time.deltaTime * MoveSpeed);
            if (Vector3.Distance(ObjectToMove.position, Target.position) < 0.5f)//hit target
            {
                isMovingTowardsTarget = false;
            } 
        }
        else
        {
            ObjectToMove.position = Vector3.MoveTowards(ObjectToMove.position, ObjectToMoveStartingPosition, Time.deltaTime * MoveSpeed);
            if (Vector3.Distance(ObjectToMove.position, ObjectToMoveStartingPosition) < 0.5f)
            {
                isMovingTowardsTarget = true;
            
            }
        }
    }
}
