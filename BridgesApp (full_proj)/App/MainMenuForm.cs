using System;
using System.Drawing;
using System.Windows.Forms;
using ParserLib;
namespace App
{
    public partial class MainMenuForm : Form
    {
        // Директория файлов со статистикой о прорешенных или просмотренных заданий.
        const string pathEasyLevelStatistics = "resources/EasyLevelStatistics.khan";
        const string pathMediumLevelStatistics = "resources/MediumLevelStatistics.khan";
        const string pathHardLevelStatistics = "resources/HardLevelStatistics.khan";
        public MainMenuForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            deleteRecordButton.Visible = false;
            clearAllRecords.Visible = false;
        }

        /// <summary>
        /// Обработчик процесса закрывания окна. Выходит диалоговое окно, уточняющее
        /// на самом ли деле пользователь хочет покинуть игру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    if (MessageBox.Show("Вы хотите выйти?", "Выход", MessageBoxButtons.YesNo,
        //                        MessageBoxIcon.Question) == DialogResult.No)
        //        e.Cancel = true;
        //    else
        //        Application.Exit();
        //}//

        /// <summary>
        /// Обработчик события нажатия на кнопку "Начать игру". 
        /// Создается объект второй формы и запускается процесс игры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameButtonClick(object sender, EventArgs e)
        {
            if (choisedLevel != diffLevelComboBox.Items[0].ToString() && choisedLevel != diffLevelComboBox.Items[1].ToString() && choisedLevel != diffLevelComboBox.Items[2].ToString())
            {
                MessageBox.Show("Выберите уровень сложности для начала игры!", "Внимание!");
                diffLevelComboBox.Select();
                return;
            }
            this.Hide();
            if (diffLevelComboBox.SelectedIndex == 0)
            {
                GameField gameField = new GameField(0);
                gameField.ShowDialog();
            }
            if (diffLevelComboBox.SelectedIndex == 1)
            {
                GameField gameField = new GameField(1);
                gameField.ShowDialog();
            }
            if (diffLevelComboBox.SelectedIndex == 2)
            {
                GameField gameField = new GameField(2);
                gameField.ShowDialog();
            }
            this.Show();
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Выход".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        // Выбранный пользователем уровень.
        string choisedLevel;
        /// <summary>
        /// Обработчик выбора уровня для начала игры.
        /// Инициализируется переменная со значением выбранного уровня.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiffLevelComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (diffLevelComboBox.SelectedIndex == 0)
            {
                diffLevelComboBox.BackColor = Color.DeepSkyBlue;
            }
            if (diffLevelComboBox.SelectedIndex == 1)
            {
                diffLevelComboBox.BackColor = Color.RoyalBlue;
            }
            if (diffLevelComboBox.SelectedIndex == 2)
            {
                diffLevelComboBox.BackColor = Color.DarkBlue;
            }

            startGameButton.Select();
            choisedLevel = (string)diffLevelComboBox.SelectedItem;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Правила".
        /// Пользователю предлагается изучить правила и пройти обучение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RulesButtonClick(object sender, EventArgs e)
        {
            recordsPanel.Visible = false;
            gameInfoPanel.Visible = false;
            rulesPanel.Visible = true;

        }
        /// <summary>
        /// Обработчик нажатия кнопки "Скрыть", когда открыта часть окна с Правилами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideRulesButtonClick(object sender, EventArgs e)
        {
            rulesPanel.Visible = false;
        }
        // Массив строк из файла статистики о прорешенных пользователями заданиях.
        string[] dataFromStatisticsFile;

        /// <summary>
        /// Обработчик нажатия на кнопку "Статистика".
        /// Пользователю открывается статистика о всех прорешенных заданиях на выбранном уровне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatisticsButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите уровень для которого хотите посмотреть все рекорды.", "Выберите уровень", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            chooseLevelComboBox.Select();
            gameInfoPanel.Visible = false;
            rulesPanel.Visible = false;
            recordsPanel.Visible = true;
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Скрыть", когда открыта часть окна описания игры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideGameInfoButtonClick(object sender, EventArgs e)
        {
            hideGameInfoButton.Parent.Visible = false;
        }

        /// <summary>
        /// Обработчик события закрытия игры.
        /// У пользователя уточняется, уверен ли он покинуть игру ?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите выйти?", "Выход", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Скрыть", когда открыта часть окна о статистике.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideStatisticsButtonClick(object sender, EventArgs e)
        {

            recordsPanel.Visible = false;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Об игре".
        /// Пользователю откроется описание продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameInfoButtonClick(object sender, EventArgs e)
        {
            rulesPanel.Visible = false;
            recordsPanel.Visible = false;
            gameInfoPanel.Visible = true;
        }

        // Информация о строках элемента DataGridView.
        string[] dataFromDataGrid;
        /// <summary>
        /// Обработчик нажатия на кнопку "Удалить результат" в окне статистики.
        /// Удаляются выбранные пользователем строки и из таблицы, и из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRecordsButtonClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Для удаления рекорда выберите соответствующую строку!", "Удаление рекорда.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            dataFromDataGrid = new string[dataGridView1.Rows.Count];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataFromDataGrid[i] += j != dataGridView1.ColumnCount - 1 ? dataGridView1[j, i].Value.ToString() + ";" : dataGridView1[j, i].Value.ToString();
                }
            }
            if (chooseLevelComboBox.SelectedIndex == 0)
                Parser.WriteLines(pathEasyLevelStatistics, dataFromDataGrid);
            if (chooseLevelComboBox.SelectedIndex == 1)
                Parser.WriteLines(pathMediumLevelStatistics, dataFromDataGrid);
            if (chooseLevelComboBox.SelectedIndex == 2)
                Parser.WriteLines(pathHardLevelStatistics, dataFromDataGrid);
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Очистить статистику" в окне статистики.
        /// Удаляятся вся информация и из таблицы, и из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllRecordsClick(object sender, EventArgs e)
        {
            if (chooseLevelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Для того, чтобы очистить рекорды, выберите уровень!", "Очистка всех рекордов.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Clear();
            if (chooseLevelComboBox.SelectedIndex == 0)
                Parser.DeleteFile(pathEasyLevelStatistics);
            if (chooseLevelComboBox.SelectedIndex == 1)
                Parser.DeleteFile(pathMediumLevelStatistics);
            if (chooseLevelComboBox.SelectedIndex == 2)
                Parser.DeleteFile(pathHardLevelStatistics);
        }


        /// <summary>
        /// Обработчик события выбора уровня для выведения статистики.
        /// При срабатывании события в DataGridView выводится статистика
        /// о решенных пользователями полях на выбранном уровне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СhooseLevelComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseLevelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите уровень для которого хотите посмотреть все рекорды.", "Выберите уровень", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            deleteRecordButton.Visible = true;
            clearAllRecords.Visible = true;
            dataGridView1.Rows.Clear();
            if (chooseLevelComboBox.SelectedIndex == 0 && Parser.FileExists(pathEasyLevelStatistics))
            {
                dataFromStatisticsFile = Parser.ReadAll(pathEasyLevelStatistics);

                if (dataFromStatisticsFile.Length > 0)
                {
                    for (int i = 0; i < dataFromStatisticsFile.Length; i++)
                    {
                        dataGridView1.Rows.Add(dataFromStatisticsFile[i].Split(';'));
                    }
                    return;
                }

            }
            if (chooseLevelComboBox.SelectedIndex == 1 && Parser.FileExists(pathMediumLevelStatistics))
            {
                dataFromStatisticsFile = Parser.ReadAll(pathMediumLevelStatistics);
                if (dataFromStatisticsFile.Length > 0)
                {

                    for (int i = 0; i < dataFromStatisticsFile.Length; i++)
                    {
                        dataGridView1.Rows.Add(dataFromStatisticsFile[i].Split(';'));
                    }
                    return;
                }


            }
            if (chooseLevelComboBox.SelectedIndex == 2 && Parser.FileExists(pathHardLevelStatistics))
            {
                dataFromStatisticsFile = Parser.ReadAll(pathHardLevelStatistics);
                if (dataFromStatisticsFile.Length > 0)
                {

                    for (int i = 0; i < dataFromStatisticsFile.Length; i++)
                    {
                        dataGridView1.Rows.Add(dataFromStatisticsFile[i].Split(';'));
                    }
                    return;
                }

            }
            MessageBox.Show("Данные не найдены!", "Нет данных.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
