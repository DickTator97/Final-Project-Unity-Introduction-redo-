using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Connecting Between The Transform Of Game Object(player) To Tmpro Component(Via Inspector) 
    public Transform player;

    //Variable To Check Player Max Distance
   // Connecting Between Tmpro to U.I To the Script
    public TextMeshProUGUI ScoreText;
    
   
    void Update()
    {
        // Converting Player position to string and Show it In The U.I Thus Creating a Score System
        ScoreText.text = player.position.z.ToString("Score:"+"0") ;
       
      
        // Fix Score Lowering if Player Transform is Reduced By collisions
    
    }
}
