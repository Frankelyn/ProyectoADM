   M S B A M L   `   `   `  ����H  DCondominioADM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CondominioADM.UICondominioADM.UI  5   	   _4clr-namespace:CondominioADM.Resources.PasswordHelper&CondominioADM.Resources.PasswordHelper  5   	       CondominioADM.UI.Login   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CondominioADM.UI     5   	   OPasswordHelper4clr-namespace:CondominioADM.Resources.PasswordHelper     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Login��5   	   $	��375��6   $	��600��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ CanMinimize=�6U   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      #  MaterialDesignThemes.Wpf.Card  $��32q�6"   $��16q�6/   $	��350��6;   .��5      �� $ Vertical=�6   .+�5      �� $��Email��6   �� 5      -   5         ��Name$ EmailTextBox��5      ��64   �� *Email+6K   �� 5      $��Contraseña��6   $��0,20,0,0q�61   G� 5      -   5         G�Name$ ContrasenaPasswordBox��5   "   ;   5CondominioADM.Resources.PasswordHelper.PasswordHelper   Attach$
 True��6A   	   Password	 6m   �� *
Contrasena+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $ 
Horizontal=�6!   $��25q�6:   $��Center=�6F   $��40��6c   $	��250��6o   .+�5      �� -   5         ��Name$ IngresarButton��5   !   $��Acceder��69   $
��10,0q�6K   $
��Bold"�6w   
�������6�   �� 5      -   5        $ CancelarButton��5   !   $��20,0,0,0q�6Y   .��5       �� $ 
Horizontal=�6)   .+�5!   "   �� $��Cancelar��6(   $
��Bold"�6;   
�������6M   5"      5#      5$      5%      5&      5'      5(      5)      