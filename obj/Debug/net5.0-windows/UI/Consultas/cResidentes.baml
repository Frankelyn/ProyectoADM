   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.ConsultasCondominioADM.UI.Consultas  5   	   ,    &CondominioADM.UI.Consultas.cResidentes   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Consultas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Consulta de Residentes��5   	   $	��565��6(   $	��600��65    � WindowStartupLocation$ CenterScreen=�6A   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� .+�5      �� $��Desde:��6    (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Desde_DataPicker��5   %   5      �� 5      $
��Left=�6!   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ Filtro_ComboBox��5   #   $	��150��6<   $��0,0,0,5q�6H   .@�5      �� $��Id��6+   �� 5      $��Nombres��6+   �� 5      $��Cedula��6+   �� 5       $��Telefono��6+   �� 5!      $��Email��6+   �� 5"      $
��Sexo��6+   �� 5#      $��Activos��6+   5%      5'      5(      �� 5*      $ Vertical=�6   $
��Left=�64   $��45,0,0,0q�6O   .+�5,      �� $ Vertical=�6!   .+�5-      �� $��Hasta:��6      5.      -   5        $ Hasta_DatePicker��5.   %   5/      �� 51      $ Vertical=�6!   $
��Left=�68   .+�52      �� $��Critero:��6    �� 53      -   5         ��Name$ Criterio_TextBox��53   "   $	��144��6<   $��24��6H   54      55      �� 57      $��
120,25,0,0q�6   .+�58      �� -   5         ��Name$ Buscar_Button��58      $��72��6Q   $��85��6]   .��59      �� $ Vertical=�6%   .+�5:      �� $$��/Resources/search-icon (2).png��6$   $��30��6L   �� 5;      $��Buscar��6$   $��56��65   $
��Bold"�6@   
�������$��Italic$�6e   $��16(�6x   5<      5=      5>      5?      �� 5C      $
��Left=�6   .+�5D      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DatosDataGrid��5D      
   
IsReadOnly$

 True��62      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6i   $	��350��6�   $	��545��6�      Columns 5E      5H      5I      �� 5K      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5L      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5M      �� $��Conteo��6   $��Comic Sans MS)�6-   $��12(�6H   �� 5N      -   5        $ ConteoTextbox��5N       �� 
IsReadOnly$
 True��65   $��22��6G   $��50��6S   $��Comic Sans MS)�6^   5O      �� 5Q      $��0,0,0,0q�6   .+�5R      �� -   5        $ AgregarButton��5R      $��	325,0,0,0q�6P   $��40��6c   .��5S      �� $ 
Horizontal=�6%   .+�5T      �� $%��/Resources/button-plus-icon.png��6$   �� 5U      $��Agregar��6$   $��Comic Sans MS)�66   
�������$
��Bold"�6d   5V      5W      5X      5Y      5[      5\      5]      