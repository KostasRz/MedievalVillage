using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD1 : MonoBehaviour
{

    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            xPos = Random.Range(332, 385);
            zPos = Random.Range(515, 522);
            this.gameObject.transform.position = new Vector3(xPos, 61.01f, zPos);
        }

    }
}