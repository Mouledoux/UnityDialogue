using UnityEngine;
using UnityEngine.UI;

public class TalkingBox : MonoBehaviour
{
    Conversation.Conversation m_Dialogue = new Conversation.Conversation(@".\Assets\Conversation.txt");

    void Start()
    {
        Debug.Log(m_Dialogue.totalPhrases);
    }

    public Text textBox;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_Dialogue.currentIndex >= m_Dialogue.totalPhrases)
            {
                textBox.text = "";
                return;
            }
            textBox.text = m_Dialogue.GetCurrentNameAndPhrase();
            m_Dialogue.currentIndex++;
        }
    }
}