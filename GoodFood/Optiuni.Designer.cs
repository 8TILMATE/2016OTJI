
namespace GoodFood
{
    partial class Optiuni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.Comanda = new System.Windows.Forms.TabPage();
            this.Meniu = new System.Windows.Forms.TabPage();
            this.Grafic = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Calculator);
            this.tabControl1.Controls.Add(this.Comanda);
            this.tabControl1.Controls.Add(this.Meniu);
            this.tabControl1.Controls.Add(this.Grafic);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // Calculator
            // 
            this.Calculator.Location = new System.Drawing.Point(4, 25);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.Calculator.Size = new System.Drawing.Size(779, 409);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "CalculatorKcal";
            this.Calculator.UseVisualStyleBackColor = true;
            // 
            // Comanda
            // 
            this.Comanda.Location = new System.Drawing.Point(4, 25);
            this.Comanda.Name = "Comanda";
            this.Comanda.Padding = new System.Windows.Forms.Padding(3);
            this.Comanda.Size = new System.Drawing.Size(779, 409);
            this.Comanda.TabIndex = 1;
            this.Comanda.Text = "Comanda";
            this.Comanda.UseVisualStyleBackColor = true;
            // 
            // Meniu
            // 
            this.Meniu.Location = new System.Drawing.Point(4, 25);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(779, 409);
            this.Meniu.TabIndex = 2;
            this.Meniu.Text = "Generare Meniu";
            this.Meniu.UseVisualStyleBackColor = true;
            // 
            // Grafic
            // 
            this.Grafic.Location = new System.Drawing.Point(4, 25);
            this.Grafic.Name = "Grafic";
            this.Grafic.Size = new System.Drawing.Size(779, 409);
            this.Grafic.TabIndex = 3;
            this.Grafic.Text = "Grafic Kcal";
            this.Grafic.UseVisualStyleBackColor = true;
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.Text = "Optiuni";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.TabPage Comanda;
        private System.Windows.Forms.TabPage Meniu;
        private System.Windows.Forms.TabPage Grafic;
    }
}