using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Forms;
#endregion #usings
using DevExpress.XtraEditors;

namespace SearchFormExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            labelControl1.Text = "Search form uses the following mnemonics:\ndx for DevExpress, fn for function, fld for field, cl for class";
            myRichEditControl1.LoadDocument("RichEditAbout.rtf", DocumentFormat.Rtf);
        }

        private void btnShowSearchForm_Click(object sender, EventArgs e) {
            myRichEditControl1.ShowSearchForm();
        }
    }
    #region #searchformdescendant
    public class MyRichEditControl : RichEditControl {
        protected override SearchTextForm CreateSearchForm(SearchFormControllerParameters controllerParameters) {
            return new MySearchForm(controllerParameters);
        }
    }
    public partial class MySearchForm : SearchTextForm {
        public MySearchForm(SearchFormControllerParameters controllerParameters)
            : base(controllerParameters) {
            cbFndSearchString.Text = "Enter search text here";
            SubscribeToControlsEvents();
        }
        void SubscribeToControlsEvents() {
            this.cbFndSearchString.TextChanged += new EventHandler(OnSearchStringChanged);
            this.cbRplSearchString.TextChanged += new EventHandler(OnSearchStringChanged);
        }
    }
    #endregion #searchformdescendant

    public partial class MySearchForm : SearchTextForm {
        static Dictionary<string, string> patterns = CreatePatternsTable();

        static Dictionary<string, string> CreatePatternsTable() {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("dx", "DevExpress");
            result.Add("fn", "function");
            result.Add("fld", "field");
            result.Add("cl", "class");
            return result;
        }
        void OnSearchStringChanged(object sender, EventArgs e) {
            MRUEdit editor = sender as MRUEdit;
            if(patterns.ContainsKey(editor.Text))
                editor.Text = patterns[editor.Text];
        }
    }
}