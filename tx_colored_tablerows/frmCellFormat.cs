using System;
using System.Drawing;
using System.Windows.Forms;
using static CellFilterInstructions;

namespace tx_colored_tablerows
{
    public partial class frmCellFormat : Form
    {
        // ** MEMBER VARIABLES
        private CellFilterInstructions m_CellFilterInstructions;

        // ** PROPERTIES
        public CellFilterInstructions CellFilterInstructions
        {
            get { return m_CellFilterInstructions; }
            set { m_CellFilterInstructions = value; }
        }

        public frmCellFormat()
        {
            InitializeComponent();
        }

        private void frmCellFormat_Load(object sender, EventArgs e)
        {
            cbOperator.Items.AddRange(Enum.GetNames(typeof(RelationalOperator)));
            UpdateControls();
        }

        // updates the visual controls to reflect changes
        private void UpdateControls()
        {
            if (m_CellFilterInstructions.Operator == null)
                cbOperator.SelectedIndex = -1;
            else
                cbOperator.SelectedItem = m_CellFilterInstructions.Operator.ToString();

            pnlTrueColor.BackColor = m_CellFilterInstructions.TrueColor;
            pnlFalseColor.BackColor = m_CellFilterInstructions.FalseColor;
            tbCompareValue.Text = m_CellFilterInstructions.CompareValue.ToString();
        }

        #region "Events"

        private void btnTrueColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                m_CellFilterInstructions.TrueColor = colorDialog1.Color;
                UpdateControls();
            }
        }

        private void btnFalseColor_Clickbutton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                m_CellFilterInstructions.FalseColor = colorDialog1.Color;
                UpdateControls();
            }
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperator.SelectedItem != null)
            {
                Enum.TryParse(cbOperator.SelectedItem.ToString(), out RelationalOperator selectedOperator);
                m_CellFilterInstructions.Operator = selectedOperator;
            }
        }

        private void tbCompareValue_TextChanged(object sender, EventArgs e)
        {
            // set the instructions
            if(tbCompareValue.Text != "")
                m_CellFilterInstructions.CompareValue = Double.Parse(tbCompareValue.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // close the dialog
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            m_CellFilterInstructions = new CellFilterInstructions();
            UpdateControls();
        }
    }
}

