using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject goWinscreen;
    [SerializeField] GameObject goKnuckles;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goWinscreen.SetActive(true);

            goKnuckles.GetComponent<KI>().bFollow = false;
        }
    }
}
