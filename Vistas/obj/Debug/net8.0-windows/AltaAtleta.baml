   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.AltaAtleta   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	     � Title$  Alta Atleta��5   	   $	��532��6   $	��700��6*    � WindowStyle$ 
ToolWindow=�66    � 
ResizeMode$ NoResize=�6O    � ShowInTaskbar$ False��6e    � WindowStartupLocation$ CenterScreen=�6{    � 	Resources 5	         DATA_ATLETA S� 
ObjectType   ClasesBase.TrabajarAtleta S� 
MethodName  TextBoxErrorTemplate � Color	 � Offset  EstiloError
 �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� Path �� Self �� RelativeSource��%�  &	        &	 A     &	 O    7  S� 5
   
   "  5      $ traer_atleta��5      5      �� 5   
   .R�5      ]� .+�5      A� $��Right=�6   $	��2,0q�61   $��10��6>   $��10��6I   ��5      �� 5      .��5      � $ 	#11FF1111��6+   $	 0Q�6=   � 5      $ 	#ffff0000��6+   $	 0Q�6=   5      5      5      5      �� 5   
   "
 ��6$   .�5      ��  � ��$ 4,4,10,4q�6'   �� 5       �@=�ErrorTemplate8   69    5      P� 5       �@=�HasError$
 True��69   . �5       ��  �@�ToolTip 5!      �� 5"      $) #(Validation.Errors)[0].ErrorContent�6&   # Z 6Q   5$      5%      5'      5(      .��5)      � ���	#FFD9D0D0$	��522��6"   $	��Top=�6/   .+�5*   
   �� $��Ingrese DNI��6   $
��Left=�6&   $��	32,20,0,0q�6A   $	��Top=�6T   �� 5+   
   -   5         ��Name$ txtDNI��5+   b    � DataContext# [  6   #��[ 6=   $
��Left=�6r   $��
259,20,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5,      �� 5-      $ Atl_DNI�6    �� UpdateSourceTrigger$ PropertyChanged=�6)    �� ValidatesOnExceptions$
 true��6O    �� ValidatesOnDataErrors$
 true��6l   .��5.      5/      �� 51   
   $��Ingrese Apellido��6   $
��Left=�6+   $��	32,60,0,0q�6F   $	��Top=�6Y   �� 52   
   -   5        $ txtApellido��52   b   # [  6   #��[ 6=   $
��Left=�6w   $��
259,60,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��53      �� 54      $ Atl_Apellido�6   $ PropertyChanged=�6.   $
 true��6T   $
 true��6q   .��55      56      �� 58   
   $��Ingrese Nombre��6   $
��Left=�6)   $��
32,100,0,0q�6D   $	��Top=�6X   �� 59   
   -   5        $ 	txtNombre��59   b   # [  6   #��[ 6=   $
��Left=�6u   $��259,100,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5:      �� 5;      $ 
Atl_Nombre�6   $ PropertyChanged=�6,   $
 true��6R   $
 true��6o   .��5<      5=      �� 5?   
   $��Ingrese Nacionalidad��6   $
��Left=�6/   $��
32,140,0,0q�6J   $	��Top=�6^   �� 5@   
   -   5        $ txtNacionalidad��5@   b   # [  6   #��[ 6=   $
��Left=�6{   $��259,140,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5A      �� 5B      $ Atl_Nacionalidad�6   $ PropertyChanged=�62   $
 true��6X   $
 true��6u   .��5C      5D      �� 5F   
   $��Ingrese Entrenador��6   $
��Left=�6-   $��
32,180,0,0q�6H   $	��Top=�6\   �� 5G   
   -   5        $ txtEntrenador��5G   b   # [  6   #��[ 6=   $
��Left=�6y   $��259,180,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5H      �� 5I      $ Atl_Entrenador�6   $ PropertyChanged=�60   $
 true��6V   $
 true��6s   .��5J      5K      �� 5M   
   $��Ingrese Género��6   $
��Left=�6)   $��
32,220,0,0q�6D   $	��Top=�6X   	� 5N   
   -   5         	�Name$ rbtMasculino��5N      $��	Masculino��6,   $
