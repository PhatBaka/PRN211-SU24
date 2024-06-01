using BusinessObjects;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmLogin : Form
    {
        private readonly IGenericRepository<Customer> _genericRepository;
        public frmLogin(IGenericRepository<Customer> genericRepository)
        {
            InitializeComponent();
            _genericRepository = genericRepository;
        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            var test = await _genericRepository.GetAllAsync();
        }
    }
}
