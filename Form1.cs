using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace PR5
{
    public partial class Form1 : Form
    {

        int labelX = 280;
        int labelY = 20;
        int buttonX = 100;
        int buttonY = 100;
        int textBoxX = 400;
        int textBoxY = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Parent = this;
            label1.Location = new Point(labelX, labelY);
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.AutoSize = true;
            label1.Text = "Практическая работа №5\n\t  КЛАССЫ И ОБЪЕКТЫ";
            label1.Click += new System.EventHandler(this.label1_Click);


            Button button = new Button();
            button.Parent = this;
            button.Location = new Point(buttonX, buttonY);
            button.Text = "Позовем моих друзей?";
            button.AutoSize = true;
            button.Click += new System.EventHandler(this.button_Click);

            TextBox textBox = new TextBox();
            textBox.Parent = this;
            textBox.Location = new Point(textBoxX, textBoxY);
            textBox.Text = "А моих позовем?";
            textBox.AutoSize = true;
            textBox.Click += new System.EventHandler(this.textBox_Click);

        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Parent = this;

            Random rnd = new Random();

            textBox.Text = "Я пришел!";
            textBox.AutoSize = true;

            textBoxX = rnd.Next(0, Size.Width - (textBox.Width + 20));
            textBoxY = rnd.Next(0, Size.Height - (textBox.Height+ 20));

            textBox.Location = new Point(textBoxX, textBoxY);
      
            textBox.Click += new System.EventHandler(this.textBox_Click);
        }
            private void label1_Click(object sender, EventArgs e)
        {
        
            Label label1 = new Label();
            label1.Parent = this;
            label1.AutoSize = true;

            Random rnd = new Random();
            labelX = rnd.Next(0, Size.Width - (label1.Width + 20));
            labelY = rnd.Next(0, Size.Height - (label1.Height + 20));

            label1.Location = new Point(labelX, labelY);
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Text = "Практическая работа №5\n\t  КЛАССЫ И ОБЪЕКТЫ";
            label1.Click += new System.EventHandler(this.label1_Click);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
     
            Button button = new Button();
            button.Parent = this;
            button.AutoSize = true;
            buttonX = rnd.Next(0, Size.Width - button.Width);
            buttonY = rnd.Next(0, Size.Height - button.Height);
            button.Location = new Point(buttonX, buttonY);
            button.Text = "Я пришел!)";
         
            button.Click += new System.EventHandler(this.button_Click);


        }

    }
}
