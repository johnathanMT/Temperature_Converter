namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNum1 = new Label();
            txtInput = new TextBox();
            groupBox1 = new GroupBox();
            rbFtoC = new RadioButton();
            rbCtoF = new RadioButton();
            btnConvert = new Button();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(141, 64);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(173, 21);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Enter the Temperature";
            lblNum1.Click += lblNum1_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(353, 56);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(169, 29);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(rbFtoC);
            groupBox1.Controls.Add(rbCtoF);
            groupBox1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(111, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 180);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbFtoC
            // 
            rbFtoC.AutoSize = true;
            rbFtoC.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbFtoC.Location = new Point(165, 101);
            rbFtoC.Name = "rbFtoC";
            rbFtoC.Size = new Size(181, 23);
            rbFtoC.TabIndex = 1;
            rbFtoC.TabStop = true;
            rbFtoC.Text = "Fahrenheit to Celscius";
            rbFtoC.UseVisualStyleBackColor = true;
            // 
            // rbCtoF
            // 
            rbCtoF.AutoSize = true;
            rbCtoF.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbCtoF.Location = new Point(165, 44);
            rbCtoF.Name = "rbCtoF";
            rbCtoF.Size = new Size(181, 23);
            rbCtoF.TabIndex = 0;
            rbCtoF.TabStop = true;
            rbCtoF.Text = "Celscius to Fahrenheit";
            rbCtoF.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Info;
            btnConvert.Location = new Point(275, 300);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(176, 38);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.WindowFrame;
            lblResult.Location = new Point(175, 359);
            lblResult.MaximumSize = new Size(400, 200);
            lblResult.MinimumSize = new Size(400, 200);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(400, 200);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result will appear here";
            lblResult.TextAlign = ContentAlignment.TopCenter;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(groupBox1);
            Controls.Add(txtInput);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Temperature Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtInput;
        private GroupBox groupBox1;
        private RadioButton rbFtoC;
        private RadioButton rbCtoF;
        private Button btnConvert;
        private Label lblResult;
    }
}
