   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo17.ModeloRegistro.views.dashboard.modelos.anexo17  5      8    2ModeloRegistro.views.dashboard.modelos.anexo17.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo17     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 17��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      fdModelo No. 1 Solicitud de la Adquisición de la Ciudadanía Cubana por Nacimiento. (Mayores de edad)6�   � 57      .+�58      �� -   5         ��Name$ nombre_apellidos��58      $��12q�59       ! MaterialDesignOutlinedTextBox#��[ 5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5<      
   Hint$
 Nombre y dos apellidos��5=      $	��230��5>      �� 5?      -   5        $ 	ciudadano��5?      $��12q�5@      #��[ 5A       . $	 1Q�5C      $
 	Ciudadano��5D      $	��230��5E      �� 5F      -   5        $ lugar_nacimiento��5F      $��12q�5G      #��[ 5H       . $	 1Q�5J      $
 Lugar de nacimiento��5K      $	��230��5L      (  "System.Windows.Controls.DatePicker  5M      -   5          Name$ fecha_nacimiento��5M   !   $
 Fecha de Nacimiento��5N   !   $��12q�5O   !    $  MaterialDesignOutlinedDatePicker#��[ 5P   !   $	 1Q�5Q   !    . $	��230��5S   !   �� 5T      -   5        $ 	pasaporte��5T      $��12q�5U      #��[ 5V       . $	 1Q�5X      $
 Nro. Pasaporte��5Y      $	��230��5Z      �� 5[      -   5        $ padre��5[      $��12q�5\      #��[ 5]       . $	 1Q�5_      $
 Padre��5`      $	��230��5a      �� 5b      -   5        $ ciudadania_padre��5b      $��12q�5c      #��[ 5d       . $	 1Q�5f      $
 Ciudadania Padre��5g      $	��230��5h      �� 5i      -	   5        $ madre��5i      $��12q�5j      #��[ 5k       . $	 1Q�5m      $
 Madre��5n      $	��230��5o      �� 5p      -
   5        $ ciudadania_madre��5p      $��12q�5q      #��[ 5r       . $	 1Q�5t      $
 Ciudadania Madre��5u      $	��230��5v      � 5w      $��12q�6    $	��482��5x       .+�5y      �� $��0,0,12,0q�6$   $��Center=�5z   $   $
��Bold"�5{   $   $��Center=�5|   $   Manifiesto mi intención de:6\   �� 5}      -   5         ��Name$ recidir_cuba��5}   #   $��Residir en Cuba��5~   #   $��0,0,12,0q�5   #   �� 5�      -   5        $ recidir_en_exterior��5�   #   $��Residir en el exterior��5�   #   5�      5�      �� 5�      -   5        $ razones_personales��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Razones personales��5�       �� TextWrapping$
 Wrap=�5�      �� 5�      -   5        $ nombre_funcionario��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Nombre funcionario��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      $"DATOS DE CONTACTO DEL SOLICITANTE:6R   �� 5�      -   5        $ telefono��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 	Teléfono��5�      �� 5�      -   5        $ email��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 E-MAIL��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      