using System;
using System.Diagnostics;
using UnityEngine;

namespace Component
{
    public class PlayerStateController : MonoBehaviour
    {
        //
        public enum Estate
        { 
            Idle, Move,
        }

        /// <summary>
        /// 현재 스테이트 변수
        /// </summary>
        public Estate currentState = Estate.Idle;

        /// <summary>
        /// 스테이트 컴포넌트 배열
        /// </summary>
        public State[] states;

        /// <summary>
        /// 스테이트 변경 함수
        /// </summary>
        /// <param name="newState"></param>
        public void SetState(Estate newState)
        { 
            if( currentState == newState) 
            {
                return;
            }

            // 현재 스테이트 비활성화
            states[(int)currentState].enabled = false;
            // 새로 스테이트 활성화
            states[(int)newState].enabled = true;
            // 스테이트 업데이트
            currentState = newState;
        }

        /// <summary>
        /// 스테이트 변경처리
        /// (변경을 어디서 할 지에 대한 고민이 필요)
        /// </summary>
        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            if (h != 0f || v != 0f)
            {
                SetState(Estate.Move);
            }
            else
            {
                SetState(Estate.Idle);
            }
        }
    }
    
}
