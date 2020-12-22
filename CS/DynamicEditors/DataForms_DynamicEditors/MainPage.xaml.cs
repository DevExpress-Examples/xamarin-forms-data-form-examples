using System.Collections.Generic;
using DevExpress.XamarinForms.DataForm;
using Xamarin.Forms;
using System;

namespace DataForms_DynamicEditors {
    public partial class MainPage : ContentPage {
        Dictionary<string, object> dataModel = new Dictionary<string, object>();
        public MainPage() {
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            InitializeComponent();

            dataForm.IsAutoGenerationEnabled = false;
            dataForm.CommitMode = CommitMode.PropertyChanged;
            dataForm.DataObject = dataModel;
        }

        private void Button_Clicked(object sender, EventArgs e) {
            string editorName = $"Email {dataModel.Count}";
            object editorValue = "Test";

            var dataformItem = new DataFormTextItem { FieldName = editorName };

            dataModel.Add(dataformItem.FieldName, editorValue);
            dataForm.Items.Add(dataformItem);
        }
    }
}
