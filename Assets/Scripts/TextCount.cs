using UnityEngine;
using UnityEngine.UI;
public class TextCount : MonoBehaviour
{
    public Text m_Text;
    private int m_Count = 0;

    private void Start()
    {
        m_Text.text = "Count : 0";
    }

    public void AddCount()
    {
        m_Count++;
        m_Text.text = "Count : " + m_Count.ToString();
    }
}
