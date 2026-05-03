using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class lazerBlue : Lazer
    {
        public override void CreateLazer(Form form)
        {

            CurrentLazer.BackgroundImage = WindowsFormsApp1.Properties.Resources.lazer2;




            CurrentLazer.Tag = "playerLazer";
            CurrentLazer.BackColor = Color.Transparent;

            base.CreateLazer(form);

        }
    }
}

