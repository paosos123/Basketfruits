using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]private Health health;
    [SerializeField]private ItemSpawner spawner;
    [SerializeField] private GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((health.currentHealth <= 0) || (spawner.totalItemCount == spawner.spawnedItems))
        {
            gameOverUI.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
