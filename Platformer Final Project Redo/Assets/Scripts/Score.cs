using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMesh ScoreText ;
   
    private void Update()
    {
       ScoreText.text=player.position.z.ToString("0");
       Debug.Log(ScoreText.text);
    }
}
