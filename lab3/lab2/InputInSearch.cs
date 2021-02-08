using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class InputInSearch : Form
    {
        public SearchForm searchForm;

        public InputInSearch(SearchForm form)
        {
            InitializeComponent();
            searchForm = form;
            searchForm.Enabled = false;
        }

        private void SearchInputButton_Click(object sender, EventArgs e)
        {
            if (SearchInputTextBox.Text != "" && SearchInputTextBox.Text != " ")
            {
                searchForm.textFromInputInSearch = SearchInputTextBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Глупо искать записи по пустой строке/пробелу, попробуй ещё!", "Поиск завершился неудачей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InputInSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchForm.Enabled = true;
        }
    }
}
