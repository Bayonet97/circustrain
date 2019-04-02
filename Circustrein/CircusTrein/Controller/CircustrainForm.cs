using CircusTrein;
using CircusTrein.Model;
using CircusTrein.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlgoritmiekProject
{
    public partial class CircustrainForm : Form
    {
        private ITrain _train;
        private ILoader _wagonHandler;
        private List<IWagon> _wagonsToDisplay = new List<IWagon>();

        public CircustrainForm()
        {
            InitializeComponent();

            _train = TrainStation.CreateTrain();
            _wagonHandler = TrainStation.CreateWagonHandler(_train);
        }        

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            object animalNameInput = AnimalComboBox.Text;
            object animalSizeInput = SizeSelectionListBox.SelectedItem;
            object animalTypeInput = TypeSelectionListBox.SelectedItem;

            if (animalNameInput is null || animalSizeInput is null || animalTypeInput is null)
            {
                MessageBox.Show("Please select a name, size and type!");
                return;
            }

            UpdateAnimalNameList(animalNameInput);

            TrainStation.CreateNewAnimal().ConvertToAnimal(animalNameInput, animalSizeInput, animalTypeInput, _train);

            UpdateAnimalListBoxes();
        }

        private void UpdateAnimalListBoxes()
        {
            ClearAnimalListBoxes();

            foreach (IAnimal animal in _train.UnassignedAnimals)
            {
                AnimalNameListBox.Items.Add(animal.Name);
                AnimalTypeListBox.Items.Add(animal.Type);
                AnimalSizeListBox.Items.Add(animal.Size);
            }
        }

        private void UpdateAnimalNameList(object input)
        {
            if (!AnimalComboBox.Items.Contains(input))
            {
                AnimalComboBox.Items.Add(input);
            }
        }

        private void FillWagonsButton_Click(object sender, EventArgs e)
        {
            _wagonHandler.Load();

            UpdateWagonListBox();

            ClearAnimalListBoxes();
        }

        private void UpdateWagonListBox()
        {
            _wagonsToDisplay.Clear();
            _wagonsToDisplay.AddRange(_train.FinishedWagons);
            _wagonsToDisplay.AddRange(_train.UnfinishedWagons);
            List<IWagon> sortedList = _wagonsToDisplay.OrderBy(w => w.Id).ToList();

            WagonListBox.DataSource = null;
            WagonListBox.DataSource = sortedList;
        }

        private void ClearAnimalListBoxes()
        {
            AnimalNameListBox.Items.Clear();
            AnimalTypeListBox.Items.Clear();
            AnimalSizeListBox.Items.Clear();
        }

        private void WagonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalsInWagonListBox.DataSource = null;
            if (WagonListBox.SelectedIndex != -1)
            {
                AnimalsInWagonListBox.DataSource = _wagonsToDisplay[WagonListBox.SelectedIndex].Animals;
            }
        }
    }
}