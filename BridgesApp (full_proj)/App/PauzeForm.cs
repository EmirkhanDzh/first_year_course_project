using System;
using System.Windows.Forms;
namespace App
{
    public partial class PauzeForm : Form
    {
        // Информация о том, была ли нажата кнопка "продолжить".
        bool continueClicked;
        // Информация о том, была ли нажата кнопка "Как играть ?".
        bool helpClicked;
        // Информация о том, была ли нажата кнопка "В главное меню".
        bool exitClicked;
        /// <summary>
        /// Свойство с доступом к полю exitClicked.
        /// </summary>
        public bool ExitClicked { get => exitClicked; set => exitClicked = value; }
        /// <summary>
        /// Свойство с доступом к полю helpClicked.
        /// </summary>
        public bool HelpClicked { get => helpClicked; set => helpClicked = value; }
        /// <summary>
        /// Свойство с доступом к полю continueClicked.
        /// </summary>
        public bool ContinueClicked { get => continueClicked; set => continueClicked = value; }

        /// <summary>
        /// Конструктор умолчания для данного класса
        /// </summary>
        public PauzeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Продолжить".
        /// Продолжается процесс игры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СontinueButtonClick(object sender, EventArgs e)
        {
            continueClicked = true;
            this.Close();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "В главное меню".
        /// Закрывается окно с игровым полем и открывается главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
                exitClicked = true; 
                this.Close();
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Как играть?".
        /// Открывается краткий список правил.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь должен решать игровые поля следующим образом:\n1) Нужно соединить перемычками каждый кружочек с соседними кружочками;\n2) Количество перемычек, проведенных от каждого кружочка, должно быть равно\nчисловому значению, указанному внутри кружочка;\n3) Проведенные перемычки не должны пересекаться с другими перемычками.","Правила игры",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
