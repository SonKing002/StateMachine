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
#region �ڷ�ƾ == �����ƾ
/* ��� ��Ģ���� ��Ƽ� ���� ����ϱ� ����
 * 1. ĳ���� ���� (ó���ð�)
 * 2. �ִϸ��̼� ���
 * 3. ������ ������ (ó���ð�)
 * 4. ���� ó�� 
 * ��ŸƮ�� �����Ʈ���� �ѹ� ĳ���ϰ� ����� �� : new WaitForSeconds(5f); ������ �÷��� ����� �ȴ�.
 * 
 * �̱� �����忡�� �ð��� �����ϴ� ������� ���ư���.
 * �ڷ�ƾ ���ÿ� �����Ͽ��� 3���� �Ϸķ� 
 * 
 * �ڷ�ƾ ��Ī�� ���� ������. => �����ƾ�̴�. (���� �Լ� ������� StartCoroutine()�� ��, return ���� ������ ������ �ִ´�.)
 * return �� ������ ������ ��� �ִٰ�, �߰��� �����ٰ� �ٽ� ������ ����̴�.
 */
#endregion