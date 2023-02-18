using Examen.Data.Models;
using Examen.Desktop.Providers;

namespace Examen.Desktop
{
    public partial class MainForm : Form
    {
        private bool IsLoading = false;

        #region Constructor de la clase

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos del formulario

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        #endregion

        #region Eventos de los controles del formulario

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butStoreRefresh_Click(object sender, EventArgs e)
        {
            LoadStoresGrid();
        }

        private void butStoreNew_Click(object sender, EventArgs e)
        {
            StoreForm oForm =new StoreForm();
            oForm.IsEditMode = false;
            oForm.ShowDialog();

            if (oForm.DoRefresh)
            {
                LoadStoresGrid();
            }

            oForm.Close();
        }

        private void butStoreEdit_Click(object sender, EventArgs e)
        {
            if (dgvStores.SelectedRows.Count <= 0)
            {
                return;
            }

            int nId = (int)dgvStores.SelectedRows[0].Cells[0].Value;
            StoreForm oForm = new StoreForm();
            oForm.IsEditMode = true;
            oForm.StoreId = nId;
            oForm.ShowDialog();

            if (oForm.DoRefresh)
            {
                LoadStoresGrid();
            }

            oForm.Close();
        }

        private void butStoreDelete_Click(object sender, EventArgs e)
        {
            if (dgvStores.SelectedRows.Count <= 0)
            {
                return;
            }

            int nId = (int)dgvStores.SelectedRows[0].Cells[0].Value;
            DialogResult oRes = MessageBox.Show($"Delete Store {nId}?", "DETELE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(oRes == DialogResult.Yes)
            {
                StoresProvider oProvider = new StoresProvider();
                oProvider.DeleteStore(nId);

                LoadStoresGrid();
            }
            
        }

        private void butArticleRefresh_Click(object sender, EventArgs e)
        {
            IsLoading = true;

            LoadStoresCombo();
            LoadArticlesGrid();

            IsLoading = false;
        }

        private void cmbArticleStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IsLoading)
            {
                return;
            }

            LoadArticlesGrid();
        }

        private void butArticleNew_Click(object sender, EventArgs e)
        {
            ArticleForm oForm = new ArticleForm();
            oForm.IsEditMode = false;
            oForm.ShowDialog();

            if (oForm.DoRefresh)
            {
                LoadArticlesGrid();
            }

            oForm.Close();
        }

        private void butArticleEdit_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count <= 0)
            {
                return;
            }

            int nId = (int)dgvArticles.SelectedRows[0].Cells[0].Value;
            ArticleForm oForm = new ArticleForm();
            oForm.IsEditMode = true;
            oForm.ArticleId = nId;
            oForm.ShowDialog();

            if (oForm.DoRefresh)
            {
                LoadArticlesGrid();
            }

            oForm.Close();

        }

        private void butArticleDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Funciones y subrutinas de uso exclusivo del formulario

        private void LoadStoresGrid()
        {
            StoresProvider oProvider = new StoresProvider();
            dgvStores.DataSource = oProvider.GetStores();
        }

        private void LoadStoresCombo()
        {
            StoresProvider oProvider = new StoresProvider();
            List<Store> oList = new List<Store>();
            oList.Add(new Store() { Id = 0, Name = "All Stores", Address = "" });
            oList.AddRange(oProvider.GetStores());
            cmbArticleStore.DataSource = oList;
        }

        private void LoadArticlesGrid()
        {
            int nStoreId = (int)cmbArticleStore.SelectedValue;
            ArticlesProvider articles = new ArticlesProvider();
            dgvArticles.DataSource = articles.GetArticles(nStoreId);
        }

        #endregion

    }
}