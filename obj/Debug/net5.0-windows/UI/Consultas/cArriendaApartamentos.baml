   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.ConsultasCondominioADM.UI.Consultas  5   	   6    0CondominioADM.UI.Consultas.cArriendaApartamentos   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Consultas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$' !Consulta de Apartamentos Rentados��5   	   $	��565��63   $	��600��6@    � WindowStartupLocation$ CenterScreen=�6L    � 
ResizeMode$ CanMinimize=�6q   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� .+�5      �� $��Desde:��6    (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Desde_DataPicker��5   %   5      �� 5      $
��Left=�6!   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ Filtro_ComboBox��5   #   $	��150��6<   $��0,0,0,5q�6H   .@�5      �� $��Id��6+   �� 5      $��	Residente��6+   �� 5      $��Apartamento��6+   5       5"      5#      �� 5%      $ Vertical=�6   $
��Left=�64   $��45,0,0,0q�6O   .+�5'      �� $ Vertical=�6!   .+�5(      �� $��Hasta:��6      5)      -   5        $ Hasta_DatePicker��5)   %   5*      �� 5,      $ Vertical=�6!   $
��Left=�68   .+�5-      �� $��Critero:��6    �� 5.      -   5         ��Name$ Criterio_TextBox��5.   "   $	��144��6<   $��24��6H   5/      50      �� 52      $��
120,25,0,0q�6   .+�53      �� -   5        	 ��Name$	 Buscar_Button��53      $��72��6Q   $��85��6]   .��54      �� $ Vertical=�6%   .+�55      �� $$��/Resources/search-icon (2).png��6$   $��30��6L   �� 56      $��Buscar��6$   $��56��65   $
��Bold"�6@   
�������$��Italic$�6e   $��16(�6x   57      58      59      5:      �� 5>      $
��Left=�6   .+�5?      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DatosDataGrid��5?         
IsReadOnly$
 True��62      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6i   $	��350��6�   $	��545��6�      Columns 5@      5C      5D      �� 5F      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5G      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5H      �� $��Conteo��6   $��Comic Sans MS)�6-   $��12(�6H   �� 5I      -   5        $ ConteoTextbox��5I       �� 
IsReadOnly$
 True��65   $��22��6G   $��50��6S   $��Comic Sans MS)�6^   5J      �� 5L      $��0,0,0,0q�6   .+�5M      �� -   5        $	 AgregarButton��5M      $��	325,0,0,0q�6Q   $��40��6d   .��5N      �� $ 
Horizontal=�6%   .+�5O      �� $%��/Resources/button-plus-icon.png��6$   �� 5P      $��Agregar��6$   $��Comic Sans MS)�66   
�������$
��Bold"�6d   5Q      5R      5S      5T      5V      5W      5X      