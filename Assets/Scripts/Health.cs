using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
public class Health : MonoBehaviour
{
    private int maxHealth = 3;
    public int currentHealth;
    private Score score;
    [SerializeField] Image[] heart;
    [SerializeField] Sprite fullHeartSprites;
    [SerializeField] Sprite emptyHeartSprites;
    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
        score = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
            Dead();
        foreach (Image img in heart)
        {
            img.sprite = emptyHeartSprites;
        }

        for (int i = 0; i < currentHealth; i++)
        {
            heart[i].sprite = fullHeartSprites;
        }
    }
    void Dead()
    {
        Time.timeScale = 0;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vegetable"))
        {
           score.Vegetables();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Banana"))
        {
            score.Bananas();
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.CompareTag("Rock"))
        {
            currentHealth -=1; 
            Debug.Log("CurrentHealth: " + currentHealth);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Shit"))
        {
            score.Shits();
            Destroy(collision.gameObject);
        }
    }

}
