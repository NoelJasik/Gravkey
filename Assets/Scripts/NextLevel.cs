using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    GameObject[] doors;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].SetActive(!doors[i].activeSelf);
            }
        }
    }
}
