using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Character : MonoBehaviour
{
    public GameObject[] characters;

    [HideInInspector]
   public GameObject activeChild = null;

    private void OnTriggerEnter(Collider other)
    {
        //print("dgf");

        if (other.transform.tag == "Btn")
        {
            characters[int.Parse(other.transform.name)].SetActive(true);
            characters[0].SetActive(false);
            other.gameObject.GetComponent<Button>().interactable = false;

            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;


            foreach (Transform child in transform)
            {
                if (child.gameObject.activeSelf)
                {
                    activeChild = child.gameObject;
                    //print(activeChild.name);
                    break;
                }
            }

        }
    }
}
