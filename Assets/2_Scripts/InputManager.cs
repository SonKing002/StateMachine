using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InputManager
{
    /// <summary>
    /// 뉴 인풋 시스템으로 전환할 때, 지엽적으로 파편화 되어있다면, 수정하기 어려워지기 때문에 입력관리자를 두어서 관리한다.
    /// </summary>
    public class InputManager : MonoBehaviour
    {
        public static float Horizontal { get; set; } = 0f;
        public static float Vertical { get; set; } = 0f;

        private void Update()
        {
            Horizontal = Input.GetAxis("Horizontal"); 
            Vertical = Input.GetAxis("Vertical");
        }

    }
}
