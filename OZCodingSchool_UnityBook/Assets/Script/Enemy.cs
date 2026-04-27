using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100.0f; // 적의 체력


    void Start()
    {
        
    }

    void Update()
    {

    }
    
    void Damaged(float damage)
    {
        // 공격 받은 데미지만큼 체력 감소
        hp -= damage;
    }
}
