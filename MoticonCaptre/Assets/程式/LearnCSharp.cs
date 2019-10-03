
using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    [Header("分數")]
    [Range(0,100)]
    public int score = 60;                       //整數
    [Header("速度"),Tooltip("可以放紅色與藍色藥水")]
    public float speed = 1.5f;                   //浮點數
    [Header("道具")]
    public string prop = "藥水";                 //字串
    [Header("任務")]
    public bool mission = false;                 //布林值

    public Vector2 v2 = new Vector2(7, 77);
    public Vector3 v3 = new Vector3(1, 2, 3);

    public Color blue = Color.blue;
    public Color red = new Color(0.7f,0.1f,0.2f);

    public AudioClip sound;
    public Camera cam;
    public Light lig;
    public Transform camPos;
    public GameObject obj;

    public Debug deb;


    private void Start()
    {
        //非靜態類別
        //Camera.depth = 10.5f;//
        cam.depth = 10.5f;

        //靜態類別
        Debug.Log("123");
    }
}