��Left=�6@   $��259,220,0,0q�6[   $	��Top=�6p   	� 5O   
   -   5        $ rbtFemenino��5O      $��Femenino��6+   $
��Left=�6>   $��356,220,0,0q�6Y   $	��Top=�6n   	� 5P   
   -   5        $ rbtNoBinario��5P      $��
No Binario��6,   $
��Left=�6A   $��445,220,0,0q�6\   $	��Top=�6q   	� 5Q   
   -	   5        $ rbtPrefieroNoDecirlo��5Q      $��Prefiero no decirlo��64   $
��Left=�6R   $��532,220,0,0q�6m   $	��Top=�6�   �� 5S   
   $��Ingrese Altura (cm)��6   $
��Left=�6.   $��
32,260,0,0q�6I   $	��Top=�6]   �� 5T   
   -
   5        $ 	txtAltura��5T   b   # [  6   #��[ 6=   $
��Left=�6u   $��259,260,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5U      �� 5V      $ 
Atl_Altura�6   $ PropertyChanged=�6,   $
 true��6R   $
 true��6o   .��5W      5X      �� 5Z   
   $��Ingrese Peso (kg)��6   $
��Left=�6,   $��
32,300,0,0q�6G   $	��Top=�6[   �� 5[   
   -   5        $ txtPeso��5[   b   # [  6   #��[ 6=   $
��Left=�6s   $��259,300,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5\      �� 5]      $ Atl_Peso�6   $ PropertyChanged=�6*   $
 true��6P   $
 true��6m   .��5^      5_      �� 5a   
   $!��Ingrese Fecha de Nacimiento��6   $
��Left=�66   $��
32,340,0,0q�6Q   $	��Top=�6e   (  "System.Windows.Controls.DatePicker  5b   
   -   5          Name$ 
dpFechaNac��5b      $
��Left=�6)   $��259,340,0,0q�6D   $	��Top=�6Y   $	��390��6q      SelectedDate 5c      �� 5d      $ Atl_FechaNac�6   $ PropertyChanged=�6.   $
 true��6T   $
 true��6q   5f      �� 5h   
   $��Ingrese Dirección��6   $
��Left=�6,   $��
32,380,0,0q�6G   $	��Top=�6[   �� 5i   
   -   5        $ txtDireccion��5i   b   # [  6   #��[ 6=   $
��Left=�6x   $��259,380,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5j      �� 5k      $ Atl_Direccion�6   $ PropertyChanged=�6/   $
 true��6U   $
 true��6r   .��5l      5m      �� 5o   
   $��Ingrese Email��6   $
��Left=�6(   $��
32,420,0,0q�6C   $	��Top=�6W   �� 5p   
   -   5        $ txtEmail��5p   b   # [  6   #��[ 6=   $
��Left=�6t   $��259,420,0,0q�6�   $	��Top=�6�   $	��390��6�   $��26��6�   .��6�   ��5q      �� 5r      $ 	Atl_email�6   $ PropertyChanged=�6+   $
 true��6Q   $
 true��6n   .��5s      5t      �� 5u   
   -   5         ��Name$ btnCargarDatos��5u   8     PrimaryButton#��[ 6   $��Agregar��6P   $
��Left=�6b   $��464,460,0,0q�6}   $	��Top=�6�   $��75��6�   6�   �� 5v   
   -   5        $ btnCancelar��5v   7     DangerButton#��[ 6   $��Cancelar��6L   $
��Left=�6_   $��554,460,0,0q�6z   $	��Top=�6�   $��75��6�   6�   �� 5w   
   -   5        $ btnAtras��5w   :     SecondaryButton#��[ 6   $��Atras��6L   $
��Left=�6\   $��
32,465,0,0q�6w   $	��Top=�6�   $��75��6�   6�   5x      5y      