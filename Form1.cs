using Microsoft.VisualBasic;

namespace Granja
{
    public partial class Form1 : Form
    {
        Gestionar_Granja GG = new();

        public Form1()
        {
            InitializeComponent();
            Grilla_Granja.DataSource = null;
            Grilla_Granja.DataSource = GG.ObtenerLista;

            CB_ESPECIE.Items.Add("Caballo");
            CB_ESPECIE.Items.Add("Gallina");
            CB_ESPECIE.Items.Add("Vaca");

            Grilla_Granja.Columns.Add("Atributo", "Atributo");
            Grilla_Granja.Columns["Atributo"].DataPropertyName = "Atributo";
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CB_ESPECIE.Text)
                {
                    case "Caballo":
                        Caballo newC = new(
                            TXT_Nombre.Text,
                            CB_ESPECIE.Text,
                            Guid.NewGuid(),
                            Convert.ToInt32(Interaction.InputBox("Ingrese energia del Caballo"))
                            );
                        GG.AgregarAnimal(newC);
                        break;
                    case "Gallina":
                        Gallina newG = new(
                            TXT_Nombre.Text,
                            CB_ESPECIE.Text,
                            Guid.NewGuid(),
                            Interaction.InputBox("Ingrese energia del Caballo")
                            );
                        GG.AgregarAnimal(newG);
                        break;
                    case "Vaca":
                        Vaca newV = new(
                            TXT_Nombre.Text,
                            CB_ESPECIE.Text,
                            Guid.NewGuid(),
                             Convert.ToInt32(Interaction.InputBox("Ingrese energia del Vaca"))
                            );
                        GG.AgregarAnimal(newV);
                        break;
                    default:
                        throw new ArgumentException("Ingrese una seleccion correcta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Granja.Refresh();
            }
        }

        private void Grilla_Granja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.RowIndex == Grilla_Granja.NewRowIndex ||
                e.ColumnIndex < 0 ||
                Grilla_Granja.Columns[e.ColumnIndex].Name != "Atributo"
                )
                return;


            var animal = Grilla_Granja.Rows[e.RowIndex].DataBoundItem;

            if (animal is Caballo caballito)
            {
                e.Value = $"Energia : {caballito.Energia}";
                e.FormattingApplied = true;
            }
            if (animal is Gallina gallina)
            {
                e.Value = $"Huevos : {gallina.Huevo}";
                e.FormattingApplied = true;
            }
            if (animal is Vaca vaca)
            {
                e.Value = $"Peso : {vaca.Peso}";
                ;

                e.FormattingApplied = true;
            }

            
        }

        private void BTN_ALIMENTAR_Click(object sender, EventArgs e)
        {
            GG.AlimentarTodos();
            Grilla_Granja.Refresh();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            GG.Eliminar(
                        Grilla_Granja.SelectedRows[0].DataBoundItem as Animales
                        );
        }
    }
}
