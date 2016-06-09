namespace Conversation
{
    public class Conversation
    {
        public Conversation(string a_FilePath)
        {
            lines = new System.Collections.Generic.List<string>();
            foreach (string s in System.IO.File.ReadAllLines(a_FilePath))
            {
                if (!s.Contains(@"//") && s.Length > 0)
                {
                    lines.Add(s);
                }
            }
            currentIndex = 0;
            totalPhrases = lines.Count/2;
        }

        public string GetCurrentNameAndPhrase()
        {
            string output = GetCurrentPersonSpeaking() + "\n" +
                            GetCurrentPhrase();
            return output;
        }

        public string GetCurrentPersonSpeaking()
        {
            return lines[currentIndex * 2];
        }

        public string GetCurrentPhrase()
        {
            return lines[(currentIndex * 2) + 1];
        }

        private System.Collections.Generic.List<string> lines;
        public int currentIndex;
        public int totalPhrases;
    }
}