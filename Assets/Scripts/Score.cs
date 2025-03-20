using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scores = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private  int vegetablesScore =10;
    [SerializeField] private  int bananasScore;
    [SerializeField] private  int shitsScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + scores;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vegetables()
    {
        scores += vegetablesScore; 
        scoreText.text = "Score: " + scores;
        Debug.Log("Score: " + scores);
    }
    public void Bananas()
    {
        scores += bananasScore; 
        scoreText.text = "Score: " + scores;
        Debug.Log("Score: " + scores);
    }
    public void Shits()
    {
        scores -= shitsScore; 
        scoreText.text = "Score: " + scores;
        Debug.Log("Score: " + scores);
    }
}
