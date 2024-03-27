using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutine
{
    /// <summary>
    /// �ڷ�ƾ ����� ���¸ӽ�
    /// Ű���� ����Ű �Է��� ������� �̵��ϴ� ���
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        /// <summary>
        /// ������Ʈ (����)�� ��Ÿ���� �������� ����
        /// </summary>
        public enum EState
        { 
            Idle, Move
        }

        /// <summary>
        /// ���� ���¸� �����ϴ� �Լ�
        /// </summary>
        public EState currentState = EState.Idle;

        private void Awake()
        {
            StartCoroutine(RunStateMachine());//�Լ� �߰�
            //StartCoroutine("RunStateMachine") ���ڿ��� ȣ���ϸ�, ����Ƽ�� ������ �� ����,  StopCoroutine ���� ������ �� ����
        }
        private void Update()
        {
            //�Է� Ȯ�� �� �Է� ���� ������ Move ������ Idle ���·� ��ȯ
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            //�Է��� ������
            if (horizontal != 0 || vertical != 0)
            {
                SetState(EState.Move);
            }
            else//�Է��� ������
            {
                SetState(EState.Idle);
            }
                
        }

        //���� ���� ���� �Լ�
        public void SetState(EState newState)
        {
            //�����ϸ� �н�
            if (currentState == newState)
            {
                return;
            }

            //������Ʈ ���� ���ο� ������ ����
            currentState = newState;
        }
        //������Ʈ �ӽ� ���� �Լ�
        IEnumerator RunStateMachine()
        {
            while (true)
            { 
                yield return StartCoroutine(currentState.ToString());
            }
        }
        //Idle ���� �Լ�
        IEnumerator Idle()
        {
            do
            {
                yield return null;
            }
            while (currentState == EState.Idle);
        }
        //Move ���� �Լ�
        IEnumerator Move()
        {
            do 
            {
                yield return null;

                //�̵�
                transform.position += new Vector3(
                    Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")
                    ) * 3f * Time.deltaTime;//�ʴ� 3m �̵�

            }while(currentState == EState.Move);
        }
    }

}
