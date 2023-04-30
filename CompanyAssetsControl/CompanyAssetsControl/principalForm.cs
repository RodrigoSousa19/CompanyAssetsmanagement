using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyAssetsControl
{
    public partial class principalForm : Form
    {
        public enum STEP_SET_EXECUTION
        {
            NONE,
            INITIALIZE,
            SHOW_SCREEN,
            FINISH
        }

        public STEP_SET_EXECUTION stepSet = STEP_SET_EXECUTION.INITIALIZE;

        public principalForm()
        {
            InitializeComponent();
        }

        public void Executar()
        {
            switch (stepSet)
            {
                case STEP_SET_EXECUTION.NONE:
                    {
                        break;
                    }
                case STEP_SET_EXECUTION.INITIALIZE:
                    {
                        break;
                    }
                case STEP_SET_EXECUTION.SHOW_SCREEN:
                    {
                        break;
                    }
                case STEP_SET_EXECUTION.FINISH:
                    {
                        break;
                    }
            }
        }

        private void tmrExecution_Tick(object sender, EventArgs e)
        {
            Executar();
        }
    }
}
