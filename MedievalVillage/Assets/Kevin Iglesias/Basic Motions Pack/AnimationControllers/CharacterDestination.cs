using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDestination : MonoBehaviour
{

    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            xPos = Random.Range(332, 385);
            zPos = Random.Range(514, 522);
            this.gameObject.transform.position = new Vector3(xPos, 63.01f, zPos);
        }

    }
}