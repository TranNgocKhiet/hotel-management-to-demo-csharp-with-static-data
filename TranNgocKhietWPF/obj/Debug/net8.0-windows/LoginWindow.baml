   M S B A M L   `   `   `  ����K  GTranNgocKhietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TranNgocKhietWPFTranNgocKhietWPF  5   	   "    TranNgocKhietWPF.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TranNgocKhietWPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LoginWindow��5	   	   $	��400��5
   	   $	��800��5   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��30 �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0,0,0,10q�6   $��1��6'   $��3��67   .+�5      �� $��	Username:��6   �� 5       -   5         ��Name$ txtEmail��5       $	��200��6(   5!      �� 5#   
   $��0,0,0,10q�6   $��1��6'   $��1��67   $��3��6D   .+�5$      �� $��	Password:��6   G� 5%      -   5         G�Name$ txtPass��5%      $	��200��6+   5&      �� 5(   
   -   5        $��2��5(      $��1��6   $��Log In��6.   $��80��6?   $��25��6J   6V   �� 5*   
   -   5        $��2��5*      $��3��6   $
��Quit��6.   $��80��6=   $��25��6H   6T   5+      5,      