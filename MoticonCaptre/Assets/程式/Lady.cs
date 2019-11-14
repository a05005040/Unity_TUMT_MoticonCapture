
using UnityEngine;

public class Lady : MonoBehaviour
{
    private Animator ani;
    private Rigidbody rig;
    [Header("動畫控制器:參數名稱")]
    public string parRun = "跑步開關";
    public string parAtk = "攻擊觸發";
    public string parDam = "受傷觸發";
    public string parJump = "跳躍觸發";
    public string parDead = "死亡開關";

    [Header("速度"), Range(0f, 80f)]
    public float speed = 1.5f;
    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Walk();
        Attack();
        Jump();
    }

    /// <summary>
    /// 走路
    /// </summary>
    void Walk()
    {
        ani.SetBool(parRun, Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
        //rig.AddForce(0, 0, Input.GetAxisRaw("Vertical") * speed);             // 以世界座標移動
        rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed); // 以區域座標移動
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger(parAtk);
        }
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger(parJump);
        }
    }
    /// <summary>
    /// 受傷
    /// </summary>
    void Hurt()
    {
        ani.SetTrigger(parDam);
    }
    /// <summary>
    /// 死亡
    /// </summary>
    void Dead()
    {
        ani.SetBool(parDead, true);

    }

}
