using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADKT_SellsWatch.ColorChange
{
    class ChangeColor
    {
        Form activeForm = new Form();
        Random random = new Random();
        private void ResetColorButton(Panel pnlLeft)
        {
            foreach (IconButton item in pnlLeft.Controls.OfType<IconButton>())
            {
                item.BackColor = pnlLeft.BackColor;
                item.Enabled = true;
            }
        }
        public void OpenChildForm(Form childForm, Panel pnlContent, Panel pnlLeft, IconButton button)
        {
            string rgb = RandomColor();
            if (activeForm != null)
            {
                ResetColorButton(pnlLeft);
                activeForm.Close();
            }
            activeForm = childForm;
            button.BackColor = Color.FromName(rgb);
            button.Enabled = false;
            childForm.BackColor = Color.FromName(rgb);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public string RandomColor()
        {
            String[] color =
            {
                "AliceBlue",
                "Aqua",
                "Brown",
                "DarkCyan",
                "Cornsilk",
                "Chocolate",
                "DarkOrange",
                "DimGray",
                "Cyan",
                "Chartreuse",
                "DeepPink",
                "CadetBlue"
            };
            List<String> ColorList = new List<String>();
            ColorList.AddRange(color);
            int temp = random.Next(0, ColorList.Count);
            return ColorList[temp].ToString();
        }

    }
}
