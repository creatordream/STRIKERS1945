using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //이동, 공격, 필살기, 호위함 집중공격?, 생명력(부활횟수), 
    public int speed = 3; // 이동 속도
    public float damage = 5f; //기본 데미지
    public float guardDamage = 3f; //호위함 데미지
    public float lethalDamage = 50f; //필살기 데미지



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); //좌우
        float v = Input.GetAxisRaw("Vertical"); //상하

        
    }
}
