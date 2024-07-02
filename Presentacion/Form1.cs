using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRegion negocio = new NRegion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvRegions.DataSource = negocio.Listar();

        }

        private void btn_registarRegion_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad.Region region = new Entidad.Region();
                region.RegionName = txt_nombreRegion.Text;
                negocio.Registrar(region);
                MessageBox.Show("Registro Exitoso");
                dgvRegions.DataSource = negocio.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad.Region region = new Entidad.Region();
                region.RegionId = Convert.ToInt32(txtIdEditar.Text);
                region.RegionName = txtRegionModificado.Text;
                negocio.Editar(region);
                MessageBox.Show("Modificación Exitosa");
                dgvRegions.DataSource = negocio.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
        }

        private void btn_eliminarRegion_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad.Region region = new Entidad.Region();
                region.RegionId = Convert.ToInt32(txt_id.Text);
                negocio.Eliminar(region);
                MessageBox.Show("Eliminación Exitosa");
                dgvRegions.DataSource = negocio.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
        }
    }
}
