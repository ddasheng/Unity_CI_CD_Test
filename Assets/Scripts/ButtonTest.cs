using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ns
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonTest : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public void OnClick()
        {
            float time = Time.time;
            string s = time.ToString();
            Debug.Log("123");
            text.text = s;
        }
    }
}
