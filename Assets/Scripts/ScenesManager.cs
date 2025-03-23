using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
   [SerializeField] private GameObject uiHowToPlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
     public void HowToPlay()
    {
       uiHowToPlay.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        uiHowToPlay.SetActive(false);
    }
}
