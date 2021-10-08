using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    void Update()
    {
        var modele = GameObject.FindGameObjectsWithTag("TagDublu");
        if(modele.Length>=2)
        {
            var distantaObiecte = modele[0].transform.position - modele[1].transform.position;
            if (distantaObiecte.magnitude < 2)
            {
                Debug.Log(distantaObiecte.magnitude);
                modele[0].GetComponent<Animator>().SetTrigger("jump");
                modele[1].GetComponent<Animator>().SetTrigger("attack");
            }

        }
    }
}
