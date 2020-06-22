using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl.EF;
using ListView = DevExpress.ExpressApp.ListView;
namespace Bells6.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ObjectViewControllerUsers : ObjectViewController<ListView, User>
    {
        public ObjectViewControllerUsers()
        {
            InitializeComponent();
            TargetObjectType = typeof(User);
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        protected override void OnActivated()
        {
            MessageBox.Show("Activated");
            base.OnActivated();

            // Perform various tasks depending on the target View.
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}