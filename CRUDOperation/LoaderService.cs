using System.Windows.Forms;

namespace CRUDOperation
{
    public class LoaderService : ILoaderService
    {
        private readonly Form form;
        private readonly Control control;

        public LoaderService(Form form, Control control)
        {
            this.form = form;
            this.control = control;
        }

        public void ShowLoader()
        {
            // Show loader on the specified control
            // This could be implemented using a progress bar, a loading animation, or any other visual indication of loading
            // For the purposes of this example, we'll simply disable the control
            control.Enabled = false;
        }

        public void HideLoader()
        {
            // Hide loader on the specified control
            // For the purposes of this example, we'll simply enable the control
            control.Enabled = true;
        }
    }
}
