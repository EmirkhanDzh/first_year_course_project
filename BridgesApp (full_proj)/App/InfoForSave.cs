using System;
using NodeLib;
namespace App
{
    /// <summary>
    /// Класс для того, чтобы держать информацию о текущих задачах.
    /// </summary>
    [Serializable]
    public class InfoForSave
    {
        /// <summary>
        /// Конструктор умолчания. Для сериализации/десериализации.
        /// </summary>
        public InfoForSave() { }
        // Информация, о том, решено ли поле или нет.
        bool finished;
        // Зубчатый массив из узлов типа Node.
        Node[][] nodes;
        // Идентификатор сохраненного поля.
        int id;
        // Уровень сохраненного поля.
        int level;
        // Показания таймера часы.
        int hours;
        // Показания таймера: минуты.
        int mins;
        // Показания таймера: секунды.
        int secs;
        // Зубчатый массив с информацией о наличии связей на позициях поля.
        bool[][] pbIsSet;
        // Размер сохраненного поля.
        int fieldSize;
        // Содержит информацию о том, скрыта ли кнопка посдказки.
        bool helpButtonVisible;
        // содержит информацию о соединенных узлах для каждого элемента из nodes.
        // т.е. элемент connections[i][j] содержит позиции смежных соседей для элемента nodes[i][j].
        string[][] connections;
        /// <summary>
        /// Свойство с доступом к полю id. Возвращает идентификатор сохраненного поля.
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Свойство с доступом к полю level. Возвращает уровень сохраненного поля.
        /// </summary>
        public int Level { get => level; set => level = value; }
        /// <summary>
        /// Свойство с доступом к полю hours. Возвращает сохраненное время в часах.
        /// </summary>
        public int Hours { get => hours; set => hours = value; }
        /// <summary>
        /// Свойство с доступом к полю mins. Возвращает сохраненное время в минутах.
        /// </summary>
        public int Mins { get => mins; set => mins = value; }
        /// <summary>
        /// Свойство с доступом к полю secs. Возвращает сохраненное время в секундах.
        /// </summary>
        public int Secs { get => secs; set => secs = value; }
        /// <summary>
        /// Свойство с доступом к массиву nodes. Возвращает зубчатый массив с элементами - узлами.
        /// </summary>
        public Node[][] Nodes { get => nodes; set => nodes = value; }
        /// <summary>
        /// Свойство с доступом к полю pbIsSet. Возвразщает зубчатый массив, элементы которого
        /// содержат информацию о проведенных связях в позициях поля.
        /// </summary>
        public bool[][] PbIsSet { get => pbIsSet; set => pbIsSet = value; }
        /// <summary>
        /// Свойство с доступом к полю connections. Возвразщает зубчатый массив, элементы которого
        /// содержат информацию о соединенных соседях для каждого элемента из nodes.
        /// </summary>
        public string[][] Connections { get => connections; set => connections = value; }
        /// <summary>
        /// Свойство с доступом к полю finished. Возвразщает информацию, решено ли текущее поле или нет.
        /// </summary>
        public bool Finished { get => finished; set => finished = value; }
        /// <summary>
        /// Свойство с доступом к полю fieldSize. Возвращает размер сохраненного поля.
        /// </summary>
        public int FieldSize { get => fieldSize; set => fieldSize = value; }
        /// <summary>
        /// Свойство с доступом к полю helpButtonVisible. Возвращает информацию, скрыта ли подсказка или нет.
        /// </summary>
        public bool HelpButtonVisible { get => helpButtonVisible; set => helpButtonVisible = value; }

        /// <summary>
        /// Конструктор класса, в котором инициализируются все необходимые для сохранения поля.
        /// </summary>
        /// <param name="id"> Идентификатор уровня.</param>
        /// <param name="level"> Уровень поля.</param>
        /// <param name="hours"> Часы.</param>
        /// <param name="mins"> Минуты.</param>
        /// <param name="secs"> Секунды.</param>
        /// <param name="finished"> Решен ли уровень.</param>
        /// <param name="nodes"> Зубчатый массив узлов.</param>
        /// <param name="pbIsSet"> Зубчатый массив с информацией о том, проведены ли связи.</param>
        /// <param name="connections"> Зубчатый массив с информацией о соседях узлов на соответствующих позициях массива.</param>
        /// <param name="fieldSize"> Размерность поля.</param>
        /// <param name="helpButtonVisible"> Информация о том, скрыта ли кнопка подсказки.</param>
        public InfoForSave(int id, int level, int hours, int mins, int secs,bool finished, Node[][] nodes, bool[][] pbIsSet, string[][] connections,int fieldSize, bool helpButtonVisible)
        {
            this.id = id;
            this.level = level;
            this.hours = hours;
            this.mins = mins;
            this.secs = secs;
            this.finished = finished;
            this.FieldSize = fieldSize;
            this.helpButtonVisible = helpButtonVisible;
            // Метод для инициализации массивов массивов.
            this.nodes = new Node[nodes.Length][];
            Array.Copy(nodes, this.nodes, nodes.Length);
            this.pbIsSet = new bool[pbIsSet.Length][];
            Array.Copy(pbIsSet, this.pbIsSet, pbIsSet.Length);
            this.Connections = new string[connections.Length][];
            Array.Copy(connections, this.Connections, connections.Length);

        }


        /// <summary>
        /// Метод который из массива массивов nodes возвращает двумерный массив doubNodes.
        /// </summary>
        /// <returns> Двумерный массив с теми же элементами , что у массива массивов.</returns>
        public Node[,] FromNodeOfNodeToDoubleNode()
        {
            // Массив массивов у нас представляет квадратную матрицу, поэтому длина каждого массива в массиве nodes[][] будет одинаковой.
            Node[,] doubNodes = new Node[nodes.Length, nodes[0].Length];
            for(int i = 0; i<doubNodes.GetLength(0);i++)
            {
                for (int j = 0; j < doubNodes.GetLength(1); j++)
                {
                    doubNodes[i, j] = nodes[i][j];
                }
            }
            return doubNodes;
        }

        /// <summary>
        /// Метод, который всю информарцию из зубчатого массива pbIsSet дублирует в двумерный массив doubIsSet.
        /// </summary>
        /// <returns> Двумерный массив с теми же элементами , что у массива массивов.</returns>
        public bool[,] FromPbIsSetOfPbIsSetToDoublePbIsSet()
        {
            bool[,] doubpbIsSet = new bool[pbIsSet.Length,pbIsSet.Length];
            for (int i = 0; i < doubpbIsSet.GetLength(0); i++)
            {
                for (int j = 0; j < doubpbIsSet.GetLength(1); j++)
                {
                    doubpbIsSet[i, j] = pbIsSet[i][j];
                }
            }
            return doubpbIsSet;
        }

        /// <summary>
        /// Метод, который из зубчатого массива connections дублирует всю информацию в двумерный массив doubConnections.
        /// </summary>
        /// <returns></returns>
        public string[,] FromStrOfStrToDoubleStr()
        {
            string[,] doubConnections = new string[connections.Length, connections[0].Length];
            for (int i = 0; i < doubConnections.GetLength(0); i++)
            {
                for (int j = 0; j < doubConnections.GetLength(1); j++)
                {
                    doubConnections[i, j] = connections[i][j];
                }
            }
            return doubConnections;
        }
    }
}
