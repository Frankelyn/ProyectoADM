   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   -    'CondominioADM.UI.Registros.rPagoParqueo   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Realizar Pago de Parqueo��5   	   $	��570��6*   $	��590��67    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ CanMinimize=�6h   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��	10,10,0,0q�62   .+�5      �� .+�5      �� $��PagoId:��6   $��Comic Sans Ms)�6.   �� 5      $ 
Horizontal=�6!   $	��230��6:   $
��Left=�6F   .+�5      �� -   5         ��Name$ PagoApartamentoIdTextBox��5   "   $	��100��6c   $��24��6o   $��Comic Sans Ms)�6{   ��6D   �� *PagoParqueoId+6{   �� 5      -   5         ��Name$ BuscarButton��5   !   $	��6,0q�67   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� $$��/Resources/search-icon (2).png��6(   �� 5   "   $��Buscar��6(   $
��Bold"�69   
�������$��Comic Sans Ms)�6^   5      5      5      5       5"      �� 5$      $��	10,10,0,0q�6   .+�5%      �� $��Fecha de registro:��6   $��0,10,0,0q�65   (  "System.Windows.Controls.DatePicker  5&      -   5          Name$ Fecha_DatePicker��5&      	   SelectedDateFormat$	 Short=�6V   $	��380��6q   $
��Left=�6}   $��0,0,0,0q�6�   
   SelectedDate
 67   �� *Fecha+6�   5'      �� 5)      $��Center=�6   $��0,10,0,0q�66   .+�5*      �� $��Renta��6   .��5+      �� $ 
Horizontal=�6!   .+�5,      �� .+�5-      �� $��Numero de Parqueo:��6$   $��Comic Sans Ms)�6A   �� 5.      -   5        $ ParqueoTextBox��5.   &    �� 
IsReadOnly$
 True��6>   $	��380��6x   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6P   �� *Arrienda.NumeroParqueo+6�   �� 50      $��Nombre del Residente:��6$   $��Comic Sans Ms)�6D   �� 51      -   5        $ ResidenteTextBox��51   &   $
 True��6@   $	��380��6|   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6R   �� *Arrienda.NombreResidente+6�   �� 53      $��Monto de la Renta:��6$   $��Comic Sans Ms)�6A   �� 54      -   5        $ MontoTextbox��54   &   $
 True��6<   $	��380��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6N   �� *Arrienda.MontoRenta+ �� StringFormat$ N2��6�   56      �� 58      $��15,0,0,0q�6%   .+�59      �� -   5        $ BuscarRentaButton��59   %   .��5:   "   �� $ 
Horizontal=�6-   .+�5;   &   �� $$��/Resources/search-icon (2).png��6,   �� 5<   &   $��Buscar Renta��6,   
�������$
��Bold"�6V   $��Comic Sans Ms)�6h   5=   #   5>      5?      5@      5A      5B      �� 5D      $��0,10,0,0q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5E      �� .+�5F      �� $��Monto a Pagar:��6   $��Comic Sans Ms)�65   �� 5G      -   5        $ MontoPagoTextbox��5G      $	��180��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��68   �� *	MontoPago+$ N2��6�   5H      �� 5J      $��	100,0,0,0q�6   .+�5K      �� $��	Devuelta:��6   $��Comic Sans Ms)�60   �� 5L      -	   5         ��Name$ DevueltaLabel��5L      $��Comic Sans Ms)�63   $��24(�6N   
����ح�6\   5M      5O      �� 5S      $ 
Horizontal=�6   $��0,40,0,0q�62   $��Center=�6D   .+�5T      �� -
   5        $ NuevoButton��5T      .��5U      �� $ 
Horizontal=�6!   .+�5V      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5W      $��Nuevo��6    $
��Bold"�60   
�������$��Comic Sans Ms)�6U   5X      5Y      �� 5[      -   5        $ GuardarButton��5[      $
��15,0q�60   .��5\      �� $ 
Horizontal=�6!   .+�5]      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5^      $��Guardar��6    $
��Bold"�62   
�������$��Comic Sans Ms)�6W   5_      5`      �� 5b      -   5        $ EliminarButton��5b      .��5c      �� $ 
Horizontal=�6!   .+�5d      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5e      $��Eliminar��6    $
��Bold"�64   
�������$��Comic Sans Ms)�6Y   5f      5g      5h      5j      5k      5l      