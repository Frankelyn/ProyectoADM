   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   1    +CondominioADM.UI.Registros.rPagoApartamento   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$" Realizar Pago de Apartamento��5   	   $	��570��6.   $	��590��6;    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ CanMinimize=�6l   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��	10,10,0,0q�62   .+�5      �� .+�5      �� $��PagoId:��6   $��Comic Sans Ms)�6.   �� 5      $ 
Horizontal=�6!   $
��Left=�6:   .+�5      �� -   5         ��Name$ PagoApartamentoIdTextBox��5   "   $	��100��6g   $��24��6s   $��Comic Sans Ms)�6   ��6D   �� *PagoApartamentoId+6   �� 5      -   5         ��Name$ BuscarButton��5   !   $	��6,0q�67   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� $$��/Resources/search-icon (2).png��6(   �� 5   "   $��Buscar��6(   $
��Bold"�69   
�������$��Comic Sans Ms)�6^   5      5      �� 5       -   5        $ ImprimirButton��5    !   $��	250,0,0,0q�6V   .��5!      �� .+�5"   "   �� $��/Resources/print-icon.png��6(   5#      5$      5%      5'      5)      �� 5+      $��	10,10,0,0q�6   .+�5,      �� $��Fecha de registro:��6   $��0,10,0,0q�65   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$ Fecha_DatePicker��5-      	   SelectedDateFormat$	 Short=�6V   $	��380��6q   $
��Left=�6}   $��0,0,0,0q�6�   
   SelectedDate
 67   �� *Fecha+6�   5.      �� 50      $��Center=�6   $��0,10,0,0q�66   .+�51      �� $��Renta��6   .��52      �� $ 
Horizontal=�6%   .+�53      �� .+�54   "   �� $��Numero de Apartamento:��6(   $��Comic Sans Ms)�6I   �� 55   "   -   5        $ ApartamentoTextBox��55   *    �� 
IsReadOnly$
 True��6F   $	��380��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6X   �� *Arrienda.NumeroApartamento+6�   �� 57   "   $��Nombre del Residente:��6(   $��Comic Sans Ms)�6H   �� 58   "   -   5        $ ResidenteTextBox��58   *   $
 True��6D   $	��380��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6V   �� *Arrienda.NombreResidente+6�   �� 5:   "   $��Monto de la Renta:��6(   $��Comic Sans Ms)�6E   �� 5;   "   -   5        $ MontoTextbox��5;   *   $
 True��6@   $	��380��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��6R   �� *Arrienda.MontoRenta+ �� StringFormat$ N2��6�   5=      �� 5?      $��15,0,0,0q�6)   .+�5@   "   �� -   5        $ BuscarRentaButton��5@   )   .��5A   &   �� $ 
Horizontal=�61   .+�5B   *   �� $$��/Resources/search-icon (2).png��60   �� 5C   *   $��Buscar Renta��60   
�������$
��Bold"�6Z   $��Comic Sans Ms)�6l   5D   '   5E   #   5F      5G      5H      5I      �� 5K      $��0,10,0,0q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5L      �� .+�5M      �� $��Monto a Pagar:��6   $��Comic Sans Ms)�65   �� 5N      -	   5        $ MontoPagoTextbox��5N      $	��180��6�   $
��Left=�6�   $��Comic Sans Ms)�6�   ��68   �� *	MontoPago+$ N2��6�   5O      �� 5Q      $��	100,0,0,0q�6   .+�5R      �� $��	Devuelta:��6   $��Comic Sans Ms)�60   �� 5S      -
   5         ��Name$ DevueltaLabel��5S      $��Comic Sans Ms)�63   $��24(�6N   
����ح�6\   5T      5V      �� 5X      $ 
Horizontal=�6   $��0,40,0,0q�62   $��Center=�6D   .+�5Y      �� -   5        $ NuevoButton��5Y      .��5Z      �� $ 
Horizontal=�6!   .+�5[      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5\      $��Nuevo��6    $
��Bold"�60   
�������$��Comic Sans Ms)�6U   5]      5^      �� 5`      -   5        $ GuardarButton��5`      $
��15,0q�60   .��5a      �� $ 
Horizontal=�6!   .+�5b      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5c      $��Guardar��6    $
��Bold"�62   
�������$��Comic Sans Ms)�6W   5d      5e      �� 5g      -   5        $ EliminarButton��5g      .��5h      �� $ 
Horizontal=�6!   .+�5i      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5j      $��Eliminar��6    $
��Bold"�64   
�������$��Comic Sans Ms)�6Y   5k      5l      5m      5o      5p      5q      