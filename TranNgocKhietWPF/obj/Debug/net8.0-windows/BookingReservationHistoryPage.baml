   M S B A M L   `   `   `  ����K  GTranNgocKhietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TranNgocKhietWPFTranNgocKhietWPF  5      4    .TranNgocKhietWPF.BookingReservationHistoryPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0localclr-namespace:TranNgocKhietWPF     5      -   5        $	��850��5      $	��900��5	        N� Title$&   Booking Reservation History Page��5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � RowDefinitions 5#   
   �� 5$      $��50 �6   �� 5%      $��30 �6   �� 5&      $��30 �6   �� 5'      $��30 �6   �� 5(      $��30 �6   �� 5)      $��30 �6   �� 5*      $��30 �6   �� 5+      $��30 �6   �� 5,      $��30 �6   �� 5-      $	��360 �6   �� 5.      $��50 �6   �� 5/      $��50 �6   �� 50      $��50 �6   �� 51      $��50 �6   �� 52      $��50 �6   .+�56   
   �� -   5         ��Name$ label��56      $!��Booking Reservation History��57      $��0��58      $��5��59      $��20(�5:      $��6��5;      $��Center=�5<      �� 5>   
   -   5        $ label1��5>      $��2,2,2,2q�6    $��Booking Reservation ID��63   $��1��6T   $��1��6d   $��4��6q   �� 5?   
   -   5         ��Name$ txtBookingReservationID��5?      $��4,4,4,4q�63   $��4��6E   $��1��6U   $�� ��6b    �� TextWrapping$
 Wrap=�6j   $��11��6~   ${�False��6�   �� 5A   
   -   5        $ label2��5A      $��2,2,2,2q�6    $��Booking Date��62   $��1��6I   $��2��6Y   $��4��6g   �� 5B   
   -   5        $ txtBookingDate��5B      $��4,4,4,4q�6*   $��4��6<   $��2��6L   $�� ��6Y   $
 Wrap=�6a   $��11��6u   �� 5D   
   -   5        $ label3��5D      $��2,2,2,2q�6    $��Total Price��62   $��1��6H   $��3��6X   $��4��6e   �� 5E   
   -   5        $ txtTotalPrice��5E      $��4,4,4,4q�6*   $��4��6<   $��3��6L   $�� ��6Y   $
 Wrap=�6a   $��11��6u   �� 5G   
   -	   5        $ label4��5G      $��2,2,2,2q�6    $��Customer ID��62   $��1��6H   $��4��6X   $��4��6e   �� 5H   
   -
   5        $ txtCustomerID��5H      $��4,4,4,4q�6)   $��4��6<   $��4��6L   $�� ��6Z   $
 Wrap=�6b   $��11��6v   �� 5J   
   -   5        $ label5��5J      $��2,2,2,2q�6    $��Booking Status��62   $��1��6K   $��5��6[   $��4��6h   �� 5K   
   -   5        $ txtBookingStatus��5K      $��4,4,4,4q�6,   $��4��6?   $��5��6O   $�� ��6]   $
 Wrap=�6e   $��11��6y   &   System.Windows.Controls.DataGrid  5M   
   -   5          Name$  BookingReservationDataGrid��5M         AutoGenerateColumns$ False��5N         CanUserAddRows$ False��5O      $��1��5P      $��9��5Q      $��14��5R      $��1��5S      	   Columns	 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookingReservationID+  5W      $

 Date��6%    63   �� *BookingDate+ �� StringFormat$ 
dd/MM/yyyy��  5X      $
 Total Price��6%    6:   �� *
TotalPrice+  5Y      $
 Customer ID��6%    6:   �� *
CustomerID+  5Z      $
 Booking Status��6%    6=   �� *BookingStatus+5\      5]      5^      