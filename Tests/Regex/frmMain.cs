//-----------------------------------------------------------------
//   Name:              Regex tests
//   Date:              06.12.2018
//   Description:       Teste si ce que l'utilisateur a saisi s'agit d'un nombre entier positif
//   Author:            Mario Fereira
//   Notes:             <Notes>
//   Revision History:  
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Importation de la librairie qui permet d'utiliser les expressions régulières

namespace Tests_regex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAfficherNombre_Click(object sender, EventArgs e)
        {
            // Define a regular expression for repeated words.
            Regex regex = new Regex(@"^([1-9])+$", RegexOptions.Compiled);
	    MatchCollection matches = regex.Matches(tbxNumber.Text);

            if (matches.Count != 0) {
                // Report the number of matches found.
                lblMessage.Text = matches.Count + " matches found in : " + tbxNumber.Text;
            } else {
                lblMessage.Text = "Please enter positive ints";
            }
        }
    }
}
