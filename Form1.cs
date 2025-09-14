using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgenciaViajes
{
    public partial class Form1 : Form
    {
        private GestorViajes gestor = new GestorViajes();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AutoGenerateColumns = true;
        }

        // BOTÓN: AGREGAR VIAJE NACIONAL
        private void btnAgregarNacional_Click(object sender, EventArgs e)
        {
            try
            {
                string destino = txtDestino.Text;
                int duracion = (int)nudDuracion.Value;
                decimal precio = nudPrecio.Value;

                if (!string.IsNullOrEmpty(destino))
                {
                    gestor.AgregarViajeNacional(destino, duracion, precio);
                    ActualizarListaViajes();
                    LimpiarCampos();
                    MessageBox.Show("✅ Viaje nacional agregado correctamente");
                }
                else
                {
                    MessageBox.Show("⚠️ Ingresa un destino válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        //BOTON:AGREGAR VIAJE INTERNACIONAL
        private void btnAgregarInternacional_Click(object sender, EventArgs e)
        {
            try
            {
                string destino = txtDestino.Text;
                int duracion = (int)nudDuracion.Value;
                decimal precio = nudPrecio.Value;
                bool requiereVisa = chkRequiereVisa.Checked;
                string aerolinea = txtAerolinea.Text;

                if (!string.IsNullOrEmpty(destino) && !string.IsNullOrEmpty(aerolinea))
                {
                    gestor.AgregarViajeInternacional(destino, duracion, precio, requiereVisa, aerolinea);
                    ActualizarListaViajes();
                    LimpiarCampos();
                    MessageBox.Show("✅ Viaje internacional agregado correctamente");
                }
                else
                {
                    MessageBox.Show("⚠️ Completa destino y aerolínea");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        //BOTON:ELIMINAR VIAJE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de eliminar este viaje?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        bool eliminado = gestor.EliminarViaje(id);
                        if (eliminado)
                        {
                            ActualizarListaViajes();
                            LimpiarDetalles();
                            MessageBox.Show("✅ Viaje eliminado correctamente");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("⚠️ Selecciona un viaje para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        //BOTON:ESTADISTICAS
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            try
            {
                string stats = gestor.ObtenerEstadisticas();
                MessageBox.Show(stats, "📊 Estadísticas de Viajes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        
        //BOTON:BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txtBuscar.Text;
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    List<Viaje> resultados = gestor.BuscarPorDestino(textoBusqueda);
                    dataGridView1.DataSource = resultados;
                    lblResultados.Text = $"Resultados: {resultados.Count} viajes encontrados";
                }
                else
                {
                    ActualizarListaViajes();
                    lblResultados.Text = "Todos los viajes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        //EVENTO:AL CAMBIAR LA SELECCION EN EL GRID
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Viaje viajeSeleccionado = gestor.ObtenerViajePorId(id);

                    if (viajeSeleccionado != null)
                    {
                        MostrarDetalles(viajeSeleccionado);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        //FUNCION:ACTUALIZAR LISTA DE VIAJES
        private void ActualizarListaViajes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.ObtenerTodosLosViajes();
            AjustarColumnasGrid();
        }

        // FUNCIÓN: AJUSTAR COLUMNAS DEL GRID
        private void AjustarColumnasGrid()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Width = 50;
                dataGridView1.Columns["Destino"].Width = 150;
                dataGridView1.Columns["Duracion"].Width = 80;
                dataGridView1.Columns["Precio"].Width = 100;
                dataGridView1.Columns["Tipo"].Width = 100;
            }
        }

        // FUNCION:MOSTRAR DETALLES
        private void MostrarDetalles(Viaje viaje)
        {
            string detalles = $"🗺️ DESTINO: {viaje.Destino}\r\n" +
                             $"⏰ DURACIÓN: {viaje.Duracion} días\r\n" +
                             $"💰 PRECIO: ${viaje.Precio}\r\n" +
                             $"🏷️ TIPO: {viaje.Tipo}\r\n" +
                             $"🔢 ID: {viaje.Id}";

            if (viaje is ViajeInternacional viajeInt)
            {
                detalles += $"\r\n✈️ AEROLÍNEA: {viajeInt.Aerolinea}\r\n" +
                           $"📋 VISA REQUERIDA: {(viajeInt.RequiereVisa ? "SÍ" : "NO")}";
            }

            txtDetalles.Text = detalles;
        }

        // FUNCION:LIMPIAR CAMPOS DE ENTRADA
        private void LimpiarCampos()
        {
            txtDestino.Clear();
            nudDuracion.Value = 1;
            nudPrecio.Value = 1000;
            chkRequiereVisa.Checked = false;
            txtAerolinea.Clear();
        }

        // FUNCION:LIMPIAR DETALLES
        private void LimpiarDetalles()
        {
            txtDetalles.Clear();
        }

        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}