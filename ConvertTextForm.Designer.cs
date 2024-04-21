namespace ConvertText
{
    partial class ConvertTextForm
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
            selectFilesButton = new Button();
            convertFilesButton = new Button();
            SuspendLayout();
            // 
            // selectFilesButton
            // 
            selectFilesButton.Location = new Point(20, 50);
            selectFilesButton.Name = "selectFilesButton";
            selectFilesButton.Size = new Size(200, 50);
            selectFilesButton.TabIndex = 0;
            selectFilesButton.Text = "Seleccionar archivos";
            selectFilesButton.UseVisualStyleBackColor = true;
            selectFilesButton.Click += selectFilesButton_Click;
            // 
            // convertFilesButton
            // 
            convertFilesButton.Enabled = false;
            convertFilesButton.Location = new Point(20, 130);
            convertFilesButton.Name = "convertFilesButton";
            convertFilesButton.Size = new Size(200, 50);
            convertFilesButton.TabIndex = 1;
            convertFilesButton.Text = "Convertir cada archivo";
            convertFilesButton.UseVisualStyleBackColor = true;
            convertFilesButton.Click += convertFilesButton_Click;
            // 
            // ConvertTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(234, 211);
            Controls.Add(convertFilesButton);
            Controls.Add(selectFilesButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConvertTextForm";
            Text = " ";
            ResumeLayout(false);
        }

        #endregion

        private Button selectFilesButton;
        private Button convertFilesButton;
    }
}