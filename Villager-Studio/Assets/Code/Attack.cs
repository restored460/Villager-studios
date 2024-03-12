using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
       
        {
            if (Input.GetKey(KeyCode.E) && other.gameObject.CompareTag("Enemy")) // Checks if e key is pressed and if they tag is enemy
            {
                Debug.Log("Works");
                Destroy(other.gameObject);
            }
        }
    }
}

