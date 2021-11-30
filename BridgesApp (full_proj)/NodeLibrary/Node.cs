using System;
using System.Collections.Generic;
namespace NodeLib
{
    [Serializable]
    public class Node
    {
        // Степень узла.
        int weight;
        // Список смедных соседей данного объекта.
        List<Node> connectedNodesList = new List<Node>();
        // Информация о соседних узлах данного объекта в виде строки.
        string connectedNodesInfo;
        // Поле, значение которого отвечает за то, проведено ли необходимое количество связей.
        bool isFull;
        // Номер строки, в которой расположен элемент node.
        int x;
        // Номер столбца, в котором расположен элемент node.
        int y;
        /// <summary>
        /// Конструктор умолчания.
        /// </summary>
        public Node() { }
        /// <summary>
        /// Конструктор класса, в котором инициализируются номер строки и номер столбца данного создаваемого объекта.
        /// </summary>
        /// <param name="x"> Номер строки объекта в поле.</param>
        /// <param name="y"> Номер столбца объекта в поле.</param>
        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Основной конструктор класса, в котором инициализируются позиции создаваемого объекта в поле и его степень(вес).
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Node(int weight, int x, int y)
        {
            this.Weight = weight;
            this.X = x;
            this.Y = y;
        }
        /// <summary>
        /// Метод, который возвращает элемент из списка соседей с индексом i.
        /// </summary>
        /// <param name="i"> Индекс, по которому возвращается элемент.</param>
        /// <returns> Вовзращаемый элемент из списка соседей, соответствующий индексу.</returns>
        public Node GetElemAt(int i)
        {
            return connectedNodesList[i];
        }
        
        /// <summary>
        /// Очистка всего списка соседей.
        /// </summary>
        public void RemoveAllList()
        {
            connectedNodesList.Clear();
        }

        /// <summary>
        /// Показывает, содержится ли данный элемент node в массиве connectedNodesList у элемента, для которого вызван этот метод.
        /// </summary>
        /// <param name="node"> Элемент, который проверяется на содержание в списке.</param>
        /// <returns></returns>
        public bool ElemContains(Node node)
        {
            return connectedNodesList.Contains(node);
        }

        /// <summary>
        /// Возвращает информацию о соединенных соседях в виде их позиций в виде строки.
        /// </summary>
        /// <returns> Позиции соединенных соседей.</returns>
        public string ShowInfo()
        {
            int counter = 0;
            connectedNodesInfo = null;
            foreach (Node elem in connectedNodesList)
            {
                connectedNodesInfo += $"{++counter}) "+elem.X + ";" + elem.Y + "\n";
            }
            return connectedNodesInfo;
        }


        /// <summary>
        /// Возвращает информацию о соединенных соседях данного элемента в виде строки для дальнейшего сохранения и восстановления 
        /// этого списка соседей.
        /// </summary>
        /// <returns> Позиции смежных соседей, разделенные запятой и пробелами.</returns>
        public string ShowInfoForSave()
        {
            connectedNodesInfo = null;
            int counter = 0;
            foreach (Node elem in connectedNodesList)
            {
                counter++;
                if (counter != connectedNodesList.Count)
                    connectedNodesInfo += elem.X + " " + elem.Y + ",";
                else
                    connectedNodesInfo += elem.X + " " + elem.Y;
            }
            return connectedNodesInfo;
        }
        /// <summary>
        /// Считает, сколько раз элемент node встречается в списке.
        /// </summary>
        /// <param name="node"> Элемент, количество вхождений в список которого считается.</param>
        /// <returns> Количество вхождения элемента в список элемента node.</returns>
        public int ElemCount(Node node)
        {
            int counter = 0;
            foreach (var item in connectedNodesList)
            {
                if(item == node)
                {
                    counter++;
                }
            }
            return counter;
        }




        /// <summary>
        /// Свойсвто для доступа к private полю weight, которое содержит информацию о весе вершины.
        /// </summary>
        public int Weight { get => weight; set => weight = value; }
        /// <summary>
        /// Свойство для доступа к private полю номера строки, в которой располагается данный объект.
        /// </summary>
        public int X { get => x; set => x = value; }
        /// <summary>
        /// Свойство для доступа к private полю номера столбца, в котором располагается данный объект.
        /// </summary>
        public int Y { get => y; set => y = value; }

        /// <summary>
        /// Свойства с доступом к private полю isFull.
        /// Вовзращает информацию о том, заполнен ли список соседей или нет.
        /// </summary>
        public bool IsFull { get => isFull; set => isFull = value; }

        /// <summary>
        /// Добавление элемента elem в список соседей данного объекта.
        /// </summary>
        /// <param name="elem"> Добавляемый элемент.</param>
        public void AddToNodesList(Node elem)
        {
            connectedNodesList.Add(elem);
        }


        /// <summary>
        /// Удаление соседа из списка соседей по его индексу в этом списке.
        /// </summary>
        /// <param name="i"> Индекс, по которому удаляется смежный сосед.</param>
        public void RemoveFromNodesListAt(int i)
        {
            connectedNodesList.RemoveAt(i);
        }
        /// <summary>
        /// Удаление соседа elem из списка соседей.
        /// </summary>
        /// <param name="elem"> Удаляемый элемент.</param>
        public void RemoveFromNodesList(Node elem)
        {
            connectedNodesList.Remove(elem);
        }

        /// <summary>
        /// Количество связей или количество элементов, с которыми соединен данный объект.
        /// Или, грубо говоря, количество соседей.
        /// </summary>
        /// <returns></returns>
        public int ConnectedNodesCount()
        {
            return connectedNodesList.Count;
        }
    }
}
