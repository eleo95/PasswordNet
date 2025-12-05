namespace PasswordNet
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
            textResult = new TextBox();
            checkLower = new CheckBox();
            checkUpper = new CheckBox();
            checkNumbers = new CheckBox();
            checkSymbols = new CheckBox();
            inputSize = new NumericUpDown();
            btnGenerate = new Button();
            groupCheckBox = new GroupBox();
            groupNumInput = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)inputSize).BeginInit();
            groupCheckBox.SuspendLayout();
            groupNumInput.SuspendLayout();
            SuspendLayout();
            // 
            // textResult
            // 
            textResult.BorderStyle = BorderStyle.None;
            textResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textResult.Location = new Point(12, 24);
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(198, 43);
            textResult.TabIndex = 0;
            textResult.TextAlign = HorizontalAlignment.Center;
            // 
            // checkLower
            // 
            checkLower.AutoSize = true;
            checkLower.Location = new Point(25, 22);
            checkLower.Name = "checkLower";
            checkLower.Size = new Size(42, 19);
            checkLower.TabIndex = 1;
            checkLower.Text = "a-z";
            checkLower.UseVisualStyleBackColor = true;
            // 
            // checkUpper
            // 
            checkUpper.AutoSize = true;
            checkUpper.Location = new Point(112, 22);
            checkUpper.Name = "checkUpper";
            checkUpper.Size = new Size(46, 19);
            checkUpper.TabIndex = 2;
            checkUpper.Text = "A-Z";
            checkUpper.UseVisualStyleBackColor = true;
            // 
            // checkNumbers
            // 
            checkNumbers.AutoSize = true;
            checkNumbers.Location = new Point(25, 70);
            checkNumbers.Name = "checkNumbers";
            checkNumbers.Size = new Size(43, 19);
            checkNumbers.TabIndex = 3;
            checkNumbers.Text = "0-9";
            checkNumbers.UseVisualStyleBackColor = true;
            // 
            // checkSymbols
            // 
            checkSymbols.AutoSize = true;
            checkSymbols.Location = new Point(112, 70);
            checkSymbols.Name = "checkSymbols";
            checkSymbols.Size = new Size(76, 19);
            checkSymbols.TabIndex = 4;
            checkSymbols.Text = "!@#$%^&*";
            checkSymbols.UseVisualStyleBackColor = true;
            // 
            // inputSize
            // 
            inputSize.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputSize.Location = new Point(11, 22);
            inputSize.Name = "inputSize";
            inputSize.Size = new Size(177, 35);
            inputSize.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(70, 314);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 34);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generar";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // groupCheckBox
            // 
            groupCheckBox.Controls.Add(checkLower);
            groupCheckBox.Controls.Add(checkUpper);
            groupCheckBox.Controls.Add(checkSymbols);
            groupCheckBox.Controls.Add(checkNumbers);
            groupCheckBox.Location = new Point(12, 167);
            groupCheckBox.Name = "groupCheckBox";
            groupCheckBox.Size = new Size(198, 108);
            groupCheckBox.TabIndex = 7;
            groupCheckBox.TabStop = false;
            groupCheckBox.Text = "Incluir";
            // 
            // groupNumInput
            // 
            groupNumInput.Controls.Add(inputSize);
            groupNumInput.Location = new Point(12, 89);
            groupNumInput.Name = "groupNumInput";
            groupNumInput.Size = new Size(198, 72);
            groupNumInput.TabIndex = 8;
            groupNumInput.TabStop = false;
            groupNumInput.Text = "Tamaño";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 450);
            Controls.Add(btnGenerate);
            Controls.Add(groupNumInput);
            Controls.Add(groupCheckBox);
            Controls.Add(textResult);
            Name = "Form1";
            Text = "PkGen.NET";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)inputSize).EndInit();
            groupCheckBox.ResumeLayout(false);
            groupCheckBox.PerformLayout();
            groupNumInput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResult;
        private CheckBox checkLower;
        private CheckBox checkUpper;
        private CheckBox checkNumbers;
        private CheckBox checkSymbols;
        private NumericUpDown inputSize;
        private Button btnGenerate;
        private GroupBox groupCheckBox;
        private GroupBox groupNumInput;
    }
}
