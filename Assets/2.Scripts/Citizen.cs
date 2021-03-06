﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class Citizen : MonoBehaviour
{
    NavMeshAgent nav;
    string obstacleTag = "Obstacle";
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        StartCoroutine(MoveCitizen());
    }
    IEnumerator MoveCitizen()
    {

        while (true)
        {

            if (nav.isOnNavMesh)
                nav.SetDestination(new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50)));
            nav.speed = 4;
            yield return new WaitForSeconds(3f); 
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == obstacleTag)
        {
            transform.position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
        }
    }
}
