using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnArrayOperation : MonoBehaviour
{
    public int[] students ={10,20,30,40,50,60,70,80,90};
    public Color[] colors = { Color.black, Color.blue };
    private void Start()
    {
        Debug.Log(students[6]);      //取得資料
        students[2] = 33;            //存取資料
        Debug.Log("學生陣列的長度:" + students.Length);           //陣列長度

        //數學運算子
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);

        //比較運算子
        Debug.Log(10 > 3);
        Debug.Log(10 < 3);
        Debug.Log(10 >= 3);
        Debug.Log(10 <= 3);
        Debug.Log(10 == 3);
        Debug.Log(10 != 3);

        if (students[0]>=60)
        {
            Debug.Log("你及格了");
        }
        else if (students[0] >= 50)
        {
            Debug.Log("你下次再來");
        }
        else
        {
            Debug.Log("你不及格");
        }
        
    }
    private void Update()
    {
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
    }
}
