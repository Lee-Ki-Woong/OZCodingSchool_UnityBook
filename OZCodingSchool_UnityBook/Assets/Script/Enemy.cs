using UnityEngine;
using UnityEngine.UI; // UI 관련 클래스를 사용하기 위함
using UnityEngine.AI; // AI 관련 클래스를 사용하기 위함

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

    [SerializeField] private Transform Player; // 플레이어 및 플레이어의 컴포넌트 가져오기

    float distance; // 플레이어와의 거리
    NavMeshAgent agent; // NavMeshAgent 컴포넌트

    private void Start()
    {
        // 나의 NavMeshAgent 컴포넌트 가져오기
        agent = GetComponent<NavMeshAgent>();

        // 플레이어를 태그로 찾기
        var player = GameObject.FindGameObjectWithTag("Player");

        Player = player.transform;
    }

    void Update()
    {

        // 적과 플레이어 사이의 거리 계산
        distance = Vector3.Distance(transform.position, Player.position);

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

        agent.isStopped = true; // 이동 중단
        agent.ResetPath(); // 경로 초기화

        if(Hp >0) // 체력이 남아있다면
        {
            EState = EnemyState.Damaged; // 피격 상태로 전환
        }
        else // 체력이 남아있지 않다면
        {
            EState = EnemyState.Dead; // 죽음 상태로 전환
        }

        
    }

    void Idle() // 기본 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 8 이하라면
        if (distance <= 8)
        {
            EState = EnemyState.Walk; // 이동 상태로 전환
            agent.isStopped = false; // 이동 시작
        }
    }

    void Walk() // 이동 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 8보다 크다면
        if (distance > 8)
        {
            EState = EnemyState.Idle; // 기본 상태로 전환
            agent.isStopped = true; // 이동 중단
            agent.ResetPath(); // 경로 초기화
        }
        //플레이어와의 거리가 2 이하라면
        else if (distance <= 2)
        {
            EState = EnemyState.Attack; // 공격 상태로 전환
            agent.isStopped = true; // 이동 중단
            agent.ResetPath(); // 경로 초기화
        }
        // 다른 상태로 전환하지 않을 때는
        else
        {
            //플레이어의 위치를 목적지로 설정
            agent.SetDestination(Player.position);
        }
    }


    void Attack() // 공격 상태일 때 계속 할 일
    {
        // 플레이어와의 거리가 2 보다 크다면
        if(distance > 2)
        {
            EState = EnemyState.Walk; // 이동 상태로 전환
            agent.isStopped=false; // 이동 시작
        }
    }
}
