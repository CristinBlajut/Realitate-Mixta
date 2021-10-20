using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcat : MonoBehaviour
{
    GameObject text;
    void Start()
    {
        text = GameObject.Find("Text");
        text.SetActive(false);
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name=="Minge 1" || collision.collider.name == "Minge 2" || collision.collider.name == "Minge 3" || collision.collider.name == "Minge 4" || collision.collider.name == "Minge 5" || collision.collider.name == "Minge 6" || collision.collider.name == "Minge 7" || collision.collider.name == "Minge 8")    
        {
            text.SetActive(true);
        }
        
    }
}
