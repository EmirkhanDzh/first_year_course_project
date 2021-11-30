namespace App
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.hideRulesButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.diffLevelComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.recordsButton = new System.Windows.Forms.Button();
            this.diffLevelLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.gameInfoButton = new System.Windows.Forms.Button();
            this.rulesPanel = new System.Windows.Forms.Panel();
            this.rulesDescription = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hideGameInfoButton = new System.Windows.Forms.Button();
            this.gameInfoPanel = new System.Windows.Forms.Panel();
            this.recordsPanel = new System.Windows.Forms.Panel();
            this.clearAllRecords = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.chooseLevelLabel = new System.Windows.Forms.Label();
            this.chooseLevelComboBox = new System.Windows.Forms.ComboBox();
            this.hideRecordsButton = new System.Windows.Forms.Button();
            this.nextRulesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuPanel.SuspendLayout();
            this.rulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gameInfoPanel.SuspendLayout();
            this.recordsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hideRulesButton
            // 
            this.hideRulesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hideRulesButton.BackColor = System.Drawing.Color.White;
            this.hideRulesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.hideRulesButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.hideRulesButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.hideRulesButton.Location = new System.Drawing.Point(0, 596);
            this.hideRulesButton.Name = "hideRulesButton";
            this.hideRulesButton.Size = new System.Drawing.Size(167, 53);
            this.hideRulesButton.TabIndex = 6;
            this.hideRulesButton.Text = "Скрыть";
            this.hideRulesButton.UseVisualStyleBackColor = false;
            this.hideRulesButton.Click += new System.EventHandler(this.HideRulesButtonClick);
            // 
            // rulesButton
            // 
            this.rulesButton.BackColor = System.Drawing.Color.White;
            this.rulesButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.rulesButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.rulesButton.Location = new System.Drawing.Point(39, 288);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(179, 53);
            this.rulesButton.TabIndex = 3;
            this.rulesButton.Text = "Правила";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.RulesButtonClick);
            // 
            // diffLevelComboBox
            // 
            this.diffLevelComboBox.BackColor = System.Drawing.Color.DimGray;
            this.diffLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffLevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diffLevelComboBox.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffLevelComboBox.ForeColor = System.Drawing.Color.White;
            this.diffLevelComboBox.FormattingEnabled = true;
            this.diffLevelComboBox.Items.AddRange(new object[] {
            "     Легкий",
            "     Средний",
            "     Сложный"});
            this.diffLevelComboBox.Location = new System.Drawing.Point(39, 67);
            this.diffLevelComboBox.Name = "diffLevelComboBox";
            this.diffLevelComboBox.Size = new System.Drawing.Size(179, 41);
            this.diffLevelComboBox.TabIndex = 4;
            this.diffLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.DiffLevelComboBoxSelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.exitButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitButton.Location = new System.Drawing.Point(39, 612);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 53);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // recordsButton
            // 
            this.recordsButton.BackColor = System.Drawing.Color.White;
            this.recordsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.recordsButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.recordsButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.recordsButton.Location = new System.Drawing.Point(39, 508);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(179, 53);
            this.recordsButton.TabIndex = 1;
            this.recordsButton.Text = "Статистика";
            this.recordsButton.UseVisualStyleBackColor = false;
            this.recordsButton.Click += new System.EventHandler(this.StatisticsButtonClick);
            // 
            // diffLevelLabel
            // 
            this.diffLevelLabel.AutoSize = true;
            this.diffLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.diffLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffLevelLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.diffLevelLabel.Location = new System.Drawing.Point(35, 40);
            this.diffLevelLabel.Name = "diffLevelLabel";
            this.diffLevelLabel.Size = new System.Drawing.Size(191, 24);
            this.diffLevelLabel.TabIndex = 5;
            this.diffLevelLabel.Text = "Уровень сложности";
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.White;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startGameButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.startGameButton.Location = new System.Drawing.Point(39, 175);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(179, 53);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButtonClick);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuPanel.Controls.Add(this.gameInfoButton);
            this.mainMenuPanel.Controls.Add(this.diffLevelLabel);
            this.mainMenuPanel.Controls.Add(this.rulesButton);
            this.mainMenuPanel.Controls.Add(this.startGameButton);
            this.mainMenuPanel.Controls.Add(this.diffLevelComboBox);
            this.mainMenuPanel.Controls.Add(this.recordsButton);
            this.mainMenuPanel.Controls.Add(this.exitButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(2, -1);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(253, 705);
            this.mainMenuPanel.TabIndex = 8;
            // 
            // gameInfoButton
            // 
            this.gameInfoButton.BackColor = System.Drawing.Color.White;
            this.gameInfoButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.gameInfoButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.gameInfoButton.Location = new System.Drawing.Point(39, 401);
            this.gameInfoButton.Name = "gameInfoButton";
            this.gameInfoButton.Size = new System.Drawing.Size(179, 53);
            this.gameInfoButton.TabIndex = 6;
            this.gameInfoButton.Text = "Об игре";
            this.gameInfoButton.UseVisualStyleBackColor = false;
            this.gameInfoButton.Click += new System.EventHandler(this.GameInfoButtonClick);
            // 
            // rulesPanel
            // 
            this.rulesPanel.BackColor = System.Drawing.Color.Transparent;
            this.rulesPanel.Controls.Add(this.pictureBox3);
            this.rulesPanel.Controls.Add(this.pictureBox2);
            this.rulesPanel.Controls.Add(this.pictureBox1);
            this.rulesPanel.Controls.Add(this.nextRulesButton);
            this.rulesPanel.Controls.Add(this.hideRulesButton);
            this.rulesPanel.Controls.Add(this.rulesDescription);
            this.rulesPanel.Location = new System.Drawing.Point(261, 15);
            this.rulesPanel.Name = "rulesPanel";
            this.rulesPanel.Size = new System.Drawing.Size(730, 689);
            this.rulesPanel.TabIndex = 7;
            this.rulesPanel.Visible = false;
            // 
            // rulesDescription
            // 
            this.rulesDescription.AutoSize = true;
            this.rulesDescription.BackColor = System.Drawing.Color.Azure;
            this.rulesDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesDescription.Location = new System.Drawing.Point(0, 25);
            this.rulesDescription.Name = "rulesDescription";
            this.rulesDescription.Size = new System.Drawing.Size(723, 242);
            this.rulesDescription.TabIndex = 7;
            this.rulesDescription.Text = resources.GetString("rulesDescription.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Time,
            this.Player});
            this.dataGridView1.Location = new System.Drawing.Point(218, 162);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 319);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.ToolTipText = "Выберите уровень";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // hideGameInfoButton
            // 
            this.hideGameInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.hideGameInfoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.hideGameInfoButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideGameInfoButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.hideGameInfoButton.Location = new System.Drawing.Point(465, 584);
            this.hideGameInfoButton.Name = "hideGameInfoButton";
            this.hideGameInfoButton.Size = new System.Drawing.Size(220, 53);
            this.hideGameInfoButton.TabIndex = 7;
            this.hideGameInfoButton.Text = "Скрыть";
            this.hideGameInfoButton.UseVisualStyleBackColor = false;
            this.hideGameInfoButton.Click += new System.EventHandler(this.HideGameInfoButtonClick);
            // 
            // gameInfoPanel
            // 
            this.gameInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameInfoPanel.Controls.Add(this.label1);
            this.gameInfoPanel.Controls.Add(this.hideGameInfoButton);
            this.gameInfoPanel.Location = new System.Drawing.Point(261, 28);
            this.gameInfoPanel.Name = "gameInfoPanel";
            this.gameInfoPanel.Size = new System.Drawing.Size(717, 664);
            this.gameInfoPanel.TabIndex = 9;
            this.gameInfoPanel.Visible = false;
            // 
            // recordsPanel
            // 
            this.recordsPanel.BackColor = System.Drawing.Color.Transparent;
            this.recordsPanel.Controls.Add(this.dataGridView1);
            this.recordsPanel.Controls.Add(this.clearAllRecords);
            this.recordsPanel.Controls.Add(this.deleteRecordButton);
            this.recordsPanel.Controls.Add(this.chooseLevelLabel);
            this.recordsPanel.Controls.Add(this.chooseLevelComboBox);
            this.recordsPanel.Controls.Add(this.hideRecordsButton);
            this.recordsPanel.Location = new System.Drawing.Point(261, 12);
            this.recordsPanel.Name = "recordsPanel";
            this.recordsPanel.Size = new System.Drawing.Size(665, 689);
            this.recordsPanel.TabIndex = 10;
            this.recordsPanel.Visible = false;
            // 
            // clearAllRecords
            // 
            this.clearAllRecords.BackColor = System.Drawing.Color.White;
            this.clearAllRecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearAllRecords.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.clearAllRecords.ForeColor = System.Drawing.Color.DarkBlue;
            this.clearAllRecords.Location = new System.Drawing.Point(19, 248);
            this.clearAllRecords.Name = "clearAllRecords";
            this.clearAllRecords.Size = new System.Drawing.Size(182, 40);
            this.clearAllRecords.TabIndex = 11;
            this.clearAllRecords.Text = "Очистить все";
            this.clearAllRecords.UseVisualStyleBackColor = false;
            this.clearAllRecords.Click += new System.EventHandler(this.ClearAllRecordsClick);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.BackColor = System.Drawing.Color.White;
            this.deleteRecordButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteRecordButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.deleteRecordButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.deleteRecordButton.Location = new System.Drawing.Point(19, 202);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(182, 40);
            this.deleteRecordButton.TabIndex = 10;
            this.deleteRecordButton.Text = "Удалить запись";
            this.deleteRecordButton.UseVisualStyleBackColor = false;
            this.deleteRecordButton.Click += new System.EventHandler(this.DeleteRecordsButtonClick);
            // 
            // chooseLevelLabel
            // 
            this.chooseLevelLabel.AutoSize = true;
            this.chooseLevelLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLevelLabel.Location = new System.Drawing.Point(22, 137);
            this.chooseLevelLabel.Name = "chooseLevelLabel";
            this.chooseLevelLabel.Size = new System.Drawing.Size(174, 26);
            this.chooseLevelLabel.TabIndex = 9;
            this.chooseLevelLabel.Text = "Выберите уровень";
            // 
            // chooseLevelComboBox
            // 
            this.chooseLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseLevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseLevelComboBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLevelComboBox.FormattingEnabled = true;
            this.chooseLevelComboBox.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Сложный"});
            this.chooseLevelComboBox.Location = new System.Drawing.Point(22, 162);
            this.chooseLevelComboBox.Name = "chooseLevelComboBox";
            this.chooseLevelComboBox.Size = new System.Drawing.Size(179, 34);
            this.chooseLevelComboBox.TabIndex = 8;
            this.chooseLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.СhooseLevelComboBoxSelectedIndexChanged);
            // 
            // hideRecordsButton
            // 
            this.hideRecordsButton.BackColor = System.Drawing.Color.White;
            this.hideRecordsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.hideRecordsButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideRecordsButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.hideRecordsButton.Location = new System.Drawing.Point(496, 598);
            this.hideRecordsButton.Name = "hideRecordsButton";
            this.hideRecordsButton.Size = new System.Drawing.Size(166, 54);
            this.hideRecordsButton.TabIndex = 7;
            this.hideRecordsButton.Text = "Скрыть";
            this.hideRecordsButton.UseVisualStyleBackColor = false;
            this.hideRecordsButton.Click += new System.EventHandler(this.HideStatisticsButtonClick);
            // 
            // nextRulesButton
            // 
            this.nextRulesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextRulesButton.BackColor = System.Drawing.Color.White;
            this.nextRulesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.nextRulesButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.nextRulesButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.nextRulesButton.Location = new System.Drawing.Point(553, 595);
            this.nextRulesButton.Name = "nextRulesButton";
            this.nextRulesButton.Size = new System.Drawing.Size(170, 53);
            this.nextRulesButton.TabIndex = 9;
            this.nextRulesButton.Text = "Следующее";
            this.nextRulesButton.UseVisualStyleBackColor = false;
            this.nextRulesButton.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(311, 419);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Данный программный продукт является курсовой работой студента БПИ197 \r\n1 курса Пр" +
    "ограммной инженерии ФКН Джапарова Эмирхана\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 704);
            this.Controls.Add(this.gameInfoPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.recordsPanel);
            this.Controls.Add(this.rulesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 736);
            this.MinimumSize = new System.Drawing.Size(1000, 736);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BridgesPuzzle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.rulesPanel.ResumeLayout(false);
            this.rulesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gameInfoPanel.ResumeLayout(false);
            this.gameInfoPanel.PerformLayout();
            this.recordsPanel.ResumeLayout(false);
            this.recordsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hideRulesButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.ComboBox diffLevelComboBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button recordsButton;
        private System.Windows.Forms.Label diffLevelLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel rulesPanel;
        private System.Windows.Forms.Button hideGameInfoButton;
        private System.Windows.Forms.Panel gameInfoPanel;
        private System.Windows.Forms.Button gameInfoButton;
        private System.Windows.Forms.Label rulesDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel recordsPanel;
        private System.Windows.Forms.Button hideRecordsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.Label chooseLevelLabel;
        private System.Windows.Forms.ComboBox chooseLevelComboBox;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button clearAllRecords;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextRulesButton;
        private System.Windows.Forms.Label label1;
    }
}

