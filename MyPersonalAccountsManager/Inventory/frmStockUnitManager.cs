using System.Windows.Forms;

namespace com.techphernalia.MyPersonalAccounts.Manager.Inventory
{
    public partial class frmStockUnitManager : Form
    {
        public frmStockUnitManager()
        {
            InitializeComponent();
        }

        private void frmStockUnitManager_Load(object sender, System.EventArgs e)
        {
            var stockUnits = ServiceInteractor.GetApplicationController().GetAllStockUnits();
            dgStockUnits.DataSource = stockUnits;
            dgStockUnits.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Update", Text = "Update", UseColumnTextForButtonValue = true, Name = "Update", DisplayIndex = 0 });
            dgStockUnits.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Delete", Text = "Delete", UseColumnTextForButtonValue = true , Name="Delete", DisplayIndex = 1});
        }

        private void dgStockUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
