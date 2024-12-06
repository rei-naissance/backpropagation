using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace backpropagation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.trainNeuralNetButton = new System.Windows.Forms.Button();
            this.neuralNetOutputBox = new System.Windows.Forms.RichTextBox();
            this.inputBox1 = new System.Windows.Forms.RichTextBox();
            this.inputBox2 = new System.Windows.Forms.RichTextBox();
            this.inputBox3 = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.createNeuralNetButton = new System.Windows.Forms.Button();
            this.testNeuralNetButton = new System.Windows.Forms.Button();
            this.inputBox4 = new System.Windows.Forms.RichTextBox();
            this.testResultBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // trainNeuralNetButton
            // 
            this.trainNeuralNetButton.Location = new System.Drawing.Point(224, 174);
            this.trainNeuralNetButton.Name = "trainNeuralNetButton";
            this.trainNeuralNetButton.Size = new System.Drawing.Size(123, 52);
            this.trainNeuralNetButton.TabIndex = 0;
            this.trainNeuralNetButton.Text = "Train";
            this.trainNeuralNetButton.UseVisualStyleBackColor = true;
            // 
            // neuralNetOutputBox
            // 
            this.neuralNetOutputBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.neuralNetOutputBox.Location = new System.Drawing.Point(224, 34);
            this.neuralNetOutputBox.Name = "neuralNetOutputBox";
            this.neuralNetOutputBox.ReadOnly = true;
            this.neuralNetOutputBox.Size = new System.Drawing.Size(249, 55);
            this.neuralNetOutputBox.TabIndex = 1;
            this.neuralNetOutputBox.Text = "";
            // 
            // inputBox1
            // 
            this.inputBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox1.Location = new System.Drawing.Point(46, 34);
            this.inputBox1.Multiline = false;
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(123, 44);
            this.inputBox1.TabIndex = 2;
            this.inputBox1.Text = "";
            // 
            // inputBox2
            // 
            this.inputBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox2.Location = new System.Drawing.Point(46, 92);
            this.inputBox2.Multiline = false;
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(123, 45);
            this.inputBox2.TabIndex = 3;
            this.inputBox2.Text = "";
            // 
            // inputBox3
            // 
            this.inputBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox3.Location = new System.Drawing.Point(46, 151);
            this.inputBox3.Multiline = false;
            this.inputBox3.Name = "inputBox3";
            this.inputBox3.Size = new System.Drawing.Size(123, 42);
            this.inputBox3.TabIndex = 4;
            this.inputBox3.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(46, 260);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(123, 49);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // createNeuralNetButton
            // 
            this.createNeuralNetButton.Location = new System.Drawing.Point(224, 241);
            this.createNeuralNetButton.Name = "createNeuralNetButton";
            this.createNeuralNetButton.Size = new System.Drawing.Size(123, 51);
            this.createNeuralNetButton.TabIndex = 6;
            this.createNeuralNetButton.Text = "Create Neural Network";
            this.createNeuralNetButton.UseVisualStyleBackColor = true;
            // 
            // testNeuralNetButton
            // 
            this.testNeuralNetButton.Location = new System.Drawing.Point(363, 174);
            this.testNeuralNetButton.Name = "testNeuralNetButton";
            this.testNeuralNetButton.Size = new System.Drawing.Size(110, 52);
            this.testNeuralNetButton.TabIndex = 7;
            this.testNeuralNetButton.Text = "Test";
            this.testNeuralNetButton.UseVisualStyleBackColor = true;
            // 
            // inputBox4
            // 
            this.inputBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox4.Location = new System.Drawing.Point(46, 209);
            this.inputBox4.Multiline = false;
            this.inputBox4.Name = "inputBox4";
            this.inputBox4.Size = new System.Drawing.Size(123, 40);
            this.inputBox4.TabIndex = 8;
            this.inputBox4.Text = "";
            // 
            // testResultBox
            // 
            this.testResultBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.testResultBox.Location = new System.Drawing.Point(224, 101);
            this.testResultBox.Name = "testResultBox";
            this.testResultBox.ReadOnly = true;
            this.testResultBox.Size = new System.Drawing.Size(249, 55);
            this.testResultBox.TabIndex = 9;
            this.testResultBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.testResultBox);
            this.Controls.Add(this.inputBox4);
            this.Controls.Add(this.testNeuralNetButton);
            this.Controls.Add(this.createNeuralNetButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.inputBox3);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.neuralNetOutputBox);
            this.Controls.Add(this.trainNeuralNetButton);
            this.Name = "Form1";
            this.Text = "Neural Network Trainer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button trainNeuralNetButton;
        private RichTextBox neuralNetOutputBox;
        private RichTextBox inputBox1;
        private RichTextBox inputBox2;
        private RichTextBox inputBox3;
        private Button resetButton;
        private Button createNeuralNetButton;
        private Button testNeuralNetButton;
        private RichTextBox inputBox4;
        private RichTextBox testResultBox;
    }
}
