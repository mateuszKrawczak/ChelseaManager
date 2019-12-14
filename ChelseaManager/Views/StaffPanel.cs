using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChelseaManager.Repositories;
using ChelseaManager.Models;

namespace ChelseaManager.Views
{
    public partial class StaffPanel : UserControl
    {
        //obiekty interfejsu
        private readonly IManagerGeneric<Country> _countries;
        private readonly IManagerGeneric<CoachRole> _roles;
        private readonly IManagerGeneric<Coach> _employees;
        

        public StaffPanel()
        {
            InitializeComponent();

            //inicjalizacja obiektow potrzebne do wykonywaniu funkcji
            _countries = new ManagerGeneric<Country>();
            _roles = new ManagerGeneric<CoachRole>();
            _employees = new ManagerGeneric<Coach>();

            //wczytuje pracownikow do tabeli
            LoadEmployees();
        }

        /// <summary>
        /// wczytanie do tabeli pracownikow
        /// </summary>
        private void LoadEmployees()
        {
           dataGridViewEmployees.DataSource = _employees.GetAll();
        }

        /// <summary>
        /// funkcja usuwa pracownika z bazy - zwalnia go
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSack_Click(object sender, EventArgs e)
        {

            try
            {
                //pobieram id zaznaczonego pracownika
                var selectedEmployeeIndex = Int32.Parse(dataGridViewEmployees.SelectedRows[0].Cells[0].Value.ToString());
                var deleteEmployee = _employees.GetByID(selectedEmployeeIndex);

                MessageBox.Show("You sacked " + deleteEmployee.FirstName + " " + deleteEmployee.LastName);

                //usuniecie z bazy
                _employees.DeleteById(deleteEmployee.ID);

                //zapisanie najnowszej wersji
                _employees.Save();


                //wczytanie pracownikow do tabeli
                LoadEmployees();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// funkcja pkzuje kraj zanzaczonego pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //pobieram id zaznaczonego pracownika
                var selectedPlayerIndex = Int32.Parse(dataGridViewEmployees.SelectedRows[0].Cells[0].Value.ToString());
                var showPlayer = _employees.GetByID(selectedPlayerIndex);


                //pobranie kraju zaznaczonego pracownika
                showPlayer.Country = _countries.GetByID(showPlayer.CountryID);


                MessageBox.Show("Country of employee: " + showPlayer.Country.Name);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// funkcja pokazuje role pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoleStaff_Click(object sender, EventArgs e)
        {
            try
            {
                //pobieram id zaznaczonego pracownika
                var selectedEmployeeIndex = Int32.Parse(dataGridViewEmployees.SelectedRows[0].Cells[0].Value.ToString());
                var showEmployee = _employees.GetByID(selectedEmployeeIndex);


                //pobranie posady zaznaczonego pracownika
                showEmployee.CoachRole = _roles.GetByID(showEmployee.CoachRoleID);


                MessageBox.Show("Position of employee: " + showEmployee.CoachRole.Role);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// zatrudnienie nowego pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHire_Click(object sender, EventArgs e)
        {

            //zczytuje dane z pol tekstowych
            var employeeFirstName = textBoxHireName.Text;
            var employeeLastName = textBoxHireSurname.Text;
            var employeeBirthdate = dateTimePickerHireBirth.Text;
            var countryID = textBoxHireCountry.Text;
            var roleID = textBoxHireRole.Text;
            
            if (textBoxHireName.Text != "" && textBoxHireSurname.Text != "" && textBoxHireCountry.Text != "" && textBoxHireRole.Text != "")
            {

                //utworzenie nowego obiektu klasy pracownik i inicjalizacja wszystkich pol
                Coach newEmployee = new Coach
                {
                    FirstName = employeeFirstName,
                    LastName = employeeLastName,
                    Birthdate = Convert.ToDateTime(employeeBirthdate),
                    CountryID = Int32.Parse(countryID),
                    CoachRoleID = Int32.Parse(roleID),
                    
                };

                //tworzenie nowego rekordu w bazie
                _employees.Create(newEmployee);

                //aktualizacja bazy
                _employees.Save();
                MessageBox.Show("You hired " + newEmployee.FirstName + " " + newEmployee.LastName);


                // czyszczeni pol tekstowych
                textBoxHireName.Text = "";
                textBoxHireSurname.Text = "";
                textBoxHireCountry.Text = "";
                textBoxHireRole.Text = "";
                
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("You have to complete data");
            }
        }

        /// <summary>
        /// funkcja zatwierdza zmiany w edycji pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxEditName.Text != "" && textBoxEditSurname.Text != "" && textBoxEditCountry.Text != "" && textBoxEditRole.Text != "")
            {
                //pobieram id zaznaczonego pracownika
                var selectedEmployeeIndex = Int32.Parse(dataGridViewEmployees.SelectedRows[0].Cells[0].Value.ToString());
                var updateEmployee = _employees.GetByID(selectedEmployeeIndex);


                //aktualizacja danych pracownika
                updateEmployee.FirstName = textBoxEditName.Text;
                updateEmployee.LastName = textBoxEditSurname.Text;
                updateEmployee.CountryID = int.Parse(textBoxEditCountry.Text);
                updateEmployee.CoachRoleID = int.Parse(textBoxEditRole.Text);
               


                //uaktualniam rekord w bazie
                _employees.Update(updateEmployee);

                //zapisuje najnowsza wersje w bazie
                _employees.Save();

                //wczytuje do tabeli
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("You have to complete data");
            }
        }
        /// <summary>
        /// funkcja wywoluje sie podczas klikniecia na wiersz tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {

            //jesli jest cos zaznaczone to wchodzimy w warunek
            if (dataGridViewEmployees.SelectedRows.Count != 0)
            {
                // pobieram id zaznaczonego pracownika
                 var selectedEmployeeIndex = Int32.Parse(dataGridViewEmployees.SelectedRows[0].Cells[0].Value.ToString());
                var showEmployee = _employees.GetByID(selectedEmployeeIndex);

                //wpisuje dane zaznaczonego pracownika do pol tekstowych
                textBoxEditName.Text = showEmployee.FirstName.ToString();
                textBoxEditSurname.Text = showEmployee.LastName.ToString();
                dateTimePickerEditBirth.Value = showEmployee.Birthdate;
                textBoxEditCountry.Text = showEmployee.CountryID.ToString();
                textBoxEditRole.Text = showEmployee.CoachRoleID.ToString();
                



            }
        }
    }
}
