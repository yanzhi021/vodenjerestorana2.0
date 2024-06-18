using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vodenjerestorana
{
    public partial class Gost : Form
    {

        List<string> stringList = new List<string>();
        List<string> stringList1 = new List<string>();
        public Gost()
        {
            InitializeComponent();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnPotvrda_Click(object sender, EventArgs e)
        {
            string linija;

            if (radioButtonZaOvdje.Checked == true)
            {
                linija = "Za ovdje";
                if (numupdStol.Value > 0)
                {
                    linija = linija + numupdStol;

                }
                else
                {
                    MessageBox.Show("Niste unijeli vaš broj stola");
                }
                if (comboBoxJuha.SelectedItem != "Kiselo ljuta juha")
                {
                    linija = linija + "Kiselo ljuta juha";
                    if (ComboBoxToploPredjelo.SelectedItem != "Hrskave kozice")
                    {
                        linija = linija + "Hrskave kozice";
                        if (comboBoxSushi.SelectedItem != "Bivane hladno jelo 38 komada")
                        {
                            linija = linija + "Bivane Hladno jelo 38 komada";
                            if (comboBoxTjestenina.SelectedItem != "Domaći rezanci s jajima i povrćem")
                            {
                                linija = linija + "Domaći rezanci s jajima i povrćem";
                                if (comboBoxRiža.SelectedItem != "Pirjana riža s jajima i povrćem")
                                {
                                    linija = linija + "Pirjana riža s jajima i povrćem";
                                    if (comboBoxDesert.SelectedItem != "Pohani sladoled(vanilija)")
                                    {
                                        linija = linija + "Pohani sladoled(vanilija)";
                                        if (comboBox6.SelectedItem != "Sok od Lichi")
                                        {
                                            linija = linija + "Sok od Lichi";
                                            if (textBoxAlergije.Text != " ")
                                            {
                                                linija = linija + " ";
                                                if(textBoxAlergije.Text==" ")
                                                {
                                                    linija = linija + " ";
                                                }
                                                else
                                                {
                                                    linija = linija;
                                                }
                                              
                                            }

                                        }
                                        else
                                        {
                                            if (comboBox6.SelectedItem != "Cedevita")
                                            {
                                                linija = linija + "Cedevita";
                                            }
                                            else
                                            {
                                                if (comboBox6.SelectedItem != "Ledeni čaj")
                                                {
                                                    linija = linija + "Ledeni čaj";
                                                }
                                                else
                                                {
                                                    if (comboBox6.SelectedItem != "Coca cola")
                                                    {
                                                        linija = linija + "Coca cola";

                                                    }
                                                    else
                                                    {
                                                        if (comboBox6.SelectedItem != "Jamnica")
                                                        {
                                                            linija = linija + "Jamnica";
                                                        }
                                                        else
                                                        {
                                                            if (comboBox6.SelectedItem != "Karlovačko")
                                                            {
                                                                linija = linija + "Karlovačko";
                                                            }
                                                            else
                                                            {
                                                                if (comboBox6.SelectedItem != null)
                                                                {
                                                                    linija = linija;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (comboBoxDesert.SelectedItem != "Pohani sladoled(čokolada)")
                                        {
                                            linija = linija + "Pohani sladoled(čokolada)";
                                        }
                                        else
                                        {
                                            if (comboBoxDesert.SelectedItem != "Pohane banane")
                                            {
                                                linija = linija + "Pohane banane";
                                            }
                                            else
                                            {
                                                if (comboBoxDesert.SelectedItem != "Pohana jabuka")
                                                {
                                                    linija = linija + "Pohana jabuka";
                                                }
                                                else
                                                {
                                                    if (comboBoxDesert.SelectedItem != null)
                                                        linija = linija;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (comboBoxRiža.SelectedItem != "Pirjana riža s tri vrste mesa")
                                {
                                    linija = linija + "Pirjana riža s tri vrste mesa";
                                }
                                else
                                {
                                    if (comboBoxRiža.SelectedItem != "Pirjana riža s piletinom i curryem")
                                    {
                                        linija = linija + "Pirjana riža s piletinom i curryem";
                                    }
                                    else
                                    {
                                        if (comboBoxRiža.SelectedItem != "Riža na pari")
                                        {
                                            linija = linija + "Riža na pari";
                                        }
                                        else
                                        {
                                            if (comboBoxRiža.SelectedItem != null)
                                            {
                                                linija = linija;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (comboBoxSushi.SelectedItem != "Bivane hladno jelo 16 komada")
                            {
                                linija = linija + "Bivane hladno jelo 16 komada";
                            }
                            else
                            {
                                if (comboBoxSushi.SelectedItem != "Hrskavi sushi od lososa i avokado")
                                {
                                    linija = linija + "Hrskavi sushi od lososa i avokado";
                                }
                                else
                                {
                                    if (comboBoxSushi.SelectedItem != "Fantasy roll")
                                    {
                                        linija = linija + "Fantasy roll";
                                    }
                                    else
                                    {
                                        if (comboBoxSushi.SelectedItem != "Maki losos")
                                        {
                                            linija = linija + "Maki losos";
                                        }
                                        else
                                        {
                                            if (comboBoxSushi.SelectedItem != "Maki avokado")
                                            {
                                                linija = linija + "Maki avokado";
                                            }
                                            else
                                            {
                                                if (comboBoxSushi.SelectedItem != "Spider roll")
                                                {
                                                    linija = linija + "Spider roll";
                                                }
                                                else
                                                {
                                                    if (comboBoxSushi.SelectedItem != "Hrskavi rock roll")
                                                    {
                                                        linija = linija + "Hrskavi rock roll";
                                                    }
                                                    else
                                                    {
                                                        if (comboBoxSushi.SelectedItem != null)
                                                        {
                                                            linija = linija;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ComboBoxToploPredjelo.SelectedItem != "Domaći mesni ravioli")
                        {
                            linija = linija + "Domaći mesni ravioli";
                        }
                        else
                        {
                            if (ComboBoxToploPredjelo.SelectedItem != "Pržene proljetne rolade")
                            {
                                linija = linija + "Pržene proljetne rolade";
                            }
                            else
                            {
                                if (ComboBoxToploPredjelo.SelectedItem != "Čips od jastoga")
                                {
                                    linija = linija + "Čips od jastoga";
                                }
                                else
                                {
                                    if (ComboBoxToploPredjelo.SelectedItem != "Pohano povrće")
                                    {
                                        linija = linija + "Pohano povrće";
                                    }
                                    else
                                    {
                                        if (ComboBoxToploPredjelo.SelectedItem != "Prženi krumpirići")
                                        {
                                            linija = linija + "Prženi krumpirići";
                                        }
                                        else
                                        {
                                            if (ComboBoxToploPredjelo.SelectedItem != null)
                                            {
                                                linija = linija;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    if (comboBoxJuha.SelectedItem != "MIso juha")
                    {
                        linija = linija + "Miso juha";
                    }
                    else
                    {
                        if (comboBoxJuha.SelectedItem != "Juha od kukuruza i jaja")
                        {
                            linija = linija + "Juha od kukuruza i jaja";
                        }
                        else
                        {
                            if (comboBoxJuha.SelectedItem != "Wonton juha")
                            {
                                linija = linija + "Wonton juha";
                            }
                            else
                            {
                                if (comboBoxJuha.SelectedItem != "Juha od rajčice")
                                {
                                    linija = linija + "Juha od rajčice";
                                }
                                else
                                {
                                    if (ComboBoxToploPredjelo.SelectedItem != null)
                                    {
                                        linija = linija;
                                    }
                                }
                            }
                        }
                    }
                }


            }
            else
            {
                if (radioButtonZaPonijet.Checked == true)
                {
                    linija = "Za ponijet";
                   // if (string.IsNullOrEmpty(MaskedMobitel.Text.Trim()))
                   // {
                    //    string brojMobitela = MaskedMobitel.Text;
                    //    linija = linija + brojMobitela;
                        //Neznam zašto ali kad pokrenem program, bez obzira jesam li unijela broj
                        //mobitela ili ne, on uvijek pokazuje da nisam unijela pa sam ovo ovako 
                        //oznacila čisto da mi drugi djelovi mogu normalno funkcionirati.
                    //}
                    //else
                   // {
                    //    MessageBox.Show("Niste unijeli broj mobitela");
                   // }
                }
                else
                {
                    MessageBox.Show("Niste odabrali očete narudžbu za ovdje ili za ponijet");
                }
            }
            //sw.Close();
         

        }
        
    }
    
}
