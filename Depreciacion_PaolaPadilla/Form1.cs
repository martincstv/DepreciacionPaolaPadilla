using System.Windows.Forms;

namespace Depreciacion_PaolaPadilla
{
    public partial class Form1 : Form
    {
        List<Depreciacion> filaDataGrid = new List<Depreciacion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void CargarDataGrid()
        {
            dataGridView_ActivosFijos.DataSource = null;
            dataGridView_ActivosFijos.DataSource = filaDataGrid;
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            CalcularDepreciacion();

        }

        private void CalcularDepreciacion()
        {
            string tipoActivoSeleccionado;

            if (radioButton_Inmueble.Checked)
            {
                tipoActivoSeleccionado = "Inmueble";
            }
            else
            {
                tipoActivoSeleccionado = "Vehiculo";
            }

            Activos activos = new Activos();
            

            switch (tipoActivoSeleccionado)
            {
                case "Inmueble":
                    activos.P_Anual = 0.05f; // 5%
                    activos.VidaUtil = 20;
                    activos.N_Meses = 240;
                    
                    dateTimePicker_FechaDepreciacion.MinDate = dateTimePicker_FechaCompra.Value;
                    dateTimePicker_FechaDepreciacion.MaxDate = dateTimePicker_FechaCompra.Value.AddYears(activos.VidaUtil);
                    dateTimePicker_FechaDepreciacion.Value = dateTimePicker_FechaCompra.Value.AddYears(activos.VidaUtil);
                    
                    break;

                case "Vehiculo":
                    activos.P_Anual = 0.2f; // 20%
                    activos.VidaUtil = 5;
                    activos.N_Meses = 60;
                   
                    dateTimePicker_FechaDepreciacion.MinDate = dateTimePicker_FechaCompra.Value;
                    dateTimePicker_FechaDepreciacion.MaxDate = dateTimePicker_FechaCompra.Value.AddYears(activos.VidaUtil);
                    dateTimePicker_FechaDepreciacion.Value = dateTimePicker_FechaCompra.Value.AddYears(activos.VidaUtil);

                    break;
            }

            
            DateTime f_compra = dateTimePicker_FechaCompra.Value;
            DateTime f_depreciacion = dateTimePicker_FechaDepreciacion.Value;
            float m_compra = Convert.ToSingle(textBox_MontoCompra.Text);
           


            var año = f_compra.Year;
            var mesInicial = 12 - f_compra.Month;
            var mesEntreInicialFinal = 12;
            var mesFinal = 12 - mesInicial;
            float acumulado = 0;
            float residual = activos.P_Anual * m_compra;
            textBox_ValorResidual.Text = residual.ToString();

            //Algoritmo Depreciacion AQUI

            if (año != f_depreciacion.Year)
            {
                for (int i = 0; i <= activos.VidaUtil; i++)
                {
                   
                    if (i == 0)
                    {
                        filaDataGrid.Add(new Depreciacion(i + 1, año, mesInicial, m_compra, (((m_compra * activos.P_Anual)/12) * mesInicial),acumulado = (((m_compra * activos.P_Anual) / 12) * mesInicial), m_compra-acumulado));
                    }
                    if (i >= 1 && i < activos.VidaUtil)
                    {
                        filaDataGrid.Add(new Depreciacion(i + 1, año + i, mesEntreInicialFinal, m_compra, (((m_compra * activos.P_Anual) / 12) * mesEntreInicialFinal), acumulado += (((m_compra * activos.P_Anual) / 12) * mesEntreInicialFinal), m_compra - acumulado));
                    }
                    if (i == activos.VidaUtil)
                    {
                        filaDataGrid.Add(new Depreciacion(i + 1, año + i, mesFinal, m_compra, (((m_compra * activos.P_Anual) / 12) * mesFinal), acumulado += (((m_compra * activos.P_Anual) / 12) * mesFinal), m_compra - acumulado));
                    }

                }
            }
            else
            {
                filaDataGrid.Add(new Depreciacion(1, año, mesInicial , m_compra, (((m_compra * activos.P_Anual) / 12) * mesInicial), acumulado, m_compra - acumulado));
            }
           

            CargarDataGrid();

            //

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelva pronto... Adios");
            //Application.Exit();
            this.Close();
        }

        private void button_Informacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Qué es la depreciación? Es un concepto de contabilidad que se refiere " +
                "a la pérdida de valor que un bien experimenta a lo largo de su vida útil. " +
                "Este cálculo lo realizan todas las empresas con todos sus activos fijos, es decir, " +
                "con los objetos y bienes que compra para aprovecharlos durante más de un año."+ MessageBoxButtons.OK+ MessageBoxIcon.Information);
        }

        private void limpiarCampos()
        {
            //Limpiamos los txt 
            textBox_MontoCompra.Clear();
            dataGridView_ActivosFijos.DataSource = null;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        
    }
}