using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication715 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            colorPickEdit1.ButtonClick += colorPickEdit1_ButtonClick;
        }

        void colorPickEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Caption != "MoreColors")
                return;
            ColorPickEdit edit = sender as ColorPickEdit;
            RepositoryItemColorPickEdit ritem = edit.Properties;
            try {
                ritem.LockEventsCore();
                using(FrmColorPicker frm = new FrmColorPicker(ritem)) {
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.SelectedColor = (Color)ritem.OwnerEdit.EditValue;
                    frm.TopMost = true;
                    if(frm.ShowDialog(ritem.OwnerEdit.FindForm()) == DialogResult.OK) {
                        ritem.OwnerEdit.EditValue = frm.SelectedColor;
                        //updating recent colors
                        ritem.RecentColors.InsertColor(frm.SelectedColor, 0);
                    }
                }
            } finally {
                ritem.ReleaseEventsCore(true);
            }
        }
    }
}
