using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kalkulator;

namespace Calculator1
{
    /* Mohammmad Aris Saputra
     * 18051204041
       TI 2018 B */
    public partial class Form1 : Form
    {
        double result = 0;
        String operation = "";
        String convertion = "";
        bool input_angka = true;
        bool operasi = false;
        bool is_samadengan = false;
        bool is_mode = true;
        bool is_trigomin = true;
        Hitung operator_dasar = new Hitung();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (input_angka == true && operasi == true))
                txtDisplay.Text = "";
            input_angka = false;
            Button num = (Button)sender;
               
            if (num.Text == ",")
            {
                if(txtDisplay.Text == "")
                    txtDisplay.Text = "0";
                if (!txtDisplay.Text.Contains(","))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                is_samadengan = false;
            }
            else
            {
                if (is_samadengan == true)
                {
                    txtDisplay.Text = "";
                    lblShowOp.Text = "";
                    result = 0;
                }
                is_samadengan = false;
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }
                
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
            result = 0;
            is_samadengan = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }

            if (is_samadengan == true)
            {
                lblShowOp.Text = "";
            }
            is_samadengan = false;
        }

        private void operator_mtkdas(object sender, EventArgs e)
        {
            is_samadengan = false;
            if(operasi == false)
            {
                Button num = (Button)sender;
                operation = num.Text;
                result = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString(result) + " " + operation;
                txtDisplay.Text = "0";
                
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = Convert.ToString(operator_dasar.tambah(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case "-":
                        txtDisplay.Text = Convert.ToString(operator_dasar.kurang(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case "x":
                        txtDisplay.Text = Convert.ToString(operator_dasar.perkalian(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case ":":
                        txtDisplay.Text = Convert.ToString(operator_dasar.pembagian(result, Double.Parse(txtDisplay.Text)));
                        break;
                    default:
                        break;
                }
                Button num = (Button)sender;
                operation = num.Text;
                result = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = txtDisplay.Text + " " + operation;
                txtDisplay.Text = "0";
                
            }
            input_angka = true; operasi = true;                       
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = lblShowOp.Text + " " + txtDisplay.Text + " =";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(operator_dasar.tambah(result, Double.Parse(txtDisplay.Text)));
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(operator_dasar.kurang(result, Double.Parse(txtDisplay.Text)));
                    break;
                case "x":
                    txtDisplay.Text = Convert.ToString(operator_dasar.perkalian(result, Double.Parse(txtDisplay.Text)));
                    break;
                case ":":
                    txtDisplay.Text = Convert.ToString(operator_dasar.pembagian(result, Double.Parse(txtDisplay.Text)));
                    break;
                default:
                    break;
            }
            input_angka = true; operasi = false; is_samadengan = true;
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(Double.Parse(txtDisplay.Text) * (-1));
            is_samadengan = false;
        }

        private void operator_addon(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            Button num = (Button)sender;
            convertion = num.Text;
            switch (convertion)
            {
                case "1/X":
                    lblShowOp.Text = "1 / " + txtDisplay.Text + " = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.seper(Double.Parse(txtDisplay.Text)));
                    break;
                case "%":
                    txtDisplay.Text = Convert.ToString(operator_dasar.persen(Double.Parse(txtDisplay.Text)));
                    break;
                case "X²":
                    lblShowOp.Text = txtDisplay.Text + "² = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.kuadrat(Double.Parse(txtDisplay.Text)));
                    break;
                case "√X":
                    lblShowOp.Text = "√ " + txtDisplay.Text + " = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.akar(Double.Parse(txtDisplay.Text)));
                    break;
                case "X!":
                    lblShowOp.Text = txtDisplay.Text + "! = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.faktorial(Double.Parse(txtDisplay.Text)));
                    break;
                case "Sin":
                    lblShowOp.Text = "Sin ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_sin(Double.Parse(txtDisplay.Text)));
                    break;
                case "Cos":
                    lblShowOp.Text = "Cos ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_cos(Double.Parse(txtDisplay.Text)));
                    break;
                case "Tan":
                    lblShowOp.Text = "Tan ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_tan(Double.Parse(txtDisplay.Text)));
                    break;
                case "Cosec":
                    lblShowOp.Text = "Cosec ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_cosec(Double.Parse(txtDisplay.Text)));
                    break;
                case "Sec":
                    lblShowOp.Text = "Sec ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_sec(Double.Parse(txtDisplay.Text)));
                    break;
                case "Cot":
                    lblShowOp.Text = "Cot ( " + txtDisplay.Text + " ) = ";
                    txtDisplay.Text = Convert.ToString(operator_dasar.ht_cot(Double.Parse(txtDisplay.Text)));
                    break;
                default:
                    break;
            }
            is_samadengan = false;
        }

        private void mode_Click(object sender, EventArgs e)
        {
            if(is_mode == true)
            {
                this.Width = 373;
                this.Height = 478;
                txtDisplay.Width = 351;

                backspace.Location = new Point(2, 186);
                clear.Location = new Point(72, 186);
                plus_minus.Location = new Point(142, 186);
                kali.Location = new Point(212, 186);
                
                angka7.Location = new Point(3, 237);
                angka8.Location = new Point(73, 237);
                angka9.Location = new Point(143, 237);
                bagi.Location = new Point(214, 236);

                angka4.Location = new Point(3, 287);
                angka5.Location = new Point(73, 287);
                angka6.Location = new Point(143, 287);
                tambah.Location = new Point(214, 287);

                angka1.Location = new Point(3, 337);
                angka2.Location = new Point(73, 337);
                angka3.Location = new Point(143, 337);
                kurang.Location = new Point(214, 337);

                mode.Location = new Point(3, 387);
                angka0.Location = new Point(73, 387);
                koma.Location = new Point(143, 387);
                hasil.Location = new Point(214, 387);
                hasil.Width = 140;

                is_mode = false;
            }
            else
            {
                this.Width = 302;
                this.Height = 427;
                txtDisplay.Width = 281;

                backspace.Location = new Point(2, 136);
                clear.Location = new Point(72, 136);
                plus_minus.Location = new Point(142, 136);
                kali.Location = new Point(212, 136);
                

                angka7.Location = new Point(3, 187);
                angka8.Location = new Point(73, 187);
                angka9.Location = new Point(143, 187);
                bagi.Location = new Point(214, 186);

                angka4.Location = new Point(3, 237);
                angka5.Location = new Point(73, 237);
                angka6.Location = new Point(143, 237);
                tambah.Location = new Point(214, 237);

                angka1.Location = new Point(3, 287);
                angka2.Location = new Point(73, 287);
                angka3.Location = new Point(143, 287);
                kurang.Location = new Point(214, 287);

                mode.Location = new Point(3, 337);
                angka0.Location = new Point(73, 337);
                koma.Location = new Point(143, 337);
                hasil.Location = new Point(214, 337);
                hasil.Width = 70;

                is_mode = true;

                button_sin.Text = "Sin";
                button_cos.Text = "Cos";
                button_tan.Text = "Tan";
                is_trigomin = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 302;
            this.Height = 427;
            txtDisplay.Width = 281;

            backspace.Location = new Point(2, 136);
            clear.Location = new Point(72, 136);
            plus_minus.Location = new Point(142, 136);
            kali.Location = new Point(214, 136);


            angka7.Location = new Point(3, 187);
            angka8.Location = new Point(73, 187);
            angka9.Location = new Point(143, 187);
            bagi.Location = new Point(214, 186);

            angka4.Location = new Point(3, 237);
            angka5.Location = new Point(73, 237);
            angka6.Location = new Point(143, 237);
            tambah.Location = new Point(214, 237);

            angka1.Location = new Point(3, 287);
            angka2.Location = new Point(73, 287);
            angka3.Location = new Point(143, 287);
            kurang.Location = new Point(214, 287);

            mode.Location = new Point(3, 337);
            angka0.Location = new Point(73, 337);
            koma.Location = new Point(143, 337);
            hasil.Location = new Point(214, 337);
            hasil.Width = 70;
        }

        private void trigo_switch_Click(object sender, EventArgs e)
        {
            if(is_trigomin == true)
            {
                button_sin.Text = "Cosec";
                button_cos.Text = "Sec";
                button_tan.Text = "Cot";
                is_trigomin = false;
            }
            else
            {
                button_sin.Text = "Sin";
                button_cos.Text = "Cos";
                button_tan.Text = "Tan";
                is_trigomin = true;
            }
            
        }
    }
}
