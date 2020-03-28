using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_MergeSort
{
    public partial class FrmMergeSort : Form
    {
        public FrmMergeSort()
        {
            InitializeComponent();
        }

        private void FrmMergeSort_Load(object sender, EventArgs e)
        {

        }

        private void BtnMergeSort_Click(object sender, EventArgs e)
        {

            string[] strInput = new string[LbxInput.Items.Count];
            string[] strOutput = new string[LbxInput.Items.Count];

            // The following loop transfers the values
            // from the input LISTBOX (LbxInput)
            // into a STRING array (strInput[]).
            for (int i = 0; i <= LbxInput.Items.Count - 1; i++)
            {
                strInput[i] = LbxInput.Items[i].ToString();
            }

            MergeSort(strInput, ref strOutput);

            // The following loop transfers the values
            // from the output array (strOutput[]) of the MergeSort method
            // into the output LISTBOX (LbxOutput).
            for (int i = 0; i <= LbxInput.Items.Count - 1; i++)
            {
                LbxOutput.Items.Add(strOutput[i]);
            }

        }

        private void MergeSort(string[] inputArray, ref string[] outputArray)
        {

            // Replace the following 3 lines of code
            // to perform the Merge Sort
            // and store the output into the outputArray[]

            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = inputArray[i].ToLower();
            }

        }

    }
}
