using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyObject", 3f);
    }
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
