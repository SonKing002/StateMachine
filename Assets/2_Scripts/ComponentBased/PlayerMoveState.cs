using System;
using System.Diagnostics;
using UnityEngine;


namespace Component
{
    public class PlayerMoveState : State
    {
        public float moveSpeed = 3f;

        protected override void OnStateStart()
        {
            base.OnStateStart();

        }

        protected override void OnStateUpdate()
        {
            base.OnStateUpdate();
            //이동 로직
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.position += new Vector3(
                horizontal, 0f, vertical
                ) * moveSpeed * Time.deltaTime;
        }

        protected override void OnStateEnd()
        {
            base.OnStateEnd();
           // Debug.WriteLine("PlayerIdleState.OnStateEnd");//Debug.Log()
        }
    }
}
