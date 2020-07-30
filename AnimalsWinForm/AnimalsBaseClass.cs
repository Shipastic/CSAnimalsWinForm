using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWinForm
{
    class AnimalsBaseClass
    {
        #region объявление полей класса

        private string name; // название животного

        private string className; // класс животного

        private int average_weight; // средний вес
        #endregion

        #region Определение конструкторов и деструктора
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public AnimalsBaseClass()
        {
            Name = "Дикое животное";
            ClassName = "звери";
            Average_weight = 300;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="ClassName"></param>
        /// <param name="Average_weight"></param>
        public AnimalsBaseClass(string name, string className, int average_weight)
        {
            Name = name;
            ClassName = className;
            Average_weight = average_weight;
        }

        /// <summary>
        /// Конструктор копирования
        /// </summary>
        /// <param name="anim"></param>
        public AnimalsBaseClass(AnimalsBaseClass anim)
        {
            Name = anim.Name;
            ClassName = anim.ClassName;
            Average_weight = anim.Average_weight;
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~AnimalsBaseClass()
        {
        }

        #endregion

        #region Инициализация свойств 
        // Свойство для установки названия животного
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        //Свойтсво для вывода класса животного
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        //Свойство для установки среднего веса животного
        public int Average_weight 
        {
            get { return average_weight; }
            set { average_weight = value; }
        }
        #endregion

        #region Инициализация функций для просмотра поле  класса
        public string GetName()
        {
            return Name;
        }

        public string GetClassName()
        {
            return ClassName;
        }

        public int GetAverageWeight()
        {
            return Average_weight;
        }
        #endregion

        #region Методы класса
        public void Show() // виртуальный метод для просмотра содержимого полей класса
        {

            Console.WriteLine("название животного: {0}, класс животного: {1}, средний вес животного: {2}", Name, ClassName, Average_weight);

        }
        #endregion
    }

}
