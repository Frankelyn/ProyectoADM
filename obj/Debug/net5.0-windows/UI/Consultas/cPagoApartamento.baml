   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.ConsultasCondominioADM.UI.Consultas  5   	   1    +CondominioADM.UI.Consultas.cPagoApartamento   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Consultas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$% Consulta de Pago de Apartamento��5   	   $	��565��61   $	��600��6>    � WindowStartupLocation$ CenterScreen=�6J    � 
ResizeMode$ CanMinimize=�6o   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� .+�5      �� $��Desde:��6    (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Desde_DataPicker��5   %   5      �� 5      $
��Left=�6!   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ Filtro_ComboBox��5   #   $	��150��6<   $��0,0,0,5q�6H   .@�5      �� $��Id��6+   �� 5      $��	Residente��6+   �� 5      $��Numero de Apartamento��6+   �� 5       $��Monto Pagado��6+   5"      5$      5%      �� 5'      $ Vertical=�6   $
��Left=�64   $��45,0,0,0q�6O   .+�5)      �� $ Vertical=�6!   .+�5*      �� $��Hasta:��6      5+      -   5        $ Hasta_DatePicker��5+   %   5,      �� 5.      $ Vertical=�6!   $
��Left=�68   .+�5/      �� $��Critero:��6    �� 50      -   5         ��Name$ Criterio_TextBox��50   "   $	��144��6<   $��24��6H   51      52      �� 54      $��
120,25,0,0q�6   .+�55      �� -   5        	 ��Name$	 Buscar_Button��55      $��72��6Q   $��85��6]   .��56      �� $ Vertical=�6%   .+�57      �� $$��/Resources/search-icon (2).png��6$   $��30��6L   �� 58      $��Buscar��6$   $��56��65   $
��Bold"�6@   
�������$��Italic$�6e   $��16(�6x   59      5:      5;      5<      �� 5@      $
��Left=�6   .+�5A      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DatosDataGrid��5A         
IsReadOnly$
 True��62      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6i   $	��350��6�   $	��545��6�      Columns 5B      5E      5F      �� 5H      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5I      �� $��Conteo��6   $��Comic Sans MS)�6)   $��12(�6D   �� 5J      -   5        $ ConteoTextbox��5J       �� 
IsReadOnly$
 True��61   $��22��6C   $��50��6O   $��Comic Sans MS)�6Z   5K      5M      5N      5O      