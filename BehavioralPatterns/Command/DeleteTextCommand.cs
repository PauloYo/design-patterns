namespace BehavioralPatterns.Command
{
    public class DeleteTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly int _length;
        private string _deletedText;

        public DeleteTextCommand(TextEditor editor, int length)
        {
            _editor = editor;
            _length = length;
        }

        public void Execute()
        {
            var content = _editor.Content;
            if (content.Length >= _length)
            {
                _deletedText = content.Substring(content.Length - _length);
                _editor.Delete(_length);
            }
        }

        public void Undo()
        {
            if (!string.IsNullOrEmpty(_deletedText))
            {
                _editor.Write(_deletedText);
            }
        }
    }
}