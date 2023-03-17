using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    public TextMeshPro Text;
    private int Score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Block")
        {
            Score++;
            other.gameObject.SetActive(false);
            Text.text = Score.ToString();
            if(Score == 6)
            {
                Text.text = "Congratulations, you win!";
            }
        }
    }
}
