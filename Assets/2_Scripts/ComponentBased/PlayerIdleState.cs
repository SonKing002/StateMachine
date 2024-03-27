using System;
using System.Diagnostics;

class Utils
{
    public static void Log(object message)
    {
#if UNITY_EDITOR_64
        Debug.WriteLine("dsfs");
        //메세지 출력 위치가 여기로 찍힘
#endif
    }
}

namespace Component
{
    public class PlayerIdleState : State
    {
        protected override void OnStateStart()
        {
            base.OnStateStart();
            Debug.WriteLine("PlayerIdleState.OnStateStart");
        }

        protected override void OnStateUpdate()
        {
            base.OnStateUpdate();
            Debug.WriteLine("PlayerIdleState.OnStateUpdate");
        }

        protected override void OnStateEnd()
        {
            base.OnStateEnd();
            Debug.WriteLine("PlayerIdleState.OnStateEnd");//Debug.Log()
        }
    }
}
