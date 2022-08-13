using UnityEngine;
//new project Script
public class CamFollow : MonoBehaviour
{
    public Transform Target;
   public Transform FollowAboveTarget;
    
    public void Update()
    {
       
        transform.position = new Vector3(Target.position.x, transform.position.y+25, Target.position.z );
       
        transform.position = new Vector3(transform.position.x, FollowAboveTarget.position.y+25, transform.position.z);
      
        //when the player position on the y axis is getting closer to the camera position on y axis , camera should start to go up 
 
    }
}
