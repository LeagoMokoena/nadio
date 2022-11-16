using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _waypoints : MonoBehaviour
{
    public int current;
    public bool route = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "player")
        {
            return;
        }
        other.gameObject.GetComponent<Animator>().SetInteger("currentcheck",current);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
