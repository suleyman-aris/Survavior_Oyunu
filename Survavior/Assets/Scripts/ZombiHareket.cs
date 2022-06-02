using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombiHareket : MonoBehaviour
{
    private GameObject oyun;
    // Start is called before the first frame update
    void Start()
    {
        oyun = GameObject.Find("Oyuncu");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyun.transform.position;
    }
}
