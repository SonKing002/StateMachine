using UnityEngine;

namespace Component
{
    public class State : MonoBehaviour
    {
        /// <summary>
        /// 공통적으로 사용하는
        /// </summary>
        protected PlayerStateController controller;
        /// <summary>
        /// 컴포넌트가 비활성화 -> 활성화로 변경 될 때, 1번 호출
        /// </summary>
        private void OnEnable()
        {
            if(controller == null)
            {
                controller = GetComponent<PlayerStateController>();
            }

            OnStateStart();//명확하게 명시함
        }

        /// <summary>
        /// 매 프레임 호출
        /// </summary>
        private void Update()
        {
            OnStateUpdate();
        }
        /// <summary>
        /// 컴포넌트가 활성화 -> 비활성화로 변경 될 때, 1번 호출
        /// </summary>
        private void OnDisable()
        {
            OnStateEnd();
        }

        //스테이트 관련 함수
        /// <summary>
        /// 스테이트 진입 함수
        /// </summary>
        protected virtual void OnStateStart()
        { 
        
        }

        /// <summary>
        /// 스테이트 업데이트 함수
        /// </summary>
        protected virtual void OnStateUpdate()
        { 
        
        }

        /// <summary>
        /// 스테이트 종료 함수
        /// </summary>
        protected virtual void OnStateEnd()
        { 
        
        }
    }
}

 