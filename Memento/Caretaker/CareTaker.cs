using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class CareTaker
    {
        Stack<IMemento> _undoStack = new Stack<IMemento>();
        Stack<IMemento> _redoStack = new Stack<IMemento>();

        public int UndoCount { get { return _undoStack.Count; } }
        public int RedoCount { get { return _redoStack.Count; } }

        public CareTaker()
        {
            // add a null object to stack
            _undoStack.Push(new NullObject());
            _redoStack.Push(new NullObject());

        }

        public IMemento Undo()
        {
            // jos undostäkki on tyhjä, abort
            // kun undo tehdään, niin undostäkistä popataan memento, ja pushataan se redostäkkiin
            if (_undoStack.Count > 1)
            {
                // discard current state, and push it to redo-stack
                _redoStack.Push(_undoStack.Pop());
            }
            var m = _undoStack.Peek();

            return m;
        }

        public IMemento Redo()
        {
            // jos redostäkki on tyhjä, abort

            // aina kun tehdään redo, niin undostäkkiin laitetaan ennen redoa oleva state, siis nykyinen state

            if (_redoStack.Count > 1)
            {
                var m = _redoStack.Pop();
                // current state to undo-stack
                _undoStack.Push(_undoStack.Peek());
                return m;
            }
            else return null;
        }

        public IMemento Memento { get; set; }

        public void StoreState(IMemento memento)
        {
            _undoStack.Push(memento);
        }

        public IMemento GetMemento()
        {
            if (_undoStack.Count > 1)
            {
                // discard current state
                _undoStack.Pop();
            }
            var m = _undoStack.Peek();

            return m;
        }       
    }
}
