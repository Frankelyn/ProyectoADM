   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.ConsultasCondominioADM.UI.Consultas  5   	   1    +CondominioADM.UI.Consultas.cDepositoParqueo   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Consultas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$+ %Consulta de Depositos de Apartamentos��5   	   $	��545��67   $	��600��6D    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ CanMinimize=�6u   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� $
��Left=�6!   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ Filtro_ComboBox��5   #   $	��150��6<   $��0,0,0,5q�6H   .@�5      �� $��Id��6+   �� 5      $��ResidenteId��6+   �� 5      $��	ParqueoId��6+   �� 5      $��Monto��6+   5      5      5       �� 5"      $ Vertical=�6   $
��Left=�64   $��45,0,0,0q�6O   .+�5$      �� $ Vertical=�6!   $
��Left=�68   .+�5%      �� $��Critero:��6    �� 5&      -   5         ��Name$ Criterio_TextBox��5&   "   $	��144��6<   $��24��6H   5'      5(      �� 5*      $��	120,0,0,0q�6   .+�5+      �� -   5         ��Name$ Buscar_Button��5+      $��72��6Q   $��85��6]   .��5,      �� $ Vertical=�6%   .+�5-      �� $$��/Resources/search-icon (2).png��6$   $��30��6L   �� 5.      $��Buscar��6$   $��56��65   $
��Bold"�6@   
�������$��Italic$�6e   $��16(�6x   5/      50      51      52      �� 54      $
��Left=�6   $��0,10,0,0q�65   .+�55      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DatosDataGrid��55      
   
IsReadOnly$

 True��62      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6i   $	��350��6�   $	��545��6�      Columns 56      59      5:      �� 5<      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5=      �� $��Conteo��6   $��Comic Sans MS)�6)   $��12(�6D   �� 5>      -   5        $ ConteoTextbox��5>       �� 
IsReadOnly$
 True��61   $��22��6C   $��50��6O   $��Comic Sans MS)�6Z   5?      5A      5B      5C      