using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace BanHangNoiThat.Forms.UsersControl
{
    public partial class UserSale : UserControl
    {
        public List<BunifuImageButton> listimageSale = new List<BunifuImageButton>();
        public List<Label> listLableSale = new List<Label>();
        public UserSale()
        {
            InitializeComponent();
            Addimage();
            Addlable();
            loadimage();
        }
        public void Addimage()
        {
            listimageSale.Add(imagespSale1);
            listimageSale.Add(imagespSale2);
            listimageSale.Add(imagespSale3);
            listimageSale.Add(imagespSale4);
            listimageSale.Add(imagespSale5);
            listimageSale.Add(imagespSale6);
            listimageSale.Add(imagespSale7);
            listimageSale.Add(imagespSale8);
        }
        public void Addlable()
        {
            listLableSale.Add(tenspSale1);
            listLableSale.Add(tenspSale2);
            listLableSale.Add(tenspSale3);
            listLableSale.Add(tenspSale4);
            listLableSale.Add(tenspSale5);
            listLableSale.Add(tenspSale6);
            listLableSale.Add(tenspSale7);
            listLableSale.Add(tenspSale8);
        }
        void loadimage()
        {
            for (int index = 0; index < 8; index++)
            { 
                listimageSale[index].Image = Image.FromFile("C:\\Users\\BUI\\Pictures\\Saved Pictures\\SP02.jpg");
            }

        }
        private void UserSale_Load(object sender, EventArgs e)
        {

        }
    }
}
