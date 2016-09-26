using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_NotaGame
{
    public partial class FormCRUDUser : Form
    {
        private char c = 'c';
        private int indice = -1;

        /// <summary>
        /// constructeur FormCRUDUser 
        /// </summary>
        /// <param name="action">c : en creation, u : en update</param>
        public FormCRUDUser(char action)
        {
            InitializeComponent();
            c = action;
        }

    }
}
