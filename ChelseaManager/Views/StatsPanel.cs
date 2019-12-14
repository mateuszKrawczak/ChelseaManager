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
    public partial class StatsPanel : UserControl
    {
        //obiekty interfejsu
        private readonly IManagerGeneric<Country> _countries;
        private readonly IManagerGeneric<Position> _positiones;
        private readonly IManagerGeneric<CoachRole> _roles;

        public StatsPanel()
        {
            InitializeComponent();

            //ustawiam kolory transparentne
            labelPositiones.BackColor = Color.Transparent;
            labelCountries.BackColor = Color.Transparent;
            labelRoles.BackColor = Color.Transparent;

            //inicjalizacja obiektow potrzebne do wykonywaniu funkcji
            _countries = new ManagerGeneric<Country>();
            _positiones = new ManagerGeneric<Position>();
            _roles = new ManagerGeneric<CoachRole>();

            //wczytuje dane do tabel
            LoadCountries();
            LoadPositiones();
            LoadRoles();
        }

        //wczytuje role pracownikow do tabeli
        private void LoadRoles()
        {
            dataGridViewRoles.DataSource = _roles.GetAll();
        }

        //wczytuje pozycje zawodnikow
        private void LoadPositiones()
        {
            dataGridViewPositiones.DataSource = _positiones.GetAll();
        }

        //wczytuje kraje
        private void LoadCountries()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
        }

        /// <summary>
        /// funkcja dodaje nowy kraj do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            //zczytuje tekst
            var countryName = textBoxCountryName.Text;
            
            if (textBoxCountryName.Text != "" )
            {

                //utworzenie nowego obiektu klasy kraj i inicjalizacja wszystkich pol
                Country newCountry = new Country
                {
                    Name = textBoxCountryName.Text
                };

                //tworzenie nowego rekordu w bazie
                _countries.Create(newCountry);

                //aktualizacja bazy
                _countries.Save();

                MessageBox.Show("New country in base is " + newCountry.Name);
                textBoxCountryName.Text = "";
                
                //wczytanie krajow do tabeli
                LoadCountries();
            }
            else
            {
                MessageBox.Show("You have to complete data");
            }
        }

        /// <summary>
        /// funkcja dodaje nowy posade pracownika do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoleAdd_Click(object sender, EventArgs e)
        {
            //zczytuje wprowadzony tekst
            var roleName = textBoxRoleName.Text;

            if (textBoxRoleName.Text != "")
            {

                //utworzenie nowego obiektu i inicjalizacja nazwy posady
                CoachRole newEmployee = new CoachRole
                {
                    Role = textBoxRoleName.Text
                };
                //utworzenie nowego rekordu w bazie
                _roles.Create(newEmployee);
                //aktualizacja bazy
                 _roles.Save();
               
                
                MessageBox.Show("Now you can hire " + newEmployee.Role);
                textBoxRoleName.Text = "";

                //wczytuje posady do bazy
                LoadRoles();
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
        private void dataGridViewRoles_SelectionChanged(object sender, EventArgs e)
        {
            //jesli jest cos zaznaczone to wchodzimy w warunek
            if (dataGridViewRoles.SelectedRows.Count != 0)
            {
                //pobranie id zaznaczonego wiersza
                var selectedRoleIndex = Int32.Parse(dataGridViewRoles.SelectedRows[0].Cells[0].Value.ToString());
                var showRole = _roles.GetByID(selectedRoleIndex);

                //pokazuje rekord z bazy w polu tekstowym
                textBoxEditRole.Text = showRole.Role.ToString();
                




            }
        }

        /// <summary>
        /// funkcja usuwa posade z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //pobranie id zaznaczonego wiersza
                var selectedRoleIndex = Int32.Parse(dataGridViewRoles.SelectedRows[0].Cells[0].Value.ToString());
                var deleteRole = _roles.GetByID(selectedRoleIndex);

                MessageBox.Show("You deleted " + deleteRole.Role);

                //usuniecie z bazy
                _roles.DeleteById(deleteRole.ID);

                //aktualizacja bazy
                _roles.Save();


                //wczytanie do tabeli
                LoadRoles();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
