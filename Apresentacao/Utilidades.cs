using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaTransferencia;
using Domain;

namespace SqlMs
{
    class Utilidades
    {
        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox

                }
                if (item.GetType() == typeof(MaskedTextBox))
                {
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox

                }
            }
        }

        public void EnableForms(Control.ControlCollection controle)
        {
            foreach (Control item in controle)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Enabled = false; //limpa todos os controles do tipo TextBox
                  
                }
                if (item.GetType() == typeof(RadioButton))
                {
                    item.Enabled = false; //limpa todos os controles do tipo radio

                }
                if (item.GetType() == typeof(MaskedTextBox))
                {
                    item.Enabled = false; //limpa todos os controles do tipo TextBox

                }
                if (item.GetType() == typeof(DateTimePicker))
                {
                    item.Enabled = false; //limpa todos os controles do tipo TextBox

                }
                if (item.GetType() == typeof(ComboBox))
                {
                    item.Enabled = false; //limpa todos os controles do tipo TextBox

                }
                if (item.GetType() == typeof(NumericUpDown))
                {
                    item.Enabled = false; //limpa todos os controles do tipo TextBox

                }

                
            }
          
        }
     

    }
}
