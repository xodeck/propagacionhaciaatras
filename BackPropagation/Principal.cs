using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackPropagation
{
    public partial class Principal : Form
    {
        //private List<System.Windows.Forms.Button> botones = new List<Button>();
        private int filas;
        private int columnas;
        private int tamBotones;
        private Button[] botones;
        private Archivo escritor;
        private Archivo lector;
        private Boolean clickDown;
        private Color encendido;
        private Color apagado;
        //private RedNeuronal red;
        private String direccionEntrenamiento = "";
        private String direccionPesos = "";
        public Principal()
        {
            InitializeComponent(); 
           
            //escritor = new Archivo(false,direccion);
            //lector = new Archivo(direccion);
            tamBotones = 25;
            filas=15;
            columnas=15;
            botones = new Button[filas * columnas];
            encendido = Color.Green;
            apagado = Color.White;
            clickDown = false;
           // red = new RedNeuronal(100, 4, 8);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button boton = new Button();
                    boton.Location = new System.Drawing.Point(j * tamBotones + 20, i * tamBotones + 40);
                    boton.Name = "button"+j+"-"+i;
                    boton.Width = tamBotones;
                    boton.Height = tamBotones;
                    boton.TabIndex = 0;
                    boton.Text = "";
                    boton.UseVisualStyleBackColor = true;
                    boton.BackColor = apagado;
                    boton.MouseEnter += new EventHandler(botonClick);
                    boton.Click += new EventHandler(clickPresionado);
                    this.Controls.Add(boton);                    
                    botones[filas * i + j] = boton;
                }
            }
            cmbModo.SelectedIndex = 0;
        }

        private void guardarEjemploEntrenamiento() {
            if (txtValorEsperado.Text!="")
            {
                int[] entrada = this.obtenerEntrada();
                char valorCorrecto = this.txtValorEsperado.Text[0];
                escritor.escribirReglon(entrada);
                escritor.escribirReglon(valorCorrecto + "");
                this.label1.Text = "Valor correcto: " + valorCorrecto;

            }
            else {
                this.labError.Text = "Se debe agregar el valor esperado de la entrada";
            }        
        }

        private void clickPresionado(object boton, EventArgs e) {            
            clickDown = !clickDown;
            if (clickDown)
                this.label2.Text = "presionado";
            else
                this.label2.Text = "soltado";
            botonClick(boton, e);
        }

        private void clickSoltado(object boton, EventArgs e) {
            clickDown = false;
        }
        
        public int[] obtenerEntrada() {
            int[] entrada = new int[columnas*filas];
            for (int i = 0; i < columnas*filas; i++) {
                entrada[i] = botones[i].BackColor == encendido ? 1 : 0;
            }
            return entrada;
        }

        private void botonClick(object boton, EventArgs e)
        {
            if (boton.GetType() == (new Button()).GetType() && clickDown == true)
            {

                if (((Button)boton).BackColor == encendido)
                {
                    ((Button)boton).BackColor = apagado;
                }
                else
                {
                    ((Button)boton).BackColor = encendido;
                }
                this.label1.Text = ((Button)boton).Name;
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void probar_Click(object sender, EventArgs e)
        {
           // int numero = red.evaluar(this.obtenerEntrada());
           // resultado.Text = numero.ToString();
        }

        private void entrenar_Click(object sender, EventArgs e)
        {
         //   red.entrenar(direccion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.guardarEjemploEntrenamiento();
        }

        private void txtValorEsperado_TextChanged(object sender, EventArgs e)
        {
            this.labError.Text = "";
        }

        /*1 - Agregar Ejemplos de entrenamiento
        2- Entrenar
        3- Probar*/
        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            switch(combo.SelectedIndex) { 
                case 1:
                    if (direccionEntrenamiento == "")
                    {
                        labError.Text = "Error: Debe crear o abrir un archivo de entrenamiento\nEn el menu \"Archivo\"->\"Nuevo\" o \"Abrir\"->\"Archivo Entrenamiento\"";
                        cmbModo.SelectedIndex = 0;
                    }
                    else
                    {
                        escritor = null;
                        escritor = new Archivo(false,direccionEntrenamiento);
                        labError.Text = "";
                        btnAgregarEjemplo.Enabled = true;
                        labValorEsperado.Visible = true;
                        txtValorEsperado.Visible = true;
                        btnEntrenar.Enabled = false;
                        btnProbar.Enabled = false;
                        labResultado.Visible = false;
                    }
                    break;

                case 2:
                    if (direccionEntrenamiento == "")
                    {
                        labError.Text = "Error: Abrir un archivo de entrenamiento\nEn el menu \"Archivo\"->\"Nuevo\" o \"Abrir\"->\"Archivo Entrenamiento\"";
                        cmbModo.SelectedIndex = 0;
                    }
                    else
                    {
                        escritor = null;
                        lector = new Archivo(direccionEntrenamiento);
                        labError.Text = "";                     
                        btnAgregarEjemplo.Enabled = false;
                        labValorEsperado.Visible = false;
                        txtValorEsperado.Visible = false;
                        btnEntrenar.Enabled = true;
                        btnProbar.Enabled = false;
                        labResultado.Visible = false;
                    }
                    break;

                case 3:
                    btnAgregarEjemplo.Enabled = false;
                    labValorEsperado.Visible = false;
                    txtValorEsperado.Visible = false;
                    btnEntrenar.Enabled = false;
                    btnProbar.Enabled = true;
                    labResultado.Visible = true;
                    break;
            
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < columnas * filas; i++) {
                botones[i].BackColor = apagado;                
            }
        }
     
        private void nuevoArchivoEntrenamiento_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivo Entrenamiento (*.aen)|*.aen";
            saveFileDialog.ShowDialog();
            direccionEntrenamiento = saveFileDialog.FileName;            
            if (direccionEntrenamiento != "") {
                labError.Text = "";
                escritor = new Archivo(true, direccionEntrenamiento);
            }
        }

        private void nuevoArchivoDePesos_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivo Pesos (*.ape)|*.ape";
            this.saveFileDialog.ShowDialog();
            direccionPesos= saveFileDialog.FileName;
            if (direccionPesos != "")
            {
                labError.Text = "";
                escritor = new Archivo(true, direccionPesos);
            }
        }

        private void abrirArchivoEntrenamiento_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivo Entrenamiento (*.aen)|*.aen";
            this.openFileDialog.ShowDialog();
            direccionEntrenamiento = openFileDialog.FileName;
            if (direccionEntrenamiento != "")
            {
                labError.Text = "";
                lector= new Archivo( direccionEntrenamiento);
            } 
        }

        private void abrirArchivoDePesos_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivo Pesos (*.ape)|*.ape";
            this.openFileDialog.ShowDialog();
            direccionPesos = openFileDialog.FileName;
            if (direccionPesos != "")
            {
                labError.Text = "";
                lector = new Archivo(direccionPesos);
            }
        }




    }
}