namespace Vocab
{
    partial class Form1
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
            this.checkButton = new System.Windows.Forms.Button();
            this.vocabText = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.aUmlautButton = new System.Windows.Forms.Button();
            this.oUmlautButton = new System.Windows.Forms.Button();
            this.uUmlautButton = new System.Windows.Forms.Button();
            this.eszettButton = new System.Windows.Forms.Button();
            this.uCapUmlautButton = new System.Windows.Forms.Button();
            this.oCapUmlautButton = new System.Windows.Forms.Button();
            this.aCapUmlautButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(234, 384);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // vocabText
            // 
            this.vocabText.AutoSize = true;
            this.vocabText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocabText.Location = new System.Drawing.Point(25, 141);
            this.vocabText.Name = "vocabText";
            this.vocabText.Size = new System.Drawing.Size(274, 39);
            this.vocabText.TabIndex = 1;
            this.vocabText.Text = "Vocab goes here";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(28, 223);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(320, 42);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aUmlautButton
            // 
            this.aUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aUmlautButton.Location = new System.Drawing.Point(240, 271);
            this.aUmlautButton.Name = "aUmlautButton";
            this.aUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.aUmlautButton.TabIndex = 3;
            this.aUmlautButton.Text = "ä";
            this.aUmlautButton.UseVisualStyleBackColor = true;
            this.aUmlautButton.Click += new System.EventHandler(this.aUmlautButton_Click);
            // 
            // oUmlautButton
            // 
            this.oUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oUmlautButton.Location = new System.Drawing.Point(278, 271);
            this.oUmlautButton.Name = "oUmlautButton";
            this.oUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.oUmlautButton.TabIndex = 4;
            this.oUmlautButton.Text = "ö";
            this.oUmlautButton.UseVisualStyleBackColor = true;
            this.oUmlautButton.Click += new System.EventHandler(this.oUmlautButton_Click);
            // 
            // uUmlautButton
            // 
            this.uUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uUmlautButton.Location = new System.Drawing.Point(316, 271);
            this.uUmlautButton.Name = "uUmlautButton";
            this.uUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.uUmlautButton.TabIndex = 5;
            this.uUmlautButton.Text = "ü";
            this.uUmlautButton.UseVisualStyleBackColor = true;
            this.uUmlautButton.Click += new System.EventHandler(this.uUmlautButton_Click);
            // 
            // eszettButton
            // 
            this.eszettButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eszettButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eszettButton.Location = new System.Drawing.Point(202, 271);
            this.eszettButton.Name = "eszettButton";
            this.eszettButton.Size = new System.Drawing.Size(32, 32);
            this.eszettButton.TabIndex = 6;
            this.eszettButton.Text = "ß";
            this.eszettButton.UseVisualStyleBackColor = true;
            this.eszettButton.Click += new System.EventHandler(this.eszettButton_Click);
            // 
            // uCapUmlautButton
            // 
            this.uCapUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uCapUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCapUmlautButton.Location = new System.Drawing.Point(316, 309);
            this.uCapUmlautButton.Name = "uCapUmlautButton";
            this.uCapUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.uCapUmlautButton.TabIndex = 9;
            this.uCapUmlautButton.Text = "Ü";
            this.uCapUmlautButton.UseVisualStyleBackColor = true;
            this.uCapUmlautButton.Click += new System.EventHandler(this.uCapUmlautButton_Click);
            // 
            // oCapUmlautButton
            // 
            this.oCapUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oCapUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCapUmlautButton.Location = new System.Drawing.Point(278, 309);
            this.oCapUmlautButton.Name = "oCapUmlautButton";
            this.oCapUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.oCapUmlautButton.TabIndex = 8;
            this.oCapUmlautButton.Text = "Ö";
            this.oCapUmlautButton.UseVisualStyleBackColor = true;
            this.oCapUmlautButton.Click += new System.EventHandler(this.oCapUmlautButton_Click);
            // 
            // aCapUmlautButton
            // 
            this.aCapUmlautButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aCapUmlautButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCapUmlautButton.Location = new System.Drawing.Point(240, 309);
            this.aCapUmlautButton.Name = "aCapUmlautButton";
            this.aCapUmlautButton.Size = new System.Drawing.Size(32, 32);
            this.aCapUmlautButton.TabIndex = 7;
            this.aCapUmlautButton.Text = "Ä";
            this.aCapUmlautButton.UseVisualStyleBackColor = true;
            this.aCapUmlautButton.Click += new System.EventHandler(this.aCapUmlautButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 461);
            this.Controls.Add(this.uCapUmlautButton);
            this.Controls.Add(this.oCapUmlautButton);
            this.Controls.Add(this.aCapUmlautButton);
            this.Controls.Add(this.eszettButton);
            this.Controls.Add(this.uUmlautButton);
            this.Controls.Add(this.oUmlautButton);
            this.Controls.Add(this.aUmlautButton);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.vocabText);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label vocabText;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button aUmlautButton;
        private System.Windows.Forms.Button oUmlautButton;
        private System.Windows.Forms.Button uUmlautButton;
        private System.Windows.Forms.Button eszettButton;
        private System.Windows.Forms.Button uCapUmlautButton;
        private System.Windows.Forms.Button oCapUmlautButton;
        private System.Windows.Forms.Button aCapUmlautButton;
    }
}

