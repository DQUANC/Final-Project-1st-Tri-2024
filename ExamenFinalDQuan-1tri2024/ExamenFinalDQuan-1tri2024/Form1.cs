using ExamenFinalDQuan_1tri2024.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenFinalDQuan_1tri2024
{
    public partial class Form1 : Form
    {
        public Lista Combos = new Lista();
        public Lista Carne1 = new Lista();
        public Lista Bebidas1 = new Lista();
        public Lista Complementos1 = new Lista();
        public Lista Carne2 = new Lista();
        public Lista Bebidas2 = new Lista();
        public Lista Complementos2 = new Lista();
        public Lista Carne3 = new Lista();
        public Lista Bebidas3 = new Lista();
        public Lista Complementos3 = new Lista();
        public Lista Compra = new Lista();
        public Compra Compra1 = new Compra();
        public Compra Compra2 = new Compra();
        public Compra Compra3 = new Compra();

        int contador = 0;
        // Carnes
        // Hamburguesa
        int precioCarne11 = 30;
        int precioCarne12 = 40;
        int precioCarne13 = 35;
        // Tortilla
        int precioCarne21 = 45;
        int precioCarne22 = 50;
        // Hot-Dog
        int precioCarne31 = 48;
        int precioCarne32 = 53;
        int precioCarne33 = 60;
        // Bebidas
        // Hamburguesa
        int precioBebida11 = 10;
        int precioBebida12 = 10;
        int precioBebida13 = 20;
        // Tortilla
        int precioBebida21 = 10;
        int precioBebida22 = 20;
        // Hot-Dog 
        int precioBebida31 = 10;
        int precioBebida32 = 20;
        // Complementos
        // Hamburguesa
        int precioComplementos11 = 10;
        int precioComplementos12 = 15;
        //Tortilla 
        int precioComplementos21 = 10;
        int precioComplementos22 = 15;
        int precioComplementos23 = 12;
        //Hot-Dog
        int precioComplementos31 = 10;
        int precioComplementos32 = 15;
        int precioComplementos33 = 25;

        int precioTotal = 0;
        public Form1()
        {
            InitializeComponent();
            UploadData();
            UploadCombos();
        }

        public void UploadData()
        {
            // Combos
            Combos.addList("------- Seleccione un combo -------");
            Combos.addList("Combo 1: Combo Hamburguesa");
            Combos.addList("Combo 2: Combo Tortilla");
            Combos.addList("Combo 3: Combo HOT-DOG");

            // Tipos de Carne - Combo 1
            Carne1.addList("------- Seleccione una -------");
            Carne1.addList("Hamburguesa Clasica");
            Carne1.addList("Hamburguesa 1/4 de libra");
            Carne1.addList("Hamburguesa Vegana");

            // Tipos de Carne - Combo 2
            Carne2.addList("------- Seleccione una -------");
            Carne2.addList("De pollo");
            Carne2.addList("De carne");

            // Tipos de Carne - Combo 3
            Carne3.addList("------- Seleccione una -------");
            Carne3.addList("Clasico");
            Carne3.addList("A la mexicana");
            Carne3.addList("Hawaiano");

            // Tipos de bebidas - Combo 1
            Bebidas1.addList("------- Seleccione una -------");
            Bebidas1.addList("Pepsi");
            Bebidas1.addList("Coca-Cola");
            Bebidas1.addList("Bebida Natural");

            // Tipos de bebidas - Combo 2
            Bebidas2.addList("------- Seleccione una -------");
            Bebidas2.addList("Gaseosa");
            Bebidas2.addList("Bebida Natural");

            // Tipos de bebidas - Combo 3
            Bebidas3.addList("------- Seleccione una -------");
            Bebidas3.addList("Gaseosa");
            Bebidas3.addList("Bebida Natural");

            // Tipos de complementos - Combo 1
            Complementos1.addList("------- Seleccione una -------");
            Complementos1.addList("Papas Fritas");
            Complementos1.addList("Frituras");

            // Tipos de complementos - Combo 2
            Complementos2.addList("------- Seleccione una -------");
            Complementos2.addList("Papas Fritas");
            Complementos2.addList("Frituras");
            Complementos2.addList("Arroz");

            // Tipos de complementos - Combo 3
            Complementos3.addList("------- Seleccione una -------");
            Complementos3.addList("Papas Fritas");
            Complementos3.addList("Frituras");
            Complementos3.addList("Ensalada");

            // Compras
            Compra.addList("------- Seleccione una -------");
            Compra.addList("Compra 1");
            Compra.addList("Compra 2");
            Compra.addList("Compra 3");
        }
            
        // Data Upload
        // Combos 
        public void UploadCombos()
        {
            comboBox1.DataSource = Combos.addList();
        }

        // Carnes 
        public void UploadCarnes1()
        {
             comboBox2.DataSource = Carne1.addList();
        }

        public void UploadCarnes2()
        {
            comboBox2.DataSource = Carne2.addList();
        }

        public void UploadCarnes3()
        {
            comboBox2.DataSource= Carne3.addList();
        }

        // Bebidas
        public void UploadBebidas1()
        {
            comboBox3.DataSource = Bebidas1.addList();
        }

        public void UploadBebidas2()
        {
            comboBox3.DataSource= Bebidas2.addList();
        }

        public void UploadBebidas3()
        {
            comboBox3.DataSource = Bebidas3.addList();
        }

        // Complementos
        public void UploadComplementos1()
        {
            comboBox4.DataSource = Complementos1.addList();
        }

        public void UploadComplementos2()
        {
            comboBox4.DataSource = Complementos2.addList();
        }

        public void UploadComplementos3()
        {
            comboBox4.DataSource = Complementos3.addList();
        }

        public void UploadCompras()
        {
            comboBox5.DataSource = Compra.addList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            int IndexCombo = comboBox1.SelectedIndex;

            switch (IndexCombo)
            {
                case 1:
                    UploadCarnes1();
                    UploadBebidas1();
                    UploadComplementos1();
                    break;
                case 2:
                    UploadCarnes2();
                    UploadBebidas2();
                    UploadComplementos2();
                    break;
                case 3:
                    UploadCarnes3();
                    UploadBebidas3();   
                    UploadComplementos3();
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadCompras();

            contador = contador + 1;
            if (comboBox1.Text == "------- Seleccione un combo -------" || comboBox2.Text == "------- Seleccione una -------" || comboBox3.Text == "------- Seleccione una -------" || comboBox4.Text == "------- Seleccione una -------" || textBox1.Text == "" || textBox2.Text == "")
            {
                label20.Text = "Por favor complete todos los campos de la compra.";
            }
            else
            {
                if (contador <= 3)
                {
                    switch (contador)
                    {
                        case 1:
                            Compra1.Combo = comboBox1.SelectedItem.ToString();
                            Compra1.TipoDeCarne = comboBox2.SelectedItem.ToString();
                            Compra1.Bebida = comboBox3.SelectedItem.ToString();
                            Compra1.Complementos = comboBox4.SelectedItem.ToString();
                            Compra1.NIT = Convert.ToInt64(textBox1.Text);
                            Compra1.Nombre = textBox2.Text;
                            Compra1.MontoTotal = label12.Text;
                            break;
                        case 2:
                            Compra2.Combo = comboBox1.SelectedItem.ToString();
                            Compra2.TipoDeCarne = comboBox2.SelectedItem.ToString();
                            Compra2.Bebida = comboBox3.SelectedItem.ToString();
                            Compra2.Complementos = comboBox4.SelectedItem.ToString();
                            Compra2.NIT = Convert.ToInt64(textBox1.Text);
                            Compra2.Nombre = textBox2.Text;
                            Compra2.MontoTotal = label12.Text;
                            break;
                        case 3:
                            Compra3.Combo = comboBox1.SelectedItem.ToString();
                            Compra3.TipoDeCarne = comboBox2.SelectedItem.ToString();
                            Compra3.Bebida = comboBox3.SelectedItem.ToString();
                            Compra3.Complementos = comboBox4.SelectedItem.ToString();
                            Compra3.NIT = Convert.ToInt64(textBox1.Text);
                            Compra3.Nombre = textBox2.Text;
                            Compra3.MontoTotal = label12.Text;
                            break;
                    }
                }
                else
                {
                    label20.Text = "Lo sentimos, no es posible realizar mas de 3 compras diarias. Lo esperamos de vuelta mañana";
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = "Q ";
            precioTotal = 0;

            int IndexCarnes = comboBox2.SelectedIndex;
            int IndexBebidas = comboBox3.SelectedIndex;
            int IndexComplementos = comboBox4.SelectedIndex;

            if (comboBox1.SelectedIndex == 1)
            {
                switch (IndexCarnes)
                {
                    case 1:
                        precioTotal = precioTotal + precioCarne11;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioCarne12;
                        break;
                    case 3:
                        precioTotal = precioTotal + precioCarne13;
                        break;
                }

                switch (IndexBebidas)
                {
                    case 1:
                        precioTotal = precioTotal + precioBebida11;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioBebida12;
                        break;
                    case 3:
                        precioTotal = precioTotal + precioBebida13;
                        break;
                }

                switch (IndexComplementos)
                {
                    case 1:
                        precioTotal = precioTotal + precioComplementos11;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioComplementos12;
                        break;
                }
            } else if (comboBox1.SelectedIndex == 2)
            {
                switch(IndexCarnes)
                {
                    case 1:
                        precioTotal = precioTotal + precioCarne21;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioCarne22;
                        break;
                }

                switch (IndexBebidas)
                {
                    case 1:
                        precioTotal = precioTotal + precioBebida21;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioBebida22;
                        break;
                }

                switch (IndexComplementos)
                {
                    case 1:
                        precioTotal = precioTotal + precioComplementos21;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioComplementos22;
                        break;
                    case 3:
                        precioTotal = precioTotal + precioComplementos23;
                        break;
                }
            } else if (comboBox1.SelectedIndex == 3)
            {
                switch (IndexCarnes)
                {
                    case 1:
                        precioTotal = precioTotal + precioCarne31;  
                        break;
                    case 2:
                        precioTotal = precioTotal + precioCarne32;
                        break;
                    case 3:
                        precioTotal = precioTotal + precioCarne33;
                        break;
                }
                
                switch (IndexBebidas)
                {
                    case 1:
                        precioTotal = precioTotal + precioBebida31;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioBebida32;
                        break;
                }

                switch (IndexComplementos)
                {
                    case 1:
                        precioTotal = precioTotal + precioComplementos31;
                        break;
                    case 2:
                        precioTotal = precioTotal + precioComplementos32;
                        break;
                    case 3:
                        precioTotal = precioTotal + precioComplementos33;
                        break;
                }
            }

            label12.Text = label12.Text + " " + precioTotal.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Text = "Combo: ";
            label14.Text = "Tipo de Carne: ";
            label15.Text = "Bebida: ";
            label16.Text = "Complemento: ";
            label17.Text = "Monto Total: ";
            label18.Text = "NIT: ";
            label19.Text = "Nombre: ";

    int indexCompra = comboBox5.SelectedIndex;

            switch (indexCompra)
            {
                case 1:
                    label13.Text = label13.Text + Compra1.Combo;
                    label14.Text = label14.Text + Compra1.TipoDeCarne;
                    label15.Text = label15.Text + Compra1.Bebida;
                    label16.Text = label16.Text + Compra1.Complementos;
                    label17.Text = label17.Text + Compra1.MontoTotal;
                    label18.Text = label18.Text + Compra1.NIT;
                    label19.Text = label19.Text + Compra1.Nombre;
                    break; 
                case 2:
                    label13.Text = label13.Text + Compra2.Combo;
                    label14.Text = label14.Text + Compra2.TipoDeCarne;
                    label15.Text = label15.Text + Compra2.Bebida;
                    label16.Text = label16.Text + Compra2.Complementos;
                    label17.Text = label17.Text + Compra2.MontoTotal;
                    label18.Text = label18.Text + Compra2.NIT;
                    label19.Text = label19.Text + Compra2.Nombre;
                    break;
                case 3:
                    label13.Text = label13.Text + Compra3.Combo;
                    label14.Text = label14.Text + Compra3.TipoDeCarne;
                    label15.Text = label15.Text + Compra3.Bebida;
                    label16.Text = label16.Text + Compra3.Complementos;
                    label17.Text = label17.Text + Compra3.MontoTotal;
                    label18.Text = label18.Text + Compra3.NIT;
                    label19.Text = label19.Text + Compra3.Nombre;
                    break;
            }
        }
    }
}
