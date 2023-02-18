using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Examen.Data.Models;
using Examen.Desktop.Providers;

namespace Examen.Desktop
{
    public partial class StoreForm : Form
    {
        public bool IsEditMode = false;
        public int StoreId = 0;
        public bool DoRefresh = false;

        private Store oStore = null;

        #region Constructor de la clase

        public StoreForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos del formulario

        private void StoreForm_Load(object sender, EventArgs e)
        {
            ShowEditMode();
        }

        #endregion

        #region Eventos de los controles del formulario

        private void butStoreSave_Click(object sender, EventArgs e)
        {
            SaveStore();

            DoRefresh = true;
            this.Hide();
        }

        private void butStoreCancel_Click(object sender, EventArgs e)
        {
            DoRefresh = false;
            this.Hide();
        }

        #endregion

        #region Funciones y subrutinas de uso exclusivo del formulario

        private void ShowEditMode()
        {
            if(IsEditMode)
            {
                lblStoreEditing.Text = "Edit Store";

                LoadStore();
            }
            else
            {
                lblStoreEditing.Text = "Create New Store";

                txtStoreId.Text = "";
                txtStoreName.Text = "";
                txtStoreAddress.Text = "";
            }
        }

        private void LoadStore()
        {
            StoresProvider oProvider = new StoresProvider();
            oStore = oProvider.GetStore(StoreId);

            txtStoreId.Text = $"{oStore.Id}";
            txtStoreName.Text = oStore.Name;
            txtStoreAddress.Text = oStore.Address;
        }

        private void SaveStore()
        {
            StoresProvider oProvider = new StoresProvider();

            if (IsEditMode)
            {
                var oEdited = new Store()
                {
                    Id = oStore.Id,
                    Name = txtStoreName.Text,
                    Address = txtStoreAddress.Text
                };

                oProvider.UpdateStore(oEdited);
            }
            else
            {
                var oNew = new Store()
                {
                    Name = txtStoreName.Text,
                    Address = txtStoreAddress.Text
                };

                oProvider.InsertStore(oNew);
            }
        }

        #endregion

    }
}
