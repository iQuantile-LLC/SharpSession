using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionManager;
using static SessionManager.SharpSession;

namespace TestApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SessionStart();
            Session["A"] = 5;
            int x = Get<int>("A");
            SessionReset();
            dynamic y =  Session["A"];
            

        }
    }
}
