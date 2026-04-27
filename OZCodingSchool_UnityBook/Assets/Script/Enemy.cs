using UnityEngine;
using UnityEngine.UI; // UI 관련 클래스를 사용하기 위함

public class Enemy : MonoBehaviour
{
    public Slider HpBar; // 적의 체력바
    public float Hp = 100.0f; // 적의 체력


    void Start()
    {
        
    }

    void Update()
    {

    }
    
    void Damaged(float damage)
    {
        // 공격 받은 데미지만큼 체력 감소
        Hp -= damage;

        // 감소한 체력을 체력바에 표시
        HpBar.value = Hp;

        if(Hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
