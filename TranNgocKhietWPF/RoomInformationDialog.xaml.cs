using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows;

namespace TranNgocKhietWPF
{
    public partial class RoomInformationDialog : Window
    {
        public RoomInformation RoomInfo { get; private set; }

        public RoomInformationDialog(List<RoomType> roomTypes, RoomInformation room = null)
        {
            InitializeComponent();

            cboRoomType.ItemsSource = roomTypes;

            if (room != null)
            {
                RoomInfo = room;
                txtRoomNumber.Text = room.RoomNumber;
                txtDescription.Text = room.RoomDescription;
                txtCapacity.Text = room.RoomMaxCapacity.ToString();
                txtStatus.Text = room.RoomStatus.ToString();
                txtPrice.Text = room.RoomPricePerDate.ToString();
                cboRoomType.SelectedValue = room.RoomTypeID;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string roomNumber = txtRoomNumber.Text.Trim();
                string description = txtDescription.Text.Trim();
                string capacityText = txtCapacity.Text.Trim();
                string statusText = txtStatus.Text.Trim();
                string priceText = txtPrice.Text.Trim();
                var selectedRoomType = cboRoomType.SelectedValue;

                if (string.IsNullOrWhiteSpace(roomNumber))
                {
                    MessageBox.Show("Room number is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!int.TryParse(capacityText, out int capacity) || capacity <= 0)
                {
                    MessageBox.Show("Capacity must be a positive integer.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!byte.TryParse(statusText, out byte status) || (status != 1 && status != 2))
                {
                    MessageBox.Show("Status must be 1 (Active) or 2 (Deleted).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal price) || price < 0)
                {
                    MessageBox.Show("Price must be a positive number.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (selectedRoomType == null)
                {
                    MessageBox.Show("Please select a room type.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                RoomInfo ??= new RoomInformation();

                RoomInfo.RoomNumber = roomNumber;
                RoomInfo.RoomDescription = description;
                RoomInfo.RoomMaxCapacity = capacity;
                RoomInfo.RoomStatus = status;
                RoomInfo.RoomPricePerDate = price;
                RoomInfo.RoomTypeID = (int)selectedRoomType;

                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
