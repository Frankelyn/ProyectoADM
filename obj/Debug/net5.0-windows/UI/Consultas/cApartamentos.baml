   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.ConsultasCondominioADM.UI.Consultas  5   	   .    (CondominioADM.UI.Consultas.cApartamentos   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Consultas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Consulta de Apartamentos��5   	   $	��545��6*   $	��600��67    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ CanMinimize=�6h   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� $
��Left=�6!   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ Filtro_ComboBox��5   #   $	��150��6<   $��0,0,0,5q�6H   .@�5      �� $��Id��6+   �� 5      $��Numero��6+   �� 5      $��Habitaciones��6+   �� 5      $��Precio de Renta��6+   �� 5      $��Disponibles��6+   5      5!      5"      �� 5$      $ Vertical=�6   $
��Left=�64   $��45,0,0,0q�6O   .+�5&      �� $ Vertical=�6!   $
��Left=�68   .+�5'      �� $��Critero:��6    �� 5(      -   5         ��Name$ Criterio_TextBox��5(   "   $	��144��6<   $��24��6H   5)      5*      �� 5,      $��	120,0,0,0q�6   .+�5-      �� -   5         ��Name$ Buscar_Button��5-      $��72��6Q   $��85��6]   .��5.      �� $ Vertical=�6%   .+�5/      �� $$��/Resources/search-icon (2).png��6$   $��30��6L   �� 50      $��Buscar��6$   $��56��65   $
��Bold"�6@   
�������$��Italic$�6e   $��16(�6x   51      52      53      54      �� 58      $
��Left=�6   $��0,10,0,0q�65   .+�59      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DatosDataGrid��59      
   
IsReadOnly$

 True��62      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6i   $	��350��6�   $	��545��6�      Columns 5:      5=      5>      �� 5@      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5A      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5B      �� $��Conteo��6   $��Comic Sans MS)�6-   $��12(�6H   �� 5C      -   5        $ ConteoTextbox��5C       �� 
IsReadOnly$
 True��65   $��22��6G   $��50��6S   $��Comic Sans MS)�6^   5D      �� 5F      $��0,0,0,0q�6   .+�5G      �� -   5        $ AgregarButton��5G      $��	325,0,0,0q�6Q   $��40��6d   .��5H      �� $ 
Horizontal=�6%   .+�5I      �� $%��/Resources/button-plus-icon.png��6$   �� 5J      $��Agregar��6$   $��Comic Sans MS)�66   
�������$
��Bold"�6d   5K      5L      5M      5N      5P      5Q      5R      