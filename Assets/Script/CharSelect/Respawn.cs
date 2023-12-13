using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    GameObject player;


    void Start()
    {   
        player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
        player.transform.position = transform.position;
    }
}
