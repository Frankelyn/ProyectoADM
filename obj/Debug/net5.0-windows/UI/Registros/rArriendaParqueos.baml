   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   2    ,CondominioADM.UI.Registros.rArriendaParqueos   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$# Registro de Renta de Parqueos��5   	   $	��450��6/   $	��490��6<    � WindowStartupLocation$ CenterScreen=�6H    � 
ResizeMode$ CanMinimize=�6m   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   $��10,0,0,0q�60   .+�5      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5      �� .+�5      �� $��ArriendaId:��6    $��Comic Sans Ms)�66   �� 5      $ 
Horizontal=�6%   $	��230��6>   $
��Left=�6J   .+�5      �� -   5         ��Name$ ArriendaParqueoIdTextBox��5   &   $	��100��6k   $��24��6w   $��Comic Sans Ms)�6�   ��6H   �� *ArriendaParqueoId+6�   �� 5      -   5         ��Name$ BuscarButton��5   %   $	��6,0q�6;   .��5   "   �� $ 
Horizontal=�6-   .+�5   &   �� $$��/Resources/search-icon (2).png��6,   �� 5   &   $��Buscar��6,   $
��Bold"�6=   
�������$��Comic Sans Ms)�6b   5   #   5      5      5!      5#      �� 5%      $ 
Horizontal=�6   .+�5&      �� .+�5(      �� $��Fecha de Inicio:��6    $��0,10,0,0q�6;   $��Comic Sans Ms)�6M   (  "System.Windows.Controls.DatePicker  5)      -   5          Name$ Fecha_DatePicker��5)   %   	   SelectedDateFormat$	 Short=�6d   $	��380��6   $
��Left=�6�   $��0,0,0,0q�6�   $��Comic Sans Ms)�6�   
   SelectedDate
 6?   �� *FechaInicio+6�   �� 5+      $��Numero de Parqueo:��6    $��Comic Sans Ms)�6=   �� 5,      -   5        $ ParqueoTextBox��5,   "   $	��380��6Y    �� 
IsReadOnly$
 True��6e   $
��Left=�6w   $��Comic Sans Ms)�6�   ��6:   �� *NumeroParqueo+6�   �� 5.      $��Nombre del Residente:��6    $��Comic Sans Ms)�6@   �� 5/      -   5        $ ResidenteTextBox��5/   "   $	��380��6]   $
 True��6i   $
��Left=�6{   $��Comic Sans Ms)�6�   ��6<   �� *NombreResidente+6�   �� 51      $��Fecha de Renovacion:��6    $��0,10,0,0q�6?   $��Comic Sans Ms)�6Q     52      -   5        $ FechaR_DatePicker��52   %   $	 Short=�6i   $	��380��6�   $
��Left=�6�   $��0,0,0,0q�6�   $��Comic Sans Ms)�6�   
 6@   �� *FechaRenovacion+6�   54      �� 56      $��10,0,0,0q�6!   .+�57      �� -   5        $ ParqueoButton��57   !   $��0,80,0,0q�6U   .��58      �� $��0,0,0,0q�6)   .+�59   "   �� $%��/Resources/button-plus-icon.png��6(   5:      5;      �� 5=      -   5        $ ResidenteButton��5=   !   $��0,16,0,0q�6Y   .��5>      �� $��0,0,0,0q�6)   .+�5?   "   �� $%��/Resources/button-plus-icon.png��6(   5@      5A      5D      5E      5F      �� 5H      $ 
Horizontal=�6   $��0,30,0,0q�62   $��Center=�6D   .+�5I      �� -	   5        $ NuevoButton��5I      .��5J      �� $ 
Horizontal=�6!   .+�5K      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5L      $��Nuevo��6    $
��Bold"�60   
�������$��Comic Sans Ms)�6U   5M      5N      �� 5P      -
   5        $ GuardarButton��5P      $
��15,0q�60   .��5Q      �� $ 
Horizontal=�6!   .+�5R      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5S      $��Guardar��6    $
��Bold"�62   
�������$��Comic Sans Ms)�6W   5T      5U      �� 5W      -   5        $ EliminarButton��5W      .��5X      �� $ 
Horizontal=�6!   .+�5Y      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5Z      $��Eliminar��6    $
��Bold"�64   
�������$��Comic Sans Ms)�6Y   5[      5\      5]      5_      5`      5a      