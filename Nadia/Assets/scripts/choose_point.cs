using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_point : StateMachineBehaviour
{

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Random.Range(0, 1) == 0)
        {
            animator.SetBool("cheat", true);
        }
        else
        {
            animator.SetBool("cheat", false);
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("cheat", false);
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
