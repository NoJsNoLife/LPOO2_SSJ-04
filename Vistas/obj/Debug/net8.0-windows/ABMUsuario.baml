   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	       Vistas.ABMUsuario   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	     � Title$  
ABMUsuario��5   	   $	��450��6   $	��800��6)    � WindowStyle$ 
ToolWindow=�65    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d   .��5	      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��30,20,0,339q�6I   .+�5      �� -   5         ��Name$ btnNuevo��5   <      SuccessButton#��[  6   $��Nuevo��6N   $��75��6^   $��40��6i   $	��Top=�6u   $��0,0,20,0q�6�   6�   �� 5      -   5        $ btnEliminar��5   <     WarningButton#��[ 6   $��Eliminar��6Q   $��75��6d   $��40��6o   $	��Top=�6{   $��0,0,20,0q�6�   6�   �� 5      -   5        $ btnCancelar��5   >     SecondaryButton#��[ 6   $��Cancelar��6S   $��75��6f   $��40��6q   $	��Top=�6}   $��0,0,20,0q�6�   6�   �� 5      -   5        $ 
btnGuardar��5   <     PrimaryButton#��[ 6   $��Guardar��6P   $��75��6b   $��40��6m   $	��Top=�6y   $��0,0,20,0q�6�   6�   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��0,20,20,339q�6J   .+�5      �� -   5        $ 
btnPrimero��5   <   #��[ 6   $��|<��6P   $��50��6`   $��40��6k   $	��Top=�6w   $��0,0,20,0q�6�   6�   �� 5      -   5        $ btnAnterior��5   <   #��[ 6   $��<��6Q   $��50��6`   $��40��6l   $	��Top=�6x   $��0,0,20,0q�6�   6�   �� 5      -   5        $ btnSiguiente��5   <   #��[ 6   $��>��6R   $��50��6a   $��40��6l   $	��Top=�6x   $��0,0,20,0q�6�   6�   �� 5      -   5        $ 	btnUltimo��5   <   #��[ 6   $��>|��6O   $��50��6_   $��40��6j   $	��Top=�6v   $��0,0,20,0q�6�   6�   5      � 5   
   $��30,100,30,155q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6     � ColumnDefinitions 5"      �� 5#      $
��Auto �6#   �� 5$      $��* �6#   .+�5'      �� $��Apellido y Nombre��6   $��0��60   $��0��6=   $	��0,5q�6M   �� 5(      -	   5         ��Name$ txtApellidoNombre��5(      $��0��61   $��1��6>   $��5q�6N   �� 5*      $��Nombre de usuario��6   $��1��60   $��0��6=   $	��0,5q�6M   �� 5+      -
   5        $ txtNombreUsuario��5+      $��1��60   $��1��6=   $��5q�6M   �� 5-      $��Contraseña��6   $��2��6)   $��0��66   $	��0,5q�6F   $��Right=�6S   G� 5.      -   5        	 G�Name$	 txtContrasena��5.      $��2��5/      $��1��50      $��5q�51      52      �� 54      $	��Rol��6   $��3��6"   $��0��6/   $	��0,5q�6?   $��Right=�6L   �� 55      -   5        
 ��Name$
 cmbRoles��55      $��3��56      $��1��57      $��5q�58       �� DisplayMemberPath$ Rol_Descripcion��59       �� SelectedValuePath$ 
Rol_Codigo��5:      ��5;      �� *roles+5<      �� 5=   
   -   5        $ btnListadoUsuarios��5=   8   #��[ 6   $��Ver Listado de Usuarios��6T   $��40��6w   $	��170��6�   $	��Top=�6�   $
��Left=�6�   $��209,288,0,0q�6�    J� RenderTransformOrigin$ 0.065,0.826&�6�   �� 5>   
   -   5        $ btnAtras��5?        DangerButton#��[ 5>      $��Atrás��5@      $��40��5A      $	��170��5B      $	��Top=�5C      $
��Left=�5D      $��427,288,0,0q�5E      $ 0.518,0.576&�5F   $   5G      5H      