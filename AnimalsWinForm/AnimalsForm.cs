using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalsWinForm
{
    public partial class AnimalsForm : Form
    {
        AnimalsBaseClass anim1;
        AnimalsBaseClass anim2;
        AnimalsBaseClass anim3;

        List<AnimalsBaseClass> animals = new List<AnimalsBaseClass>();

        public int index = 0;
        public AnimalsForm()
        {
            InitializeComponent();
            anim1 = new AnimalsBaseClass();
            dataGridViewAnimals.Columns.Add("Название животного", "Название животного");
            dataGridViewAnimals.Columns.Add("Класс животного", "Класс животного");
            dataGridViewAnimals.Columns.Add("Вес животного", "Вес животного");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNameDefault.Text = anim1.GetName();
            textBoxClNameDefault.Text = anim1.GetClassName();
            textBoxAvWeightDefault.Text = Convert.ToString(anim1.GetAverageWeight());

        }

        /// <summary>
        /// Обработчик кнопки Добавить в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                anim2 = new AnimalsBaseClass(textBoxNameCreated.Text,
                                            textBoxClassCreated.Text, 
                                            Int32.Parse(textBoxAverageCreated.Text));
                animals.Add(anim2);

                FillDataGridView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректно заполнены исходыне данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Метод для заполнения DataGrid
        /// </summary>
        private void FillDataGridView()
        {
                dataGridViewAnimals.Rows.Clear();
            foreach (var animal in animals)
            { 
                dataGridViewAnimals.Rows.Add(animal.Name, animal.ClassName,
                                             animal.Average_weight);
            }

        }

        /// <summary>
        /// Обработчик кнопки скопировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCopyAnimal_Click(object sender, EventArgs e)
        {
            if (anim2 != null)
            {
                anim3 = new AnimalsBaseClass(anim2);
                animals.Add(anim3);
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Нет объекта для копирования", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Метод, помещающий выделенную строку в DataGrid по текстовым полям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                textBoxNameCreated.Text = dataGridViewAnimals.CurrentRow.Cells[0].Value.ToString();
                textBoxClassCreated.Text = dataGridViewAnimals.CurrentRow.Cells[1].Value.ToString();
                textBoxAverageCreated.Text = dataGridViewAnimals.CurrentRow.Cells[2].Value.ToString();       
        }
       
        /// <summary>
        /// Обработчик кнопки изменить для названия животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButChangeName_Click(object sender, EventArgs e)
        {

            dataGridViewAnimals[0, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxNameCreated.Text;
            dataGridViewAnimals[1, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxClassCreated.Text;
            dataGridViewAnimals[2, dataGridViewAnimals.CurrentCell.RowIndex].Value = Int32.Parse(textBoxAverageCreated.Text);
           
        }

        /// <summary>
        /// Обработчик кнопки изменить для класса животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButChangeClass_Click(object sender, EventArgs e)
        {
            dataGridViewAnimals[0, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxNameCreated.Text;
            dataGridViewAnimals[1, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxClassCreated.Text;
            dataGridViewAnimals[2, dataGridViewAnimals.CurrentCell.RowIndex].Value = Int32.Parse(textBoxAverageCreated.Text);
           
        }


        /// <summary>
        /// Обработчик кнопки изменить для среднего веса животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButChangeAverage_Click(object sender, EventArgs e)
        {
            dataGridViewAnimals[0, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxNameCreated.Text;
            dataGridViewAnimals[1, dataGridViewAnimals.CurrentCell.RowIndex].Value = textBoxClassCreated.Text;
            dataGridViewAnimals[2, dataGridViewAnimals.CurrentCell.RowIndex].Value = Int32.Parse(textBoxAverageCreated.Text);
           

        }

        /// <summary>
        /// Обработчик кнопки Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDeleteAnimal_Click(object sender, EventArgs e)
        {
            int deleteAnimal = dataGridViewAnimals.SelectedCells[0].RowIndex;
            dataGridViewAnimals.Rows.RemoveAt(deleteAnimal);
        }
    }
}
