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
        List<Dier> circusDieren;
        List<Container> containers;
        public Form1()
        {
            InitializeComponent();
            circusDieren = new List<Dier>();
            containers = new List<Container>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DierType dierType = (DierType) Enum.Parse(typeof(DierType),cBDierType.Text);
            int formaat = Convert.ToInt32(cBFormaat.Text);
            Dier dier = new Dier(formaat, dierType);
            circusDieren.Add(dier);
            lBAlleDieren.Items.Add(dier);
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            lBContainers.Items.Clear();

            foreach (Dier dier in circusDieren)
            {
                if (dier.dierType == DierType.Vlees)
                {
                    Container container = new Container(dier.formaat);
                    containers.Add(container);
                    AddDier(container, dier);
                }

                else
                {
                    foreach (Container container in containers)
                    {
                        if (dier.formaat + container.weight <= 10 && dier.formaat > container.maxFormaat)
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
            foreach (Dier dier in container.dieren)
            {
                lbContainerDieren.Items.Add(dier);
            }
        }

        void AddDier(Container container, Dier dier)
        {
            container.dieren.Add(dier);
            container.weight += dier.formaat;
        }
    }
}
