using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        List<Animal> circusAnimals;
        Train train;
        public Form1()
        {
            InitializeComponent();
            circusAnimals = new List<Animal>();
            train = new Train();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalType animalType = (AnimalType) Enum.Parse(typeof(AnimalType),cBDierType.Text);
            int size = Convert.ToInt32(cBFormaat.Text);
            Animal animal = new Animal(size, animalType);
            circusAnimals.Add(animal);
            lBAlleDieren.Items.Add(animal);
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            lBContainers.Items.Clear();
            train.ClearTrain();
            foreach (Animal animal in circusAnimals)
            {
                train.AddAnimal(animal);
            }

            lBContainers.Items.Clear();

            foreach (Container container in train.GetContainers())
            {
                lBContainers.Items.Add(container);
            }
        }

        private void lBContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbContainerDieren.Items.Clear();
            
            Container container = lBContainers.SelectedItem as Container;
            foreach (Animal dier in container.animals)
            {
                lbContainerDieren.Items.Add(dier);
            }
        }
    }
}
