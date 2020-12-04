using Xamarin.Forms;

namespace DataForm_CustomAppearance {
    public partial class MainPage : ContentPage {
        EmployeeRepository repository = new EmployeeRepository();

        public MainPage() {
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            InitializeComponent();
            dataForm.DataObject = repository.Get(0);
        }
    }
}
