   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   ,    &CondominioADM.UI.Registros.rResidentes   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Registro de Residentes��5   	   $	��620��6(   $	��490��65    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize=�6f   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   $��10,0,0,0q�60   .+�5      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5      �� .+�5      �� $��ResidenteId:��6    $��Comic Sans Ms)�67   �� 5      $ 
Horizontal=�6%   $	��230��6>   $
��Left=�6J   .+�5      �� -   5         ��Name$ ResidenteIdTextBox��5   &   $	��100��6_   $��24��6k   $��Comic Sans Ms)�6w   ��6B   �� *ResidenteId+6w   �� 5      -   5         ��Name$ BuscarButton��5   %   $	��6,0q�6;   .��5   "   �� $ 
Horizontal=�6-   .+�5   &   �� $$��/Resources/search-icon (2).png��6,   �� 5   &   $��Buscar��6,   $
��Bold"�6=   
�������$��Comic Sans Ms)�6b   5   #   5      5      5!      �� 5#      $��90,0,0,0q�6!   .+�5$      �� -   5         ��Name$ ActivoCheckBox��5$   #   $��Activo��6;   $��0,20,0,0q�6i   $��Comic Sans Ms)�6{   	 d� 	IsChecked	 6L   �� *Activo+6{   5%      5&      �� 5(      $ 
Horizontal=�6   .+�5)      �� .+�5*      �� $��Nombres:��6    $��Comic Sans Ms)�63   �� 5+      -   5        $ NombresTextBox��5+   "   $	��380��6S   $
��Left=�6_   $��Comic Sans Ms)�6z   ��6:   �� *	Nombres+6z   �� 5-      $��Fecha de registro:��6    $��0,10,0,0q�6=   $��Comic Sans Ms)�6O   (  "System.Windows.Controls.DatePicker  5.      -   5        
  Name$
 Fecha_DatePicker��5.   %      SelectedDateFormat$ Short=�6^   $	��380��6y   $
��Left=�6�   $��0,0,0,0q�6�   $��Comic Sans Ms)�6�      SelectedDate 6?   �� *Fecha+6�   �� 50      $��Cedula:��6    $��0,10,0,0q�62   $��Comic Sans Ms)�6D   �� 51      -   5        $ CedulaTextBox��51   "   $	��380��6Q   $
��Left=�6]   $��Comic Sans Ms)�6x   ��69   �� *Cedula+6x   �� 53      $��	Telefono:��6    $��0,10,0,0q�64   $��Comic Sans Ms)�6F   �� 54      -   5        $ TelefonoTextBox��54   "   $	��380��6U   $
��Left=�6a   $��Comic Sans Ms)�6|   ��6;   �� *
Telefono+6|   �� 56      $��Email:��6    $��0,10,0,0q�61   $��Comic Sans Ms)�6C   �� 57      -   5        $ EmailTextBox��57   "   $	��380��6O   $
��Left=�6[   $��Comic Sans Ms)�6v   ��68   �� *Email+6v   �� 59      $��0,10,0,0q�6&   .+�5:      �� $
��Sexo��6$   $��Comic Sans Ms)�63   �� 5;      -	   5         ��Name$ SexoCombobox��5;   '   $	��380��6^   $��Comic Sans Ms)�6j    �� SelectedValue 6=   �� *SexoId+6j   5<      �� 5>      $��0,10,0,0q�6&   .+�5?      �� $��Estado Civil��6$   $��Comic Sans Ms)�6;   �� 5@      -
   5        $ EstadoCivilCombobox��5@   '   $	��380��6l   $��Comic Sans Ms)�6x    6D   �� *EstadoCivilId+6x   5A      5C      5D      5E      �� 5H      $ 
Horizontal=�6   $��0,30,0,0q�62   $��Center=�6D   .+�5I      �� -   5        $ NuevoButton��5I      .��5J      �� $ 
Horizontal=�6!   .+�5K      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5L      $��Nuevo��6    $
��Bold"�60   
�������$��Comic Sans Ms)�6U   5M      5N      �� 5P      -   5        $ GuardarButton��5P      $
��15,0q�60   .��5Q      �� $ 
Horizontal=�6!   .+�5R      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5S      $��Guardar��6    $
��Bold"�62   
�������$��Comic Sans Ms)�6W   5T      5U      �� 5W      -   5        $ EliminarButton��5W      .��5X      �� $ 
Horizontal=�6!   .+�5Y      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5Z      $��Eliminar��6    $
��Bold"�64   
�������$��Comic Sans Ms)�6Y   5[      5\      5]      5_      5`      5a      