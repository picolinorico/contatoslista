using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contatoslista
{
    public partial class formPessoa : Form
    {
        private Contato[] listaDeContato = new Contato[1];
        public formPessoa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            AtualizarDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato();
            lstContato.Items.Add(objetoContato.ToString());
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        { 
            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text, txtEndereco.Text);
            Escrever(objetoContato);
            Ler();
            AtualizarDisplay();
            LimparFormulario();

           
        }
        private void Escrever(Contato contato)
             {
            StreamWriter escrevedorDeArquivos =new StreamWriter ("Contatos.txt");
            escrevedorDeArquivos.WriteLine(listaDeContato.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);
            escrevedorDeArquivos.WriteLine(contato.Endereco);

            for (int i =0; i < listaDeContato.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(listaDeContato[i].PrimeiroNome);
                escrevedorDeArquivos.WriteLine(listaDeContato[i].Sobrenome);
                escrevedorDeArquivos.WriteLine(listaDeContato[i].Telefone);
                escrevedorDeArquivos.WriteLine(listaDeContato[i].Email);
                escrevedorDeArquivos.WriteLine(listaDeContato[i].Endereco);
            }
            escrevedorDeArquivos.Close();
        }
        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContato = new Contato[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < listaDeContato.Length; i++)
            {
                listaDeContato[i] = new Contato();
                listaDeContato[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContato[i].Sobrenome = leitorDeArquivos.ReadLine();
                listaDeContato[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContato[i].Email = leitorDeArquivos.ReadLine();
                listaDeContato[i].Endereco = leitorDeArquivos.ReadLine();
            }

            leitorDeArquivos.Close();
              
        }
        private void AtualizarDisplay()

        {
            lstContato.Items.Clear();
            for (int i = 0; i < listaDeContato.Length; i++)
            {
                lstContato.Items.Add(listaDeContato[i].ToString());
               
            }
        }
        
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            
        {
         
          
            
         }
        private void LimparFormulario()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }   

        private void btnordenar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormAnimal == null)
                FormAnimal = new FormAnimal();

            Hide();
            FormAnimal.Show();
        }
    }
}
