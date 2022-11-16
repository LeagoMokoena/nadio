using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_manage : MonoBehaviour
{
    [SerializeField] public Transform[] pts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public Vector3 find(int po, bool che = false)
    {
        foreach(GameObject pi in pts)
        {
            if(pi.GetComponent<_waypoints>().current == po)
            {
                return pi.transform.position;
            }
        }
        return new Vector3();
    }*/
}
