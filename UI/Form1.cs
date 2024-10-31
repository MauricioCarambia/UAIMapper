using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private Partido partido;
        private DeporteBusiness deporteBusiness = new DeporteBusiness();
        private PartidoBusiness partidoBusiness = new PartidoBusiness();
        private List<Partido> partidoList = new List<Partido>();
        public Form1()
        {

            InitializeComponent();
        }
        private void ObtenerDeporte()
        {
            List<Deporte> deporte = deporteBusiness.ObtenerDeporte();

            cmbDeporte.DataSource = deporte;
            cmbDeporte.DisplayMember = "Descripcion";
            cmbDeporte.ValueMember = "IdDeporte";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerDeporte();
            MostrarPartidos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                partidoBusiness.GuardarPartidos(partidoList);
                partidoList = new List<Partido>();
                MostrarPartidos();
                MessageBox.Show("Partido cargado correctamente");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                partido = new Partido();
                Deporte deporte = new Deporte();
                deporte.IdDeporte = Convert.ToInt32(cmbDeporte.SelectedValue);
                partido.Deporte = deporte;
                partido.EquipoLocal = txtEquipoLocal.Text;
                partido.EquipoVisitante = txtEquipoVisitante.Text;
                partido.FechaPartido = Convert.ToDateTime(dtpFechaPartido.Value.Date);
                partidoList.Add(partido);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void MostrarPartidos()
        {
            List<Partido> listaPartidos = partidoBusiness.ObtenerPartidos();

            dgvPartidos.DataSource = null;
            dgvPartidos.DataSource = listaPartidos;

            dgvPartidos.Columns["Deporte"].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPartido = Convert.ToInt32(txtIdEliminar.Text);
                partidoBusiness.EliminarPartido(idPartido);
                MostrarPartidos();
                MessageBox.Show("Partido Eliminado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idPartido = Convert.ToInt32(txtIdModificar.Text);
                int marcadorLocal = Convert.ToInt32(txtMarcadorLocal.Text);
                int marcadorVisitante = Convert.ToInt32(txtMarcadorVisitante.Text);
                partidoBusiness.ModificarPartido(idPartido, marcadorLocal, marcadorVisitante);
                MostrarPartidos();
                MessageBox.Show("Partido modificado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
