using System;
using System.ComponentModel;

namespace ToDoApp.Models
{
    public class TodoModel : INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _text;

        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;    
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
