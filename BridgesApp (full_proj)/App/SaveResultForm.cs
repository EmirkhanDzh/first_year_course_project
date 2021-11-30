using System;
using System.Windows.Forms;
namespace App
{
    public partial class SaveResultForm : Form
    {
        public SaveResultForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Имя пользователя для сохранения результата решения текущего игрового поля.
        /// </summary>
        string nameForStatistics;
        /// <summary>
        /// Свойство с доступом к полю nameForStatistics. Возвразщает имя пользователя.
        /// </summary>
        public string NameForStatistics { get => nameForStatistics; set => nameForStatistics = value; }

        /// <summary>
        /// Обработчик события изменения текста в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNameTextBoxTextChanged(object sender, EventArgs e)
        {
            CancelClicked = false;
        }
        /// <summary>
        /// Метод проверки на то, вводится ли корректное значение для сохранения результата.
        /// </summary>
        /// <param name="str"> Имя вводимое пользователем для сохранения результата.</param>
        /// <returns></returns>
        bool NameIsCorrect(string str)
        {
            char[] letters = str.ToCharArray();
            for(int i = 0;i<letters.Length;i++)
            {
                if(!(letters[i]>='a'&&letters[i]<='z') && !(letters[i]>='A' && letters[i]<='Z') && !(letters[i]>='0'&&letters[i]<='9') && letters[i] != ' ' && letters[i] != '_')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Автосвойство, содержащее информацию о том, была ли нажата кнопка "Отмена".
        /// </summary>
        public bool CancelClicked { set; get; }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Готово".
        /// Введенное имя сохраняется в файл статистики и затем выводится в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputNameTextBox.Text.Trim()) || !NameIsCorrect(inputNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Введите корректное имя!\nИмя должно состоять строго из латинских символов.\nРегистр не важен.",
                    "Некорректный ввод!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputNameTextBox.Clear();
                inputNameTextBox.Select();
                return;
            }
            nameForStatistics = inputNameTextBox.Text;
            this.Close();
        }
        /// <summary>
        /// Обработчик события нажатия на клавишу Enter.
        /// Введенное имя сохраняется в файл статистики и затем выводится в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNameTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (string.IsNullOrEmpty(inputNameTextBox.Text.Trim()) || !NameIsCorrect(inputNameTextBox.Text.Trim()))
                {
                    MessageBox.Show("Введите корректное имя!\nИмя должно состоять строго из латинских символов.\nРегистр не важен.",
                        "Некорректный ввод!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputNameTextBox.Clear();
                    inputNameTextBox.Select();
                    return;
                }
                nameForStatistics = inputNameTextBox.Text;
                this.Close();
            }
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Отмена".
        /// Отменяется сохранение данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            CancelClicked = true;
            this.Close();
        }
    }
}
