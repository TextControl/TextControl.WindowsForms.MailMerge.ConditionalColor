using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tx_colored_tablerows
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            // merge the template with JSON data
            using (TXTextControl.DocumentServer.MailMerge mailMerge = new TXTextControl.DocumentServer.MailMerge())
            {
                mailMerge.TextComponent = textControl1;
                mailMerge.FieldMerged += MailMerge_FieldMerged;

                string data = File.ReadAllText("data.json");
                mailMerge.MergeJsonData(data, false);
            }
        }

        private void MailMerge_FieldMerged(object sender, TXTextControl.DocumentServer.MailMerge.FieldMergedEventArgs e)
        {
            // custom field handling
            if (e.TableCell == null)
                return;

            // if TableCell.Name has instructions, create a CellFilterInstructions object
            // and evaluate the instructions and set the table cell color
            if (e.TableCell.Name != "")
            {
                CellFilterInstructions instructions = (CellFilterInstructions)JsonConvert.DeserializeObject(e.TableCell.Name, typeof(CellFilterInstructions));

                // retrieve the color
                Color? color = instructions.GetColor(e.MailMergeFieldAdapter.ApplicationField.Text);

                // apply the color
                if(color != null)
                    e.TableCell.CellFormat.BackColor = (Color)color;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load the template
            textControl1.Load("template.tx", TXTextControl.StreamType.InternalUnicodeFormat);
            btnMerge.Enabled = true;
        }

        private void btnSetConditions_Click(object sender, EventArgs e)
        {
            // create a new dialog form
            frmCellFormat frmCellFormat = new frmCellFormat();

            // check, if there are existing filter instructions
            CellFilterInstructions cellFilterInstructions = 
                (CellFilterInstructions)JsonConvert.DeserializeObject(
                    textControl1.Tables.GetItem().Cells.GetItem().Name, 
                    typeof(CellFilterInstructions));

            if (cellFilterInstructions == null)
            {
                // create new instructions
                Color cCellBackColor = textControl1.Tables.GetItem().Cells.GetItem().CellFormat.BackColor;

                cellFilterInstructions = new CellFilterInstructions()
                {
                    TrueColor = cCellBackColor,
                    FalseColor = cCellBackColor
                };
            }

            // show the form
            frmCellFormat.CellFilterInstructions = cellFilterInstructions;

            if (frmCellFormat.ShowDialog() == DialogResult.OK)
            {
                // save the instructions in the Name property
                textControl1.Tables.GetItem().Cells.GetItem().Name = JsonConvert.SerializeObject(frmCellFormat.CellFilterInstructions); 
            }
        }

        private void textControl1_InputPositionChanged(object sender, EventArgs e)
        {
            btnSetConditions.Enabled = textControl1.Tables.GetItem() != null ? true : false;
        }
    }
}
