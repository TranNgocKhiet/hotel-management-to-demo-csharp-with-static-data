   M S B A M L   `   `   `  ����K  GTranNgocKhietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TranNgocKhietWPFTranNgocKhietWPF  5      .    (TranNgocKhietWPF.RoomInformationListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0localclr-namespace:TranNgocKhietWPF     5      -   5        $	��850��5      $	��900��5	        N� Title$   Room Information List Page��5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � RowDefinitions 5"   
   �� 5#      $��50 �6   �� 5$      $��50 �6   �� 5%      $	��550 �6   �� 5&      $��50 �6   �� 5'      $��50 �6   �� 5(      $��50 �6   �� 5)      $��50 �6   �� 5*      $��50 �6   .+�5-   
   �� $!��Room Information Management��6   $��0��5.      $��5��5/      $��20(�50      $��6��51      $��Center=�52      �� 54   
   -   5         ��Name$ SearchTextBox��54      $��1��55      $��1��6   $��12��6/   $��Center=�56      $��
0,10,10,10q�57      $��30��58      �� 5:   
   -   5        $��Search��5:      $��1��5;      $��13��6   $��2��6/   $	��100��5<      $��30��5=      $��Center=�5>      5?      &   System.Windows.Controls.DataGrid  5A   
   -   5          Name$ RoomDataGrid��5A         AutoGenerateColumns$ False��5B      $��1��5C      $��2��5D      $��14��5E      $��1��5F         Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *RoomID+  5I      $ Number��6%    65   �� *
RoomNumber+4  .System.Windows.Controls.DataGridTemplateColumn  5K      $ Description��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 355 6>   
   CellTemplate
 5L      �� 5M      .R�5N      �� $
��Wrap=�5O      $��CharacterEllipsis=�5P      $	��350��5Q      ��5N   (   �� *RoomDescription+5Q      5R      5T        5V      $ Capacity��6%    67   �� *RoomMaxCapacity+  5X      $ Status��6)   
 5Y      �� 5Z      .R�5[      ��  ��Name$ 
StatusText��6(    �� Triggers 5\      �� 5]   "    �� Value$ 1��6M    �� Binding 6.   �� *
RoomStatus+.a�5^   &   ��  �� 
TargetName$ 
StatusText��6-    �� Property � �� �� Value$ Active��6U   5_   #   �� 5`   "   $ 2��6M    6.   �� *
RoomStatus+.a�5a   &   �� $ 
StatusText��6-    � ��$ Deleted��6U   5b   #   5d      5f        5h      $ 
Price/Date��6%    69   �� *RoomPricePerDate+  5i      $ Type ID��6%    66   �� *
RoomTypeID+5k      �� 5m   
   -   5        $��
Create New��5m      $	��100��5n      $��30��5o      $��3��5p      $��2��5q      $��3��5r      5s      �� 5u   
   -   5        $��Edit Selected��5u      $	��100��5v      $��30��5w      $��3��5x      $��6��5y      $��3��5z      5{      �� 5}   
   -   5        $��Delete Selected��5}      $	��100��5~      $��30��5      $��3��5�      $��10��5�      $��3��5�      5�      5�      5�      