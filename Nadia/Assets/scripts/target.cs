using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : StateMachineBehaviour
{
    public int i = 0;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        switch (i)
        {
            case 0: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                break; 
            case 1: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                break; 
            case 2:  int tie = Random.Range(2, 3);
                animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[tie].position;
                break; 
            case 4: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                break; 
            case 5: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                break; 
            case 6:
                int te = Random.Range(6, 7);
                animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[te].position;
                break; 
            case 8: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                break; 
            case 9: animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[i].position;
                i = 0;
                break; 
           
           
        }
        animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[animator.GetInteger("currentcheck") +1].position;
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
