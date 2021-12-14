using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class RoleStateCaretaker
    {
        private RoleStateMemento memento;

        internal RoleStateMemento Memento { get => memento; set => memento = value; }
    }
}
