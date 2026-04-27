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

    Transform Player; // 플레이어
    float distance; // 플레이어와의 거리

    private void Start()
    {
        // Player 컴포넌트로 찾은 플레이어의 Transform 컴포넌트 가져오기
        Player = FindObjectOfType<Player>().transform;
    }

    void Update()
    {

        // 적과 플레이어 사이의 거리 계산
        distance = Vector3.Distance(transform.position, Player.position);

        // 적과 플레이어 사이의 거리 출력
        print(distance);

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

    void Idle() // 기본 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 8 이하라면
        if (distance <= 8)
        {
            EState = EnemyState.Walk; // 이동 상태로 전환
        }
    }

    void Walk() // 이동 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 8보다 크다면
        if (distance > 8)
        {
            EState = EnemyState.Idle; // 기본 상태로 전환
        }
        //플레이어와의 거리가 2 이하라면
        else if (distance <= 2)
        {
            EState = EnemyState.Attack; // 공격 상태로 전환
        }
    }

    void Attack() // 공격 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 2 보다 크다면
        if(distance > 2)
        {
            EState = EnemyState.Walk; // 이동 상태로 전환
        }
    }
}
