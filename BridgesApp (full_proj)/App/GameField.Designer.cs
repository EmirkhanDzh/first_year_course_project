namespace App
{
    partial class GameField
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameField));
            this.getFocusLabel = new System.Windows.Forms.Label();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.nodeInfoButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.solveFieldButton = new System.Windows.Forms.Button();
            this.nextFieldButton = new System.Windows.Forms.Button();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.pauzeButton = new System.Windows.Forms.Button();
            this.selectFieldComboBox = new System.Windows.Forms.ComboBox();
            this.ToSelectedFieldButton = new System.Windows.Forms.Button();
            this.mainSolutionButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getFocusLabel
            // 
            this.getFocusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getFocusLabel.AutoSize = true;
            this.getFocusLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getFocusLabel.Location = new System.Drawing.Point(837, 36);
            this.getFocusLabel.Name = "getFocusLabel";
            this.getFocusLabel.Size = new System.Drawing.Size(0, 22);
            this.getFocusLabel.TabIndex = 0;
            this.getFocusLabel.Visible = false;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveResultButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveResultButton.Location = new System.Drawing.Point(216, 648);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(218, 45);
            this.saveResultButton.TabIndex = 1;
            this.saveResultButton.Text = "Сохранить результат";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.SaveResultButtonClick);
            // 
            // nodeInfoButton
            // 
            this.nodeInfoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nodeInfoButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nodeInfoButton.Location = new System.Drawing.Point(841, 518);
            this.nodeInfoButton.Name = "nodeInfoButton";
            this.nodeInfoButton.Size = new System.Drawing.Size(73, 46);
            this.nodeInfoButton.TabIndex = 3;
            this.nodeInfoButton.Text = "Информация";
            this.nodeInfoButton.UseVisualStyleBackColor = true;
            this.nodeInfoButton.Visible = false;
            this.nodeInfoButton.Click += new System.EventHandler(this.nodesInfoButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.White;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(447, 8);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(113, 33);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // solveFieldButton
            // 
            this.solveFieldButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.solveFieldButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveFieldButton.Location = new System.Drawing.Point(860, 466);
            this.solveFieldButton.Name = "solveFieldButton";
            this.solveFieldButton.Size = new System.Drawing.Size(54, 46);
            this.solveFieldButton.TabIndex = 5;
            this.solveFieldButton.Text = "Решить поле";
            this.solveFieldButton.UseVisualStyleBackColor = true;
            this.solveFieldButton.Visible = false;
            this.solveFieldButton.Click += new System.EventHandler(this.SolveGameFieldButton_Click);
            // 
            // nextFieldButton
            // 
            this.nextFieldButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextFieldButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextFieldButton.Location = new System.Drawing.Point(608, 648);
            this.nextFieldButton.Name = "nextFieldButton";
            this.nextFieldButton.Size = new System.Drawing.Size(164, 46);
            this.nextFieldButton.TabIndex = 6;
            this.nextFieldButton.Text = "К новому полю";
            this.nextFieldButton.UseVisualStyleBackColor = true;
            this.nextFieldButton.Click += new System.EventHandler(this.ToNewFieldButtonClick);
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tryAgainButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryAgainButton.Location = new System.Drawing.Point(41, 647);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(159, 45);
            this.tryAgainButton.TabIndex = 7;
            this.tryAgainButton.Text = "Решить заново";
            this.tryAgainButton.UseVisualStyleBackColor = true;
            this.tryAgainButton.Click += new System.EventHandler(this.TryAgainButtonClick);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(665, 7);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 33);
            this.idLabel.TabIndex = 8;
            // 
            // pauzeButton
            // 
            this.pauzeButton.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pauzeButton.Location = new System.Drawing.Point(12, 12);
            this.pauzeButton.Name = "pauzeButton";
            this.pauzeButton.Size = new System.Drawing.Size(105, 30);
            this.pauzeButton.TabIndex = 9;
            this.pauzeButton.Text = "Пауза";
            this.pauzeButton.UseVisualStyleBackColor = true;
            this.pauzeButton.Click += new System.EventHandler(this.PauzeButtonClick);
            // 
            // selectFieldComboBox
            // 
            this.selectFieldComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFieldComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFieldComboBox.FormattingEnabled = true;
            this.selectFieldComboBox.Location = new System.Drawing.Point(857, 47);
            this.selectFieldComboBox.Name = "selectFieldComboBox";
            this.selectFieldComboBox.Size = new System.Drawing.Size(107, 21);
            this.selectFieldComboBox.TabIndex = 10;
            // 
            // ToSelectedFieldButton
            // 
            this.ToSelectedFieldButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToSelectedFieldButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToSelectedFieldButton.Location = new System.Drawing.Point(781, 12);
            this.ToSelectedFieldButton.Name = "ToSelectedFieldButton";
            this.ToSelectedFieldButton.Size = new System.Drawing.Size(181, 29);
            this.ToSelectedFieldButton.TabIndex = 12;
            this.ToSelectedFieldButton.Text = "Перейти к полю";
            this.ToSelectedFieldButton.UseVisualStyleBackColor = true;
            this.ToSelectedFieldButton.Click += new System.EventHandler(this.TurnToFieldButtonClick);
            // 
            // mainSolutionButton
            // 
            this.mainSolutionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainSolutionButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainSolutionButton.Location = new System.Drawing.Point(781, 650);
            this.mainSolutionButton.Name = "mainSolutionButton";
            this.mainSolutionButton.Size = new System.Drawing.Size(190, 44);
            this.mainSolutionButton.TabIndex = 13;
            this.mainSolutionButton.Text = "Показать решение";
            this.mainSolutionButton.UseVisualStyleBackColor = true;
            this.mainSolutionButton.Click += new System.EventHandler(this.SolutionButtonClick);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(440, 648);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(162, 46);
            this.helpButton.TabIndex = 14;
            this.helpButton.Text = "Подсказка";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButtonClick);
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 704);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.mainSolutionButton);
            this.Controls.Add(this.ToSelectedFieldButton);
            this.Controls.Add(this.selectFieldComboBox);
            this.Controls.Add(this.pauzeButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.nextFieldButton);
            this.Controls.Add(this.solveFieldButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.nodeInfoButton);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.getFocusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 736);
            this.MinimumSize = new System.Drawing.Size(1000, 736);
            this.Name = "GameField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BridgesPuzzle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFieldFormClosing);
            this.Load += new System.EventHandler(this.GameFieldLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getFocusLabel;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button nodeInfoButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button solveFieldButton;
        private System.Windows.Forms.Button nextFieldButton;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button pauzeButton;
        private System.Windows.Forms.ComboBox selectFieldComboBox;
        private System.Windows.Forms.Button ToSelectedFieldButton;
        private System.Windows.Forms.Button mainSolutionButton;
        private System.Windows.Forms.Button helpButton;
    }
}