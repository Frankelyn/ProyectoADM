   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CondominioADM.UI.RegistrosCondominioADM.UI.Registros  5   	   _4clr-namespace:CondominioADM.Resources.PasswordHelper&CondominioADM.Resources.PasswordHelper  5   	   *    $CondominioADM.UI.Registros.rUsuarios   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CondominioADM.UI.Registros     5   	   OPasswordHelper4clr-namespace:CondominioADM.Resources.PasswordHelper     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Registro de Usuarios��5   	   $	��400��6&   $	��480��63    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ CanMinimize=�6d   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5      �� .+�5      �� $��
UsuarioId:��6    �� 5      $ 
Horizontal=�6%   $	��230��6>   $
��Left=�6J   .+�5      �� -   5         ��Name$ UsuarioIdTextBox��5   &   $	��100��6[   $��24��6g   ��6@   �� *	UsuarioId+6g   �� 5      -   5         ��Name$ BuscarButton��5   %   $	��6,0q�6;   .��5   "   �� $ 
Horizontal=�6-   .+�5   &   �� $$��/Resources/search-icon (2).png��6,   �� 5   &   $��Buscar��6,   $
��Bold"�6=   
�������6O   5   #   5      5       5"      5#      �� 5'      $��Nombre usuario:��6   �� 5(      -   5        $ NombreUsuarioTextBox��5(      $	��380��6Q   $
��Left=�6]   ��68   �� *	Nombres+6]   �� 5*      $��Fecha de registro:��6   $��0,10,0,0q�65   (  "System.Windows.Controls.DatePicker  5+      -   5          Name$ Fecha_DatePicker��5+      	   SelectedDateFormat$	 Short=�6V   $	��380��6q   $
��Left=�6}   $��0,0,0,0q�6�   
   SelectedDate
 67   �� *Fecha+6�   �� 5-      $��Email:��6   $��0,10,0,0q�6)   �� 5.      -   5        $ EmailTextBox��5.      $	��380��6G   $
��Left=�6S   ��60   �� *Email+6S   �� 50      $��Clave:��6   $��0,10,0,0q�6)   G� 51      -   5         G�Name$ ClavePasswordBox��51      ;   5CondominioADM.Resources.PasswordHelper.PasswordHelper   Attach$
 True��69   $	��380��6�   $
��Left=�6�      Password 6e   �� *Clave+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   53      �� 56      $ 
Horizontal=�6   $��60,20q�62   .+�57      �� -   5        $ NuevoButton��57      .��58      �� $ 
Horizontal=�6!   .+�59      �� $(��"/Resources/Files-New-File-icon.png��6    $��20��6L   �� 5:      $��Nuevo��6    $
��Bold"�60   
�������6B   5;      5<      �� 5>      -   5        $ GuardarButton��5>      $
��15,0q�60   .��5?      �� $ 
Horizontal=�6!   .+�5@      �� $ ��/Resources/floppy-icon.png��6    $��20��6D   �� 5A      $��Guardar��6    $
��Bold"�62   
�������6D   5B      5C      �� 5E      -	   5        $ EliminarButton��5E      .��5F      �� $ 
Horizontal=�6!   .+�5G      �� $-��'/Resources/blue-document-cross-icon.png��6    �� 5H      $��Eliminar��6    $
��Bold"�64   
�������6F   5I      5J      5K      5M      5N      5O      