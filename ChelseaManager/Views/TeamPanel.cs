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
    public partial class TeamPanel : UserControl
    {
        //obiekty interfejsu
        private readonly IManagerGeneric<Player> _players;
        private readonly IManagerGeneric<Country> _countries;
        private readonly IManagerGeneric<Position> _positiones;

        private ChelseaManagerContext views;


        public TeamPanel()
        {
            InitializeComponent();
            //inicjalizacja obiektow potrzebne do wykonywaniu funkcji
            _players = new ManagerGeneric<Player>();
            _countries = new ManagerGeneric<Country>();
            _positiones = new ManagerGeneric<Position>();
            views = new ChelseaManagerContext();

            //wczytuje zawodnikow
            LoadPlayers();

        }



        /// <summary>
        /// załadowanie wszystkich zawodnikow
        /// </summary>
        private void LoadPlayers()
        {
           
            dataGridViewPlayer.DataSource = _players.GetAll();
            //dataGridViewPlayers.DataSource = views.Database
        }

        /// <summary>
        /// funkcja sprzedaje zawodnika- usuwa z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                //pobieram id zaznaczonego zawodnika
                var selectedPlayerIndex = Int32.Parse(dataGridViewPlayer.SelectedRows[0].Cells[0].Value.ToString());
                var deleteJumper = _players.GetByID(selectedPlayerIndex);

                MessageBox.Show("You sold " + deleteJumper.FirstName + " " + deleteJumper.LastName);

                //usuniecie z bazy
                _players.DeleteById(deleteJumper.ID);

                //zapisanie najnowszej wersji
                _players.Save();


                //wczytanie zawodnikow do tabeli
                LoadPlayers();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        /// <summary>
        /// funkcja pkzuje kraj zanzaczonego zawodnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                //pobieram id zaznaczonego zawodnika
                var selectedPlayerIndex = Int32.Parse(dataGridViewPlayer.SelectedRows[0].Cells[0].Value.ToString());
                var showPlayer = _players.GetByID(selectedPlayerIndex);


                //pobranie kraju zaznaczonego zawdnika
                showPlayer.Country = _countries.GetByID(showPlayer.CountryID);

                //wyswietlenie
                MessageBox.Show("Country of player: " + showPlayer.Country.Name);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        /// <summary>
        /// funkcja pokazuje pozycje zawodnika 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPositionPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                //pobieram id zaznaczonego zawodnika
                var selectedPlayerIndex = Int32.Parse(dataGridViewPlayer.SelectedRows[0].Cells[0].Value.ToString());
                var showPlayer = _players.GetByID(selectedPlayerIndex);

                //pobranie pozycji zazanaczonego zawodnika
                showPlayer.Position = _positiones.GetByID(showPlayer.PositionID);

                //wyswietlenie pozycji
                MessageBox.Show("Position of player: " + showPlayer.Position.PositionName);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// funkcja kupuje zawodniika - dodaje nowy obiekt do bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPlayer_Click(object sender, EventArgs e)
        {
            //odbieram informacje zawarte w opolach tekstowych
            var playerFirstName = textBoxTransferName.Text;
            var playerLastName = textBoxTransferSurname.Text;
            var playerBirthdate = dateTimePickerTransferBirth.Text;
            var countryID = textBoxTransferCountry.Text;
            var positionID = textBoxTransferPosition.Text;
            var number = textBoxTransferNumber.Text;
            if (textBoxTransferName.Text != "" && textBoxTransferSurname.Text != "" && textBoxTransferCountry.Text != "" && textBoxTransferPosition.Text != "" && textBoxTransferNumber.Text != "")
            {

                //utworzenie nowego obiektu klasy zawodnik i inicjalizacja wszystkich pol
                Player newPlayer = new Player
                {
                    FirstName = playerFirstName,
                    LastName = playerLastName,
                    Birthdate = Convert.ToDateTime(playerBirthdate),
                    CountryID = Int32.Parse(countryID),
                    PositionID = Int32.Parse(positionID),
                    Number = Int32.Parse(number)
                };

                //tworzenie nowego rekordu w bazie
                _players.Create(newPlayer);

                //aktualizacja bazy
                _players.Save();
                MessageBox.Show("You bought " + newPlayer.FirstName+ " "+ newPlayer.LastName);

                //czyszczeni pol tekstowych
                textBoxTransferName.Text = "";
                textBoxTransferSurname.Text = "";
                textBoxTransferCountry.Text = "";
                textBoxTransferPosition.Text = "";
                textBoxTransferNumber.Text = "";
                LoadPlayers();
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
        private void dataGridViewPlayer_SelectionChanged(object sender, EventArgs e)
        {
            //jesli jest cos zaznaczone to wchodzimy w warunek
            if (dataGridViewPlayer.SelectedRows.Count != 0)
            {
                //pobieram id zaznaczonego zawodnika
                var selectedPlayerIndex = Int32.Parse(dataGridViewPlayer.SelectedRows[0].Cells[0].Value.ToString());
                var showPlayer = _players.GetByID(selectedPlayerIndex);
                
                //pokazuje dane zawodnika w gruopbox "Edit player"
                textBoxEditName.Text= showPlayer.FirstName.ToString();
                textBoxEditSurname.Text = showPlayer.LastName.ToString();
                dateTimePickerEditBirth.Value = showPlayer.Birthdate;
                textBoxEditCountry.Text = showPlayer.CountryID.ToString();
                textBoxEditPosition.Text = showPlayer.PositionID.ToString();
                textBoxEditNumber.Text = showPlayer.Number.ToString();




            }
        }

        /// <summary>
        /// funkcja zatwierdza zmiany w edycji zawodnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditPlayer_Click(object sender, EventArgs e)
        {
            if (textBoxEditName.Text != "" && textBoxEditSurname.Text != "" && textBoxEditCountry.Text != "" && textBoxEditPosition.Text != "" && textBoxEditNumber.Text != "")
            {
                //pobieram id zaznaczonego zawodnika
                var selectedPlayerIndex = Int32.Parse(dataGridViewPlayer.SelectedRows[0].Cells[0].Value.ToString());
                var updatePlayer = _players.GetByID(selectedPlayerIndex);

                //przypisuje nowe wartosci zawodnika
                updatePlayer.FirstName= textBoxEditName.Text;
                updatePlayer.LastName = textBoxEditSurname.Text;
                updatePlayer.CountryID = int.Parse(textBoxEditCountry.Text);
                updatePlayer.PositionID = int.Parse(textBoxEditPosition.Text);
                updatePlayer.Number = int.Parse(textBoxEditNumber.Text);


                //uaktualniam rekord
                _players.Update(updatePlayer);

                //uaktualniam baze
                _players.Save();

                //wczytuje zawodnikow do tabeli
                LoadPlayers();
            }
            else
            {
                MessageBox.Show("You have to complete data");
            }
        }
    }
}
