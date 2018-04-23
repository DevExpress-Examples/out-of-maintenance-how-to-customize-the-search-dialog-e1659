using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors;

namespace SearchFormExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            labelControl1.Text = "Search form uses the following mnemonics:\ndx for DevExpress, fn for function, fld for field, cl for class";
            myRichEditControl1.LoadDocument("RichEditAbout.rtf",DocumentFormat.Rtf);
        }

        private void btnShowSearchForm_Click(object sender, EventArgs e) {
            myRichEditControl1.ShowSearchForm();
        }
    }

    public class MyRichEditControl : RichEditControl {
        protected override SearchTextForm CreateSearchForm(SearchFormActivePage activePage) {
            return new MySearchForm(this, activePage);
        }
    }
    public class MySearchForm : SearchTextForm {
        static Dictionary<string, string> patterns = CreatePatternsTable();

        static Dictionary<string, string> CreatePatternsTable() {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("dx", "DevExpress");
            result.Add("fn", "function");
            result.Add("fld", "field");
            result.Add("cl", "class");
            return result;
        }
        public MySearchForm(RichEditControl control, SearchFormActivePage activePage)
            : base(control, activePage) {
            cbFndSearchString.Text = "Enter search text here";
            SubscribeToControlsEvents();
        }

        void SubscribeToControlsEvents() {
            this.cbFndSearchString.TextChanged += new EventHandler(OnSearchStringChanged);
            this.cbRplSearchString.TextChanged += new EventHandler(OnSearchStringChanged);
        }
        void OnSearchStringChanged(object sender, EventArgs e) {
            MRUEdit editor = sender as MRUEdit;
            if (patterns.ContainsKey(editor.Text))
                editor.Text = patterns[editor.Text];
        }
    }
}