using System.Collections;
using System.Collections.Generic;
using UnityEngine;

             //Or Game Object*
public class IsPlayerOnPlatfrorm : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           //should fix to affect only player position 
           //should fix turning effect on player transform(rotation and scale)
            collision.transform.parent = gameObject.transform ;
          
        }

       
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = null;
          
            
        }
        

    }


}
