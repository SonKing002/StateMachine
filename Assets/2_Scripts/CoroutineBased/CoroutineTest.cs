using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutine
{
    public class CoroutineTest : MonoBehaviour
    {
        WaitForSeconds onceSec;
        IEnumerator Start()
        {
            while (true)
            {
                Debug.Log("test");
            }
            yield return null;
        }
        IEnumerator CoroutineCaller()
        {
            yield return FunctionA();
            yield return FunctionB();
            yield return FunctionC();
        }

        IEnumerator FunctionA()
        {
            yield return onceSec;
        }
        IEnumerator FunctionB()
        {
            yield return new WaitForSeconds(3f);
        }
        IEnumerator FunctionC()
        {
            yield return new WaitForSeconds(5f);
        }
    }

}
#region 코루틴 == 서브루틴
/* 모든 규칙들을 모아서 순차 재생하기 위함
 * 1. 캐릭터 죽음 (처리시간)
 * 2. 애니메이션 재생
 * 3. 아이템 떨구기 (처리시간)
 * 4. 죽음 처리 
 * 스타트나 어웨이트에서 한번 캐싱하고 사용할 것 : new WaitForSeconds(5f); 가비지 컬렉터 대상이 된다.
 * 
 * 싱글 쓰레드에서 시간을 공유하는 방식으로 돌아간다.
 * 코루틴 동시에 실행하여도 3개가 일렬로 
 * 
 * 코루틴 명칭이 원래 없었다. => 서브루틴이다. (메인 함수 제어권을 StartCoroutine()일 때, return 받을 때까지 가지고 있는다.)
 * return 문 만나기 전까지 쥐고 있다가, 중간에 나갔다가 다시 들어오는 기법이다.
 */
#endregion