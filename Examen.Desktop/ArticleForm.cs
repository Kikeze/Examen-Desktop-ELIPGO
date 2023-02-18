using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Examen.Data.DTO;
using Examen.Data.Models;
using Examen.Desktop.Providers;

namespace Examen.Desktop
{
    public partial class ArticleForm : Form
    {
        public bool IsEditMode = false;
        public int ArticleId = 0;
        public bool DoRefresh = false;

        private ArticleDTO oArticle = null;

        #region Contructor de la clase

        public ArticleForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos del formulario

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            LoadStoreCombo();
            ShowEditMode();
        }

        #endregion

        #region Eventos de los controles del formulario

        private void butArticleSave_Click(object sender, EventArgs e)
        {
            SaveArticle();

            DoRefresh = true;
            this.Hide();
        }

        private void butArticleCancel_Click(object sender, EventArgs e)
        {
            DoRefresh = false;
            this.Hide();
        }

        #endregion

        #region Funciones y subrutinas de uso exclusivo del formulario

        private void LoadStoreCombo()
        {
            StoresProvider oProvider = new StoresProvider();
            cmbArticleStore.DataSource = oProvider.GetStores();
        }

        private void ShowEditMode()
        {
            if (IsEditMode)
            {
                lblArticleEditing.Text = "Edit Article";

                LoadArticle();
            }
            else
            {
                lblArticleEditing.Text = "Create New Article";

                txtArticleId.Text = "";
                cmbArticleStore.SelectedIndex = 0;
                txtArticleName.Text = "";
                txtArticleDescription.Text = "";
                txtArticlePrice.Text = "0.0";
                txtArticleShelf.Text = "0";
                txtArticleVault.Text = "0";
            }
        }

        private void LoadArticle()
        {
            ArticlesProvider oProvider = new ArticlesProvider();
            oArticle = oProvider.GetArticle(ArticleId);

            txtArticleId.Text = $"{oArticle.Id}";
            cmbArticleStore.SelectedValue = oArticle.Store_Id;
            txtArticleName.Text = oArticle.Name;
            txtArticleDescription.Text = oArticle.Description;
            txtArticlePrice.Text = $"{oArticle.Price}";
            txtArticleShelf.Text = $"{oArticle.Total_In_Shelf}";
            txtArticleVault.Text = $"{oArticle.Total_In_Vault}";
        }

        private void SaveArticle()
        {
            ArticlesProvider oProvider = new ArticlesProvider();

            if (IsEditMode)
            {
                var oEdited = new Article()
                {
                    Id = oArticle.Id,
                    Name = txtArticleName.Text,
                    Description = txtArticleDescription.Text,
                    Price = GetDouble(txtArticlePrice.Text),
                    Total_In_Shelf = GetInteger(txtArticleShelf.Text),
                    Total_In_Vault = GetInteger(txtArticleVault.Text),
                    Store = new Store() { Id = (int)cmbArticleStore.SelectedValue }
                };

                oProvider.UpdateArticle(oEdited);
            }
            else
            {
                var oNew = new Article()
                {
                    Name = txtArticleName.Text,
                    Description = txtArticleDescription.Text,
                    Price = GetDouble(txtArticlePrice.Text),
                    Total_In_Shelf = GetInteger(txtArticleShelf.Text),
                    Total_In_Vault = GetInteger(txtArticleVault.Text),
                    Store = new Store() { Id = (int)cmbArticleStore.SelectedValue }
                };

                oProvider.InsertArticle(oNew);
            }

        }

        private int GetInteger(string Source)
        {
            try
            {
                int nRet = int.Parse(Source);
                return nRet;
            }
            catch
            {
                return 0;
            }
        }

        private double GetDouble(string Source)
        {
            try
            {
                double nRet = double.Parse(Source);
                return nRet;
            }
            catch
            {
                return 0;
            }
        }

        #endregion

    }
}
