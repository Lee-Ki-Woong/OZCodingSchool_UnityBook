using UnityEngine;
using UnityEngine.UI; // UI 관련 클래스를 사용하기 위함

public class Enemy : MonoBehaviour
{
    // 적이 가질 수 있는 상태 목록
    public enum EnemyState
    {
        Idle,
        Walk,
        Attack,
        Damaged,
        Dead,
    }

    // 상태를 담을 변수를 만들고, 기본 상태로 시작
    public EnemyState EState = EnemyState.Idle;

    public Slider HpBar; // 적의 체력바
    public float Hp = 100.0f; // 적의 체력

    void Update()
    {
        // 기본, 이동, 공격 상태일 때 할 일 나누기
        switch (EState)
        {
            case EnemyState.Idle:
                {
                    Idle();
                }
                break;
            case EnemyState.Walk:
                {
                    Walk();
                }
                break;
            case EnemyState.Attack:
                {
                    Attack();
                }
                break;
        }
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

    void Idle()
    {

    }
    
    void Walk()
    {

    }

    void Attack()
    {

    }
}
