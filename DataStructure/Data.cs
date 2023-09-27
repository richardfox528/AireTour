using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DataStructure
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Data : Form
    {
        private const double FEMALE_DISCOUNT = 0.03;
        private readonly string[] destinations = { "Bogotá", "Medellín", "Florencia", "Pitalito" };
        private readonly string[] classes = { "Clase A", "Clase B", "Clase C" };
        private string result;
        private Data frm;

        public Data()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            btnPrint.Enabled = false;
            ChangedFields();
            dateTimePickerDay.MinDate = DateTime.Today;
            dateTime.Value = DateTime.Today;
            dateTime.MaxDate = DateTime.Today;
            txtId.KeyPress += txtId_KeyPress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult option;
            option = MessageBox.Show("¿Realmente desea salir?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string data;

            data = $"Nombre: {txtNameUser.Text} {txtSurnameUser.Text}";
            data += $"\nIdentificación: {txtId.Text}";
            data += $"\nEstrato socioeconómico: {cbEstratum.Text}";
            data += $"\nDestino de vuelo: {cbDestiny.Text}";
            data += $"\nClase de vuelo: {cbFligthClass.Text}";
            data = data + $"\nGénero: " + (rbFemale.Checked ? "Femenino" : "Masculino");
            data += $"\nEdad: {lblAge.Text}";

            //if (rbFemale.Checked == true) data = data + "\nGenero: Femenino"; 
            //else if (rbFemale.Checked == false) data = data + "\nGenero: Masculino";

            MessageBox.Show(data, "Información agregada.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            var age = date.Year - dateTime.Value.Year;
            if (date < dateTime.Value.AddYears(age)) age--;
            lblAge.Text = age + " Años";
            lblAge.Visible = age != 0;
        }

        private double GetBaseCost(string destination, string flightClass)
        {
            double[,] baseCosts = { { 300000, 225000, 150000 }, { 420000, 315000, 210000 }, { 270000, 202500, 135000 }, { 250000, 187500, 125000 } };

            var destinationIndex = Array.IndexOf(destinations, destination);
            var classIndex = Array.IndexOf(classes, flightClass);

            if (destinationIndex >= 0 && classIndex >= 0)
            {
                return baseCosts[destinationIndex, classIndex];
            }
            return 0.0;
        }

        private double GetStratumDiscount(int stratum)
        {
            double[] stratumDiscounts = { 0.1, 0.1, 0.07, 0.07, 0.05, 0.05 };

            if (stratum >= 1 && stratum <= 6)
            {
                return stratumDiscounts[stratum - 1];
            }
            return 0.0;
        }

        private double GetDayOfWeekDiscount(string dayOfWeek)
        {
            var dayOfWeekDiscounts = new Dictionary<string, double> { { "Lunes", 0.1 }, { "Martes", 0.1 }, { "Miércoles", 0.1 }, { "Jueves", 0.05 }, { "Viernes", 0.05 }, { "Sábado", 0.0 }, { "Domingo", 0.0 } };

            if (dayOfWeekDiscounts.TryGetValue(dayOfWeek, out var discount))
            {
                return discount;
            }
            return 0.0;
        }

        public static string GetDayOfWeek(DateTime date)
        {
            // Obtener el nombre del día de la semana
            var dayOfWeek = (int)date.DayOfWeek;

            string[] daysOfWeek = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

            var dayOfWeekString = daysOfWeek[dayOfWeek];

            return dayOfWeekString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var today = dateTimePickerDay.Value;

            var destination = cbDestiny.Text;
            var flightClass = cbFligthClass.Text;
            var stratum = int.Parse(cbEstratum.Text);
            var dayOfWeek = GetDayOfWeek(today);
            var gender = rbFemale.Checked ? "Femenino" : "Masculino";

            // Obtiene el costo de vuelo base según el destino y la clase
            var baseCost = GetBaseCost(destination, flightClass);

            // Obtiene descuento según estrato
            var stratumDiscount = GetStratumDiscount(stratum);

            // Obtiene descuento según el día de la semana
            var dayOfWeekDiscount = GetDayOfWeekDiscount(dayOfWeek);

            // Aplica 3% de descuento si es una mujer
            var genderDiscount = (gender == "Femenino") ? FEMALE_DISCOUNT : 0.0;

            // Calcula el total del descuento
            var totalDiscount = stratumDiscount + dayOfWeekDiscount + genderDiscount;

            // Costo final con descuentos aplicados
            var finalCost = baseCost * (1 - totalDiscount);

            result = $"Nombre Completo: {txtNameUser.Text} {txtSurnameUser.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Identificación: {txtId.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Género: {gender}\n" +
                             $"-----------------------------------------------\n" +
                             $"Edad: {lblAge.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Estrato: {cbEstratum.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Destino del Vuelo: {cbDestiny.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Clase del Vuelo: {cbFligthClass.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Fecha de vuelo: {dateTimePickerDay.Value:dd/MM/yyyy}\n" +
                             $"-----------------------------------------------\n" +
                             $"Día de la Semana: {dayOfWeek}\n" +
                             $"-----------------------------------------------\n" +
                             $"Costo de vuelo: {txtFlightCost.Text}\n" +
                             $"-----------------------------------------------\n" +
                             $"Fecha de impresión: {DateTime.Now}\n" +
                             $"-----------------------------------------------\n" +
                             $"Valor a Pagar: ${finalCost:N0}\n" +
                             $"Descuento Total: {totalDiscount * 100:N0}%";

            if (!AreFieldsEmpty())
            {
                ShowFormResult();
            }
            //else
            //{
            //    MessageBox.Show("Por favor, rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void UpdateButtons(object sender, EventArgs e)
        {
            bool completeFields = !AreFieldsEmpty();

            btnSave.Enabled = completeFields;
            btnPrint.Enabled = completeFields;
        }

        private void ChangedFields()
        {
            txtNameUser.TextChanged += UpdateButtons;
            txtSurnameUser.TextChanged += UpdateButtons;
            txtId.TextChanged += UpdateButtons;
            cbEstratum.TextChanged += UpdateButtons;
            cbDestiny.TextChanged += UpdateButtons;
            cbFligthClass.TextChanged += UpdateButtons;
            rbMale.CheckedChanged += UpdateButtons;
            rbFemale.CheckedChanged += UpdateButtons;

            // Si hay valores en destino y clase de vuelo muestra el costo automatico
            cbDestiny.TextChanged += txtFlightCost_TextChanged;
            cbFligthClass.TextChanged += txtFlightCost_TextChanged;

        }

        private void Data_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNameUser;
            txtNameUser.Clear();
            txtNameUser.Focus();
            txtFlightCost.BorderStyle = BorderStyle.FixedSingle;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void txtFlightCost_TextChanged(object sender, EventArgs e)
        {
            var d = cbDestiny.Text;
            var fc = cbFligthClass.Text;

            if (!string.IsNullOrEmpty(d) && !string.IsNullOrEmpty(fc))
            {
                var cost = GetBaseCost(d, fc);

                txtFlightCost.Text = cost.ToString("C", new CultureInfo("es-CO"));

                txtFlightCost.ReadOnly = true;
            }
            else
            {
                txtFlightCost.Clear();
                txtFlightCost.ReadOnly = false;
            }
        }

        private bool AreFieldsEmpty()
        {
            return string.IsNullOrEmpty(txtNameUser.Text) ||
                   string.IsNullOrEmpty(txtSurnameUser.Text) ||
                   string.IsNullOrEmpty(txtId.Text) ||
                   string.IsNullOrEmpty(cbEstratum.Text) ||
                   string.IsNullOrEmpty(cbDestiny.Text) ||
                   string.IsNullOrEmpty(cbFligthClass.Text) ||
                   (!rbMale.Checked && !rbFemale.Checked);
        }

        private void ShowFormResult()
        {
            var form = new Form();
            var lblResult = new Label();
            var printButton = new Button();
            var statusStrip = new StatusStrip();
            var toolStripStatusLabel = new ToolStripStatusLabel();
            frm = new Data();

            lblResult.Text = result;

            form.Controls.Add(lblResult);
            form.BackColor = Color.AntiqueWhite;
            form.Icon = this.Icon;

            printButton.Text = "Imprimir";
            printButton.Dock = DockStyle.Bottom;
            printButton.Size = new Size(90, 40);
            printButton.Font = new Font("Bookman Old Style", 10);
            printButton.BackColor = SystemColors.ActiveCaption;

            // evento Click del botón
            printButton.Click += (s, args) =>
            {
                var printDocument = new PrintDocument();
                printDocument.PrintPage += (sender2, args2) =>
                {
                    args2.Graphics.DrawString(lblResult.Text, new Font("Courier New", 16), Brushes.Black, new PointF(100, 100));
                };
                printDocument.Print();
            };

            form.Controls.Add(printButton);

            toolStripStatusLabel.Text = "Ingresar otro reporte";
            toolStripStatusLabel.IsLink = true;

            toolStripStatusLabel.Click += (s, args) =>
            {
                DeleteDataForm();
                frm.Show();
            };

            statusStrip.Items.Add(toolStripStatusLabel);

            form.Controls.Add(statusStrip);

            form.Text = "Resultado";

            lblResult.Dock = DockStyle.Fill;

            lblResult.Font = new Font("Courier New", 16);

            form.StartPosition = FormStartPosition.CenterParent;

            lblResult.AutoSize = true;

            lblResult.Text = result;

            form.ClientSize = new Size(lblResult.Width, lblResult.Height + printButton.Height + statusStrip.Height);

            form.ShowDialog();
        }

        private void DeleteDataForm()
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
            Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip tl = new ToolTip();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                tl.Show("Por favor, ingresa solo números", txtId, 0, -20, 2000);
            }
        }

        private void txtFlightCost_Click(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();

            if (txtFlightCost.Text == "")
            {
                tltip.Show("El costo de vuelo se obtendrá de los valores destino y clase de vuelo.", txtFlightCost, 0, -20, 3000);
            }
        }
    }
}
