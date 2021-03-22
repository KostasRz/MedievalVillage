using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD2 : MonoBehaviour
{
    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character2")
        {
            xPos = Random.Range(335, 379);
            zPos = Random.Range(473, 479);
            this.gameObject.transform.position = new Vector3(xPos, 60.5f, zPos);
        }

    }
}
