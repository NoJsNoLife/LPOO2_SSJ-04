   M S B A M L   `   `   `  ����
  Vistas    Vistas.ModificarAtleta   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Modificar Atleta��5   	   $	��532��6"   $	��700��6/    � WindowStyle$ 
ToolWindow=�6;    � 
ResizeMode$ NoResize=�6T    � ShowInTaskbar$ False��6j    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5         TextBoxErrorTemplate � Color � Offset  EstiloError �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value �� RelativeSource��%*  &	        &	     7   �� 5   
   .R�5      ]� .+�5	      A� $��Right=�6   $	��2,0q�61   $��10��6>   $��10��6I   ��5
      �� 5      .��5      � $ 	#11FF1111��6+   $ 0Q�6=   � 5      $ 	#ffff0000��6+   $ 1Q�6=   5      5      5      5      �� 5   
   " ��6$   .�5      �� 	 �@=�ErrorTemplate8
   69    5      P� 5       �@=�HasError$
 True��69   . �5      �� 	 �@�ToolTip
 5      �� *%#(Validation.Errors)[0].ErrorContent+ �� *Self+5      5      5      .��5      � ���	#FFD9D0D0$	��522��6"   $	��Top=�6/   .+�5    
   �� $��Ingrese DNI��6   $
��Left=�6&   $��	32,20,0,0q�6A   $	��Top=�6T   �� 5!   
   -   5         ��Name$ txtDNI��5!      #��[ 6"   $
��Left=�6G   $��
259,20,0,0q�6b   $	��Top=�6v   $	��390��6�   �� 5$   
   $��Ingrese Apellido��6   $
��Left=�6+   $��	32,60,0,0q�6F   $	��Top=�6Y   �� 5%   
   -   5        $ txtApellido��5%      #��[ 6'   $
��Left=�6L   $��
259,60,0,0q�6g   $	��Top=�6{   $	��390��6�   �� 5(   
   $��Ingrese Nombre��6   $
��Left=�6)   $��
32,100,0,0q�6D   $	��Top=�6X   �� 5)   
   -   5        $ 	txtNombre��5)      #��[ 6%   $
��Left=�6J   $��259,100,0,0q�6e   $	��Top=�6z   $	��390��6�   �� 5,   
   $��Ingrese Nacionalidad��6   $
��Left=�6/   $��
32,140,0,0q�6J   $	��Top=�6^   �� 5-   
   -   5        $ txtNacionalidad��5-      #��[ 6+   $
��Left=�6P   $��259,140,0,0q�6k   $	��Top=�6�   $	��390��6�   �� 50   
   $��Ingrese Entrenador��6   $
��Left=�6-   $��
32,180,0,0q�6H   $	��Top=�6\   �� 51   
   -   5        $ txtEntrenador��51      #��[ 6)   $
��Left=�6N   $��259,180,0,0q�6i   $	��Top=�6~   $	��390��6�   �� 54   
   $��Ingrese Género��6   $
��Left=�6)   $��
32,220,0,0q�6D   $	��Top=�6X   	� 55   
   -   5         	�Name$ rbtMasculino��55      $��	Masculino��6,   $
��Left=�6@   $��259,220,0,0q�6[   $	��Top=�6p   	� 56   
   -   5        $ rbtFemenino��56      $��Femenino��6+   $
��Left=�6>   $��356,220,0,0q�6Y   $	��Top=�6n   	� 57   
   -   5        $ rbtNoBinario��57      $��
No Binario��6,   $
��Left=�6A   $��445,220,0,0q�6\   $	��Top=�6q   	� 58   
   -	   5        $ rbtPrefieroNoDecirlo��58      $��Prefiero no decirlo��64   $
��Left=�6R   $��532,220,0,0q�6m   $	��Top=�6�   �� 5;   
   $��Ingrese Altura (cm)��6   $
��Left=�6.   $��
32,260,0,0q�6I   $	��Top=�6]   �� 5<   
   -
   5        $ 	txtAltura��5<      #��[ 6%   $
��Left=�6J   $��259,260,0,0q�6e   $	��Top=�6z   $	��390��6�   �� 5?   
   $��Ingrese Peso (kg)��6   $
��Left=�6,   $��
32,300,0,0q�6G   $	��Top=�6[   �� 5@   
   -   5        $ txtPeso��5@      #��[ 6#   $
��Left=�6H   $��259,300,0,0q�6c   $	��Top=�6x   $	��390��6�   �� 5C   
   $!��Ingrese Fecha de Nacimiento��6   $
��Left=�66   $��
32,340,0,0q�6Q   $	��Top=�6e   (  "System.Windows.Controls.DatePicker  5D   
   -   5          Name$ 
dpFechaNac��5D      $
��Left=�6)   $��259,340,0,0q�6D   $	��Top=�6Y   $	��390��6q   �� 5G   
   $��Ingrese Dirección��6   $
��Left=�6,   $��
32,380,0,0q�6G   $	��Top=�6[   �� 5H   
   -   5        $ txtDireccion��5H      #��[ 6(   $
��Left=�6M   $��259,380,0,0q�6h   $	��Top=�6}   $	��390��6�   �� 5K   
   $��Ingrese Email��6   $
��Left=�6(   $��
32,420,0,0q�6C   $	��Top=�6W   �� 5L   
   -   5        $ txtEmail��5L      #��[ 6$   $
��Left=�6I   $��259,420,0,0q�6d   $	��Top=�6y   $	��390��6�   �� 5O   
   -   5         ��Name$ btnActualizar��5O   8     PrimaryButton#��[ 6   $��
Actualizar��6P   $
��Left=�6e   $��464,460,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5P   
   -   5        $ btnCancelar��5P   7     DangerButton#��[ 6   $��Cancelar��6L   $
��Left=�6_   $��554,460,0,0q�6z   $	��Top=�6�   $��75��6�   6�   �� 5Q   
   -   5        $ btnAtras��5Q   :     SecondaryButton#��[ 6   $��Atras��6L   $
��Left=�6\   $��
32,465,0,0q�6w   $	��Top=�6�   $��75��6�   6�   5R      5S      