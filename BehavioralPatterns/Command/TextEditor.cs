using System;
using System.Text;

namespace BehavioralPatterns.Command
{
    public class TextEditor
    {
        private StringBuilder _content = new StringBuilder();

        public string Content => _content.ToString();

        public void Write(string text)
        {
            _content.Append(text);
        }

        public void Delete(int length)
        {
            if (_content.Length >= length)
            {
                _content.Remove(_content.Length - length, length);
            }
        }

        public void Display()
        {
            Console.WriteLine(_content.ToString());
        }
    }
}