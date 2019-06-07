using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArabComputersTask.API;
using ArabComputersTask.API.Models;
using ArabComputersTask.Services;

namespace ArabComputersTask.HotelReservation
{
    public partial class Form1 : Form
    {
         //this.Configuration.LazyLoadingEnabled = false;
         //   this.Configuration.ProxyCreationEnabled = false;
        RoomServices _roomServices = new RoomServices();
        UserServices _userServices = new UserServices();
        ReservationServices _reservationServices = new ReservationServices();

        public Form1(User user)
        {
            InitializeComponent();
            RefreshComponent();
            AdminID.Text = user.UserID.ToString();
        }
        private void RefreshComponent()
        {
            List<Room> EmptyRooms = _roomServices.GetEmptyRooms().ToList();
            List<Room> ReservedRooms = _roomServices.GetReservedRooms().ToList();
            List<User> users = _userServices.GetVistors().ToList();
            List<Reservation> reservations = _reservationServices.GetReservations().ToList();

            RoomsNumberEmpty.SelectedValue = "";
            RoomsNumberEmpty.DataSource = EmptyRooms;
            RoomsNumberEmpty.DisplayMember = nameof(Room.RoomNumber);
            RoomsNumberEmpty.ValueMember = nameof(Room.RoomID);

            RoomsNumberReserved.SelectedValue = "";
            RoomsNumberReserved.DataSource = ReservedRooms;
            RoomsNumberReserved.DisplayMember = nameof(Room.RoomNumber);
            RoomsNumberReserved.ValueMember = nameof(Room.RoomID);

            VistorsSSN.DataSource = users;
            VistorsSSN.DisplayMember = nameof(User.UserSSN);
            VistorsSSN.ValueMember = nameof(User.UserID);

            dataGridView1.DataSource = reservations;
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            if (EndDate.Value < StartDate.Value)
            {
                MessageBox.Show("this reservation doesn't save --> " +
                    "\n Start date must be less than End Date" );
            }
            else
            {
                bool reservationRoomstate = _roomServices.Reserve(int.Parse(RoomsNumberEmpty.SelectedValue.ToString()));
                if (reservationRoomstate)
                {
                    Reservation reservation = new Reservation()
                    {
                        RoomID = int.Parse(RoomsNumberEmpty.SelectedValue.ToString()),
                        UserID = int.Parse(VistorsSSN.SelectedValue.ToString()),
                        StartDate = StartDate.Value,
                        EndDate = EndDate.Value,
                        CreateReservationBy = int.Parse(AdminID.Text)
                    };
                    bool reservationstate = _reservationServices.Reserve(reservation);
                    if (reservationstate)
                    {
                        MessageBox.Show("This reservation is saved");
                    }
                    else
                    {
                        MessageBox.Show("This reservation is not saved");
                        _roomServices.CheckOut(int.Parse(RoomsNumberEmpty.SelectedValue.ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("This reservation is not saved");
                    _roomServices.CheckOut(int.Parse(RoomsNumberEmpty.SelectedValue.ToString()));

                }
                RefreshComponent();
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            bool CheckOutRoomstate = _roomServices.CheckOut(int.Parse(RoomsNumberReserved.SelectedValue.ToString()));
            if (CheckOutRoomstate)
            {
                bool CheckOutstate = _reservationServices.CheckOut(
                int.Parse(RoomsNumberReserved.SelectedValue.ToString())                
                );
                if (CheckOutstate)
                {
                    MessageBox.Show("This CheckOut is saved");
                }
                else
                {
                    MessageBox.Show("This CheckOut is not saved");
                   _roomServices.Reserve(int.Parse(RoomsNumberEmpty.SelectedValue.ToString()));
                }
            }
            else
            {
                MessageBox.Show("This CheckOut is not saved");
                _roomServices.Reserve(int.Parse(RoomsNumberEmpty.SelectedValue.ToString()));
            }
            RefreshComponent();
        }

       
    }
}
