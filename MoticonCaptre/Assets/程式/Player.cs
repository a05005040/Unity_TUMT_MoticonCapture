using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator Robot;
    bool M_dance = false;            //跳舞
    private void Start()
    {
        Robot = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Robot.SetTrigger("跳舞觸發器");
        }
        Robot.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }
}
