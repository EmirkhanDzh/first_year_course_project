using System;
using System.Text;
using System.IO;
using BridgesExceptionLib;
namespace ParserLib
{
    public class Parser
    {
        // Массив, содержащий все строки файла.
        static string[] allLines;
        // Массив массивов с информацией о строках файла.
        static string[][] dataDouble;
        /// <summary>
        /// Возвращает длину массива из строк файла.
        /// </summary>
        public static int Length { get => allLines.Length; }
        /// <summary>
        /// Возвращает информацию о том, существует ли файл по данной директории path.
        /// </summary>
        /// <param name="path"> Директория файла.</param>
        /// <returns></returns>
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
        /// <summary>
        /// Метод, который считывает массив строк из файла по директории path.
        /// </summary>
        /// <param name="path"> Директория файла.</param>
        /// <returns> Массив строк из файла.</returns>
        public static string[] ReadAll(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }

        /// <summary>
        /// Метод, который перезаписывает файл по директории из параметра, записывает в него информацию из параметра text.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void WriteText(string path, string text)
        {

            try
            {
                File.WriteAllText(path, text, Encoding.UTF8);
            }
            catch (Exception e)
            {
                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }
        /// <summary>
        /// Метод, который добавляет в файл по директории path информацию, содержащуюся в text.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void AppendText(string path, string text)
        {
            try
            {
                File.AppendAllText(path, text);
            }
            catch (Exception e)
            {

                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }
        /// <summary>
        /// Метод, который записывает массив строк text в файл по директории path. Перезаписывает файл, если он уже создан.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void WriteLines(string path, string[] text)
        {
            try
            {
                File.WriteAllLines(path, text, Encoding.UTF8);
            }
            catch (Exception e)
            {
                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }

        /// <summary>
        /// Удаляет файл по директории path.
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {

                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }



        /// <summary>
        /// Возвращает длину столбца с заданиями из файла, который соответствует данному уровню.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public static int LevelColumnLength(int column)
        {
            for (int i = 1; i < dataDouble.Length; i++)
            {
                if (String.IsNullOrEmpty(dataDouble[i][column]) || String.IsNullOrWhiteSpace(dataDouble[i][column]))
                    return i;
            }
            return dataDouble.Length;
        }
        /// <summary>
        /// Метод, который считывает инфорацию из базы данных.
        /// Обязателен для вызова после каждой записи в файл, так как здесь инициализируется ассоциированный с базой данных
        /// массив allLines.
        /// </summary>
        /// <param name="path"> Директория файла, который выступает в качестве базы данных.</param>
        /// <returns> Массив строк из файла.</returns>
        public static void ReadFile(string path)
        {
            try
            {
                allLines = File.ReadAllLines(path);
                dataDouble = new string[allLines.Length][];
                ConvertFromSingleToDouble(allLines, ref dataDouble);
            }
            catch (Exception e)
            {
                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }

        /// <summary>
        /// Метод, который возвращает необходимое поле(ячейку из базы данных).
        /// </summary>
        /// <param name="column"> 0-задание, 1-решение.</param>
        /// <param name="field"> Номер строки в базе данных. Оно же поле, которое соответствует данному уровню.</param>
        /// <returns> Возвращает еобходимую информацию из файла.</returns>
        public static string GetField(int field, int column)
        {
            return dataDouble[field][column];
        }


        /// <summary>
        /// Возвращает размер поля, который будет построен по информации из файла.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static int GetFieldLength(int field, int column)
        {
            return dataDouble[field][column].Split(',').Length;
        }
        /// <summary>
        /// Записывает всю информацию из singleData[] в dataDouble[][].
        /// </summary>
        /// <param name="singleData"> Массив строк из файла.</param>
        /// <param name="doubleData"> Зубчатый массив ровно с тем же данными, что и у singleData</param>
        public static void ConvertFromSingleToDouble(string[] singleData, ref string[][] doubleData)
        {
            for (int i = 0; i < doubleData.Length; i++)
            {
                doubleData[i] = new string[2];
                for (int j = 0; j < doubleData[i].Length; j++)
                {
                    doubleData[i][j] = (singleData[i].Split(';'))[j];
                }
            }
        }


        /// <summary>
        /// Запись сгенерированных данных в файл с заданиями и решениями в зависимости от column. 0 - задания, 1- решения.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="currentFieldInfo"> Данные: само игровое поле или его решение</param>
        /// <param name="column"> Столбец: 0 - поля, 1 - решения к полям.</param>
        public static void AddField(string path, string currentFieldInfo, int column)
        {
            int levelLength = LevelColumnLength(column);
            if (levelLength != dataDouble.Length && levelLength > 1 && (dataDouble[levelLength][column] == "" || dataDouble[levelLength][column] == null || String.IsNullOrEmpty(dataDouble[levelLength][column])))
                dataDouble[levelLength][column] = currentFieldInfo;
            else
            {
                if (levelLength < dataDouble.Length)
                    dataDouble[levelLength][column] = currentFieldInfo;
                else
                {
                    Array.Resize(ref dataDouble, dataDouble.Length + 1);
                    dataDouble[dataDouble.Length - 1] = new string[2];
                    dataDouble[dataDouble.Length - 1][column] = currentFieldInfo;
                }
            }

            // Массив строк с информациями о строках файла.
            string[] dataSingle = new string[dataDouble.Length];
            for (int i = 0; i < dataDouble.Length; i++)
            {
                for (int j = 0; j < dataDouble[i].Length; j++)
                {
                    dataSingle[i] += j != dataDouble[i].Length - 1 ? dataDouble[i][j] + ";" : dataDouble[i][j];
                }
            }
            try
            {
                File.WriteAllLines(path, dataSingle, Encoding.UTF8);
                ReadFile(path);
            }
            catch (Exception e)
            {
                throw new BridgesException("Ошибка при работе с файлом игры <<BridgesPuzzle>>:" + " " + e.Message);
            }
        }
    }
}


