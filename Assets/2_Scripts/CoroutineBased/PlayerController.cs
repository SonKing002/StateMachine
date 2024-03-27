using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutine
{
    /// <summary>
    /// 코루틴 기반의 상태머신
    /// 키보드 방향키 입력을 기반으로 이동하는 기능
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        /// <summary>
        /// 스테이트 (상태)를 나타내는 열거형의 정의
        /// </summary>
        public enum EState
        { 
            Idle, Move
        }

        /// <summary>
        /// 현재 상태를 저장하는 함수
        /// </summary>
        public EState currentState = EState.Idle;

        private void Awake()
        {
            StartCoroutine(RunStateMachine());//함수 추가
            //StartCoroutine("RunStateMachine") 문자열로 호출하면, 유니티가 저장할 수 있음,  StopCoroutine 으로 정지할 수 있음
        }
        private void Update()
        {
            //입력 확인 후 입력 값이 있으면 Move 없으면 Idle 상태로 전환
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            //입력이 있으면
            if (horizontal != 0 || vertical != 0)
            {
                SetState(EState.Move);
            }
            else//입력이 없으면
            {
                SetState(EState.Idle);
            }
                
        }

        //상태 변경 제어 함수
        public void SetState(EState newState)
        {
            //동일하면 패스
            if (currentState == newState)
            {
                return;
            }

            //스테이트 값을 새로운 값으로 변경
            currentState = newState;
        }
        //스테이트 머신 실행 함수
        IEnumerator RunStateMachine()
        {
            while (true)
            { 
                yield return StartCoroutine(currentState.ToString());
            }
        }
        //Idle 상태 함수
        IEnumerator Idle()
        {
            do
            {
                yield return null;
            }
            while (currentState == EState.Idle);
        }
        //Move 상태 함수
        IEnumerator Move()
        {
            do 
            {
                yield return null;

                //이동
                transform.position += new Vector3(
                    Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")
                    ) * 3f * Time.deltaTime;//초당 3m 이동

            }while(currentState == EState.Move);
        }
    }

}
