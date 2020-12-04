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
        List<Animal> circusDieren;
        List<Container> containers;
        public Form1()
        {
            InitializeComponent();
            circusDieren = new List<Animal>();
            containers = new List<Container>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalType dierType = (AnimalType) Enum.Parse(typeof(AnimalType),cBDierType.Text);
            int formaat = Convert.ToInt32(cBFormaat.Text);
            Animal dier = new Animal(formaat, dierType);
            circusDieren.Add(dier);
            lBAlleDieren.Items.Add(dier);
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            lBContainers.Items.Clear();

            foreach (Animal dier in circusDieren)
            {
                if (dier.AnimalType == AnimalType.Vlees)
                {
                    Container container = new Container(dier.Size);
                    containers.Add(container);
                    AddDier(container, dier);
                }

                else
                {
                    foreach (Container container in containers)
                    {
                        if (dier.Size + container.weight <= 10 && dier.Size > container.maxFormaat)
                        {
                            AddDier(container, dier);
                            break;
                        }

                        Container extraContainer = new Container();
                        AddDier(extraContainer, dier);
                    }
                }
            }

            lBContainers.Items.Clear();

            foreach (Container container in containers)
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

        void AddDier(Container container, Animal dier)
        {
            container.animals.Add(dier);
            container.weight += dier.Size;
        }
    }
}
