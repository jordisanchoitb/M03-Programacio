namespace Act40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttLeave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adeu!");
            Application.Exit();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            txtboxAlumno.Text = "";
            txtBoxCondicion.Text = "No definida";
            txtBoxNotaBaja.Text = "00.00";
            txtBoxPromedioNotas.Text = "00.00";
            txtBoxNota1.Text = "";
            txtBoxNota2.Text = "";
            txtBoxNota3.Text = "";
            txtBoxNota4.Text = "";
        }

        private void buttCalc_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                double notapromedio = (Convert.ToDouble(txtBoxNota1.Text) + Convert.ToDouble(txtBoxNota2.Text) + Convert.ToDouble(txtBoxNota3.Text) + Convert.ToDouble(txtBoxNota4.Text)) / 4;
                double notabaja;
                double[] notas = { Convert.ToDouble(txtBoxNota1.Text), Convert.ToDouble(txtBoxNota2.Text), Convert.ToDouble(txtBoxNota3.Text), Convert.ToDouble(txtBoxNota4.Text) };
                Array.Sort(notas);
                notabaja = notas[0];
                txtBoxPromedioNotas.Text = $"{notapromedio:N2}";
                txtBoxNotaBaja.Text = $"{notabaja:N2}";
                if (notapromedio < 5)
                {
                    txtBoxCondicion.Text = "Reprobado";
                }
                else
                {
                    txtBoxCondicion.Text = "Aprobado";
                }
            }
        }

        private static bool CheckNota(double nota)
        {
            return !(nota >= 0 && nota <= 10);
        }

        private static bool CheckIsDigit(string digit)
        {
            if (digit.StartsWith(",")) return false;

            foreach (char c in digit)
            {
                if (!char.IsDigit(c) && !c.Equals(','))
                {
                    return false;
                }
            }
            return true;
        }

        private void GboxNotas_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nota1 = txtBoxNota1.Text.Trim();
            string nota2 = txtBoxNota2.Text.Trim();
            string nota3 = txtBoxNota3.Text.Trim();
            string nota4 = txtBoxNota4.Text.Trim();

            if (nota1 == "" || nota2 == "" || nota3 == "" || nota4 == "")
            {
                NotasProvider.SetError(GboxNotas, "Hi han notas buidas");
                e.Cancel = true;
                return;
            }
            else if (!CheckIsDigit(nota1) || !CheckIsDigit(nota2) || !CheckIsDigit(nota3) || !CheckIsDigit(nota4))
            {
                NotasProvider.SetError(GboxNotas, "Hi han caracters no numerics en alguna de les notes");
                e.Cancel = true;
                return;
            }
            else if (CheckNota(Convert.ToDouble(nota1)) || CheckNota(Convert.ToDouble(nota2)) || CheckNota(Convert.ToDouble(nota3)) || CheckNota(Convert.ToDouble(nota4)))
            {
                NotasProvider.SetError(GboxNotas, "Hi han notas fora de rang d'entre [0-10] inclosos");
                e.Cancel = true;
                return;
            }
            NotasProvider.SetError(GboxNotas, "");
            e.Cancel = false;
        }

        private void txtboxAlumno_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtboxAlumno.Text.Trim() == "")
            {
                AlumnoProvider.SetError(txtboxAlumno, "Introdueix el nom del alumne");
                e.Cancel = true;
                return;
            } else if (CheckIsDigit(txtboxAlumno.Text.Trim()))
            {
                AlumnoProvider.SetError(txtboxAlumno, "El nom de l'alumne no pot contenir caracters numerics");
                e.Cancel = true;
                return;
            }
            AlumnoProvider.SetError(txtboxAlumno, "");
            e.Cancel = false;
        }
    }
}
