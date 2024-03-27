using UnityEngine;

namespace Component
{
    public class State : MonoBehaviour
    {
        /// <summary>
        /// ���������� ����ϴ�
        /// </summary>
        protected PlayerStateController controller;
        /// <summary>
        /// ������Ʈ�� ��Ȱ��ȭ -> Ȱ��ȭ�� ���� �� ��, 1�� ȣ��
        /// </summary>
        private void OnEnable()
        {
            if(controller == null)
            {
                controller = GetComponent<PlayerStateController>();
            }

            OnStateStart();//��Ȯ�ϰ� �����
        }

        /// <summary>
        /// �� ������ ȣ��
        /// </summary>
        private void Update()
        {
            OnStateUpdate();
        }
        /// <summary>
        /// ������Ʈ�� Ȱ��ȭ -> ��Ȱ��ȭ�� ���� �� ��, 1�� ȣ��
        /// </summary>
        private void OnDisable()
        {
            OnStateEnd();
        }

        //������Ʈ ���� �Լ�
        /// <summary>
        /// ������Ʈ ���� �Լ�
        /// </summary>
        protected virtual void OnStateStart()
        { 
        
        }

        /// <summary>
        /// ������Ʈ ������Ʈ �Լ�
        /// </summary>
        protected virtual void OnStateUpdate()
        { 
        
        }

        /// <summary>
        /// ������Ʈ ���� �Լ�
        /// </summary>
        protected virtual void OnStateEnd()
        { 
        
        }
    }
}

 