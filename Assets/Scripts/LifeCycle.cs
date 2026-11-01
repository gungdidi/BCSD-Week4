using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다. ");
    }

    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }
    private void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    void Update()
    {
        Debug.Log("몬스터 시냥");
    }

    private void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    private void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }


}

