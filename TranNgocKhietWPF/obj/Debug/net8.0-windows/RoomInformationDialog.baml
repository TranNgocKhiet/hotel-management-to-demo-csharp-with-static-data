   M S B A M L   `   `   `  ����  TranNgocKhietWPF,    &TranNgocKhietWPF.RoomInformationDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Room Information��5   	   $	��400��6"   $	��400��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��Room Number��6   �� 5      -   5         ��Name$ txtRoomNumber��5      �� 5      $��Description��6   �� 5      -   5        $ txtDescription��5      �� 5      $��Max Capacity��6   �� 5      -   5        $ txtCapacity��5      �� 5      $"��Status (1=Active, 2=Deleted)��6   �� 5      -   5        $ 	txtStatus��5      �� 5      $��Price per Day��6   �� 5      -   5        $ txtPrice��5      �� 5!      $��	Room Type��6   �� 5"      -   5         ��Name$ cboRoomType��5"       �� DisplayMemberPath$ RoomTypeName��6,    �� SelectedValuePath$ 
RoomTypeID��6M   �� 5$       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�5%      �� -   5        $
��Save��5%      $��75��6(   $��5q�63   6>   �� 5&      -   5        $��Cancel��5&      $��75��6*   $��5q�65   6@   5'      5(      5)      5*      