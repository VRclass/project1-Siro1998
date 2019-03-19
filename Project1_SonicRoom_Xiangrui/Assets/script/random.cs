using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class random : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public float speed;
    public NavMeshAgent nav;
    public Vector3 Target;

    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= newtarget)
        {
            newTarget();
            timer = 0;
        }
    }
    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myY = gameObject.transform.position.y;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 1000, myX + 1000);
        float yPos = myY + Random.Range(myY - 1000, myY + 1000);
        float zPos = myZ + Random.Range(myZ - 1000, myZ + 1000);

        Target = new Vector3(xPos, yPos, zPos);
        nav.SetDestination(Target);
    }
}