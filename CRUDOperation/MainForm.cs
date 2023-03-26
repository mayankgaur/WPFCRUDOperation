using System;
using System.Windows.Forms;

namespace CRUDOperation
{
    public partial class MainForm : Form
    {
        private readonly IDataService dataService;
        private readonly ILoaderService loaderService;
        private readonly IUserService userService;

        public MainForm(IDataService dataService, ILoaderService loaderService, IUserService userService)
        {
            InitializeComponent();

            this.dataService = dataService;
            this.loaderService = loaderService;
            this.userService = userService;

            dgvData.DataSource = dataService.GetData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PerformDatabaseOperation(dataService.CreateData);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            PerformDatabaseOperation(dataService.ReadData);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PerformDatabaseOperation(dataService.UpdateData);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PerformDatabaseOperation(dataService.DeleteData);
        }

        private void PerformDatabaseOperation(Action operation)
        {


            // Display loader
            loaderService.ShowLoader();

            // Perform operation here
            operation();

            // Hide loader
            loaderService.HideLoader();

            // Refresh data
            dgvData.DataSource = dataService.GetData();
        }
    }
}
