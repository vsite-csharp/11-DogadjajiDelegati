﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.DogađajiDelegati
{
    public partial class KodDvaBotuna : Form
    {
        public KodDvaBotuna()
        {
            InitializeComponent();
            // TODO:080 Pridružiti donja dva rukovatelja događajima Click tipki button i buttonMy

        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Botun obični");
        }

        private void ButtonMy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj botun");
        }

        // TODO:081 Napraviti klasu MyButton koja će biti izvedena iz klase Button, u njoj nadglasati virtualnu metodu OnClick te unutar metode dodati prikaz kontrole MessageBox

        // TODO:082 Promijeniti objekt buttonMy u formi tako da bude tipa MyButton, pokrenuti kod i provjeriti ponašanje tipke

        // TODO:083 U metodi OnClick klase MyButton zakomentirati poziv base.OnClick te provjeriti ponašanje tipke nakon toga.
    }
}
