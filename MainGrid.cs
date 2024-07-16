using System.Data;
using TimeClock.DAL;

namespace familiyGrid
{
    public partial class MainGrid : Form
    {
        public MainGrid()
        {
            InitializeComponent();
        }

        private void MainGrid_Load(object sender, EventArgs e)
        {
            string query = "select * from details";
            dataGridView_main.DataSource = DbContext.MakeQuery(query);
        }
    }
}
