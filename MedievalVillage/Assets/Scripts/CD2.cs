using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD2 : MonoBehaviour
{
    public int xPos1;
    public int zPos1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character2")
        {
            xPos1 = Random.Range(335, 373);
            zPos1 = Random.Range(473, 479);
            this.gameObject.transform.position = new Vector3(xPos1, 60.5f, zPos1);
        }

    }
}
