   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   1    +CondominioADM.UI.Registros.rDepositoParqueo   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$% Registro de Deposito de Parqueo��5   	   $	��370��61   $	��480��6>    � WindowStartupLocation$ CenterScreen=�6J    � 
ResizeMode$ CanMinimize=�6o   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   $��10,0,0,0q�60   .+�5      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5      �� .+�5      �� $��DepositoId:��6    $��Comic Sans Ms)�66   �� 5      $ 
Horizontal=�6%   $	��230��6>   $
��Left=�6J   .+�5      �� -   5         ��Name$" DepositoApartamentoIdTextBox��5   &   $	��100��6o   $��24��6{   $��Comic Sans Ms)�6�   ��6L   �� *DepositoParqueoId+6�   �� 5      -   5         ��Name$ BuscarButton��5   %   $	��6,0q�6;   .��5   "   �� $ 
Horizontal=�6-   .+�5   &   �� $$��/Resources/search-icon (2).png��6,   �� 5   &   $��Buscar��6,   $
��Bold"�6=   
�������$��Comic Sans Ms)�6b   5   #   5      5      5       5!      �� 5#      $ 
Horizontal=�6   .+�5$      �� .+�5&      �� $��Numero de Apartamento:��6    $��Comic Sans Ms)�6A   �� 5'      -   5        $ ParqueoTextBox��5'   "    �� 
IsReadOnly$
 True��6Y   $	��380��6k   $
��Left=�6w   $��Comic Sans Ms)�6�   ��6:   �� *NumeroParqueo+6�   �� 5)      $��Nombre del Residente:��6    $��Comic Sans Ms)�6@   �� 5*      -   5        $ ResidenteTextBox��5*   "   $
 True��6]   $	��380��6o   $
��Left=�6{   $��Comic Sans Ms)�6�   ��6<   �� *NombreResidente+6�   �� 5,      $��Monto del deposito:��6    $��Comic Sans Ms)�6>   �� 5-      -   5        $ MontoTextbox��5-   "   $	��380��6`   $
��Left=�6l   $��Comic Sans Ms)�6�   ��68   �� *Monto+	 �� StringFormat$	 N2��6�   5/      �� 51      $��10,0,0,0q�6!   .+�52      �� -   5        $ ParqueoButton��52   !   $��0,20,0,0q�6U   .��53      �� $��0,0,0,0q�6)   .+�54   "   �� $%��/Resources/button-plus-icon.png��6(   55      56      �� 58      -   5        $ ResidenteButton��58   !   $��0,16,0,0q�6Y   .��59      �� $��0,0,0,0q�6)   .+�5:   "   �� $%��/Resources/button-plus-icon.png��6(   5;      5<      5?      5@      5A      �� 5C      $ 
Horizontal=�6   $��0,30,0,0q�62   $��Center=�6D   .+�5D      �� -   5        $ NuevoButton��5D      .��5E      �� $ 
Horizontal=�6!   .+�5F      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5G      $��Nuevo��6    $
��Bold"�60   
�������$��Comic Sans Ms)�6U   5H      5I      �� 5K      -	   5        $ GuardarButton��5K      $
��15,0q�60   .��5L      �� $ 
Horizontal=�6!   .+�5M      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5N      $��Guardar��6    $
��Bold"�62   
�������$��Comic Sans Ms)�6W   5O      5P      �� 5R      -
   5        $ EliminarButton��5R      .��5S      �� $ 
Horizontal=�6!   .+�5T      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5U      $��Eliminar��6    $
��Bold"�64   
�������$��Comic Sans Ms)�6Y   5V      5W      5X      5Z      5[      5\      