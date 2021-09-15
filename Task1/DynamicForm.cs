using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class DynamicForm : Form
    {
        Password password;

        public DynamicForm(Password pass)
        {
            InitializeComponent();
            GetPassword(pass);
        }

        private void DynamicForm_Load(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            int count = password.GetPassword().Length;
            for (int i = 0; i < count; i++)
                chart1.Series[0].Points.AddXY(i + 1, password.GetDynamicPressTimerList()[i]);
        }

        public void GetPassword(Password password)
        {
            this.password = password;
        }
    }
}
