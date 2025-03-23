using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public   class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip vegetables;
    [SerializeField] private AudioClip bananas;
    [SerializeField] private AudioClip rocks;
    [SerializeField] private AudioClip shits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VegetablesSFX()
    {
        audioSource.PlayOneShot(vegetables);
    }

    public void BananasSFX()
    {
        audioSource.PlayOneShot(bananas);
    }

    public void RocksSFX()
    {
        audioSource.PlayOneShot(rocks);
    }

    public void ShitsSFX()
    {
        audioSource.PlayOneShot(shits);
    }
}
