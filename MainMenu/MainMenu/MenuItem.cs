using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItem
{
    class MenuItem
    {
        private string m_Name;
        private Delegate m_Function;
        private List<MenuItem> m_SubMenues;

        private MenuItem m_Parent;

        public MenuItem(string i_Name, Delegate i_Function, List<MenuItem> i_Submenues, MenuItem i_Parent)
        {
            this.m_Name = i_Name;
            this.m_SubMenues = i_Submenues;
            this.m_Function = i_Function;
            this.m_Parent = i_Parent;
        }



        public override string ToString()
        {
            return m_Name.ToString();
        }
    }
}
