   M S B A M L   `   `   `  ����
  Vistas    Vistas.ListadoUsuarios   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ListadoUsuarios��5   	   $	��450��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P    � WindowStyle$ 
ToolWindow=�6u   .��5      � $��10q�6   .+�5   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,0,0,10q�6M   .+�5      �� $#��Buscar por nombre de usuario:��6   $��Center=�6A   $��0,0,5,0q�6\   $
��Bold"�6m   �� 5	      -   5         ��Name$ 	txtFiltro��5	      $	��200��6-   $��25��69   6E   �� 5
      -   5         ��Name$ btnAtras��5
   ?      DangerButton#��[  6   $��Atrás��6Q   $��30��6b   $	��160��6n   $��	200,0,0,0q�6z   6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGridUsuarios��5         AutoGenerateColumns$ False��61   	   CanUserAddRows$	 False��6M   
   
IsReadOnly$

 True��6d   $��Stretch=�5      $��Stretch=�61      AlternatingRowBackground
 �����   RowBackground
 �����   GridLinesVisibility$
 None=�5      $��1q�6.   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Usu_ID+6P     5      $ Nombre de Usuario��6)   $ * 6j    6D   �� *Usu_NombreUsuario+6j     5      $ Apellido y Nombre��6)   $ * 6k    6D   �� *Usu_ApellidoNombre+6k     5      $	 Rol��6)   $ * 6T    66   �� *	RolNombre+6T   5      5      5      5      