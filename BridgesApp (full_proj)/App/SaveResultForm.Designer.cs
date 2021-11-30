namespace App
{
    partial class SaveResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveResultForm));
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameLabel.Location = new System.Drawing.Point(60, 20);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(229, 30);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "Введите свое имя";
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.inputNameTextBox.Location = new System.Drawing.Point(47, 73);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(251, 40);
            this.inputNameTextBox.TabIndex = 1;
            this.inputNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputNameTextBoxKeyDown);
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.Gainsboro;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.inputButton.Location = new System.Drawing.Point(173, 132);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(125, 45);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Готово";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.InputButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.cancelButton.Location = new System.Drawing.Point(47, 132);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 45);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SaveResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 209);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputNameTextBox);
            this.Controls.Add(this.inputNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(345, 241);
            this.Name = "SaveResultForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputNameLabel;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button cancelButton;
    }
}