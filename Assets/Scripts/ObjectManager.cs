using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectManager : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Respawn")
        {
            for (int i = 0; i < collision.transform.childCount; i++)
            {
                collision.transform.GetChild(i).gameObject.SetActive(true);
            }

        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.transform.tag == "Respawn")
        {
            for (int i = 0; i < collision.transform.childCount; i++)
            {
                collision.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
