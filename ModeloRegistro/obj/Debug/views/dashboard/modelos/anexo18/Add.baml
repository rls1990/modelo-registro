   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo18.ModeloRegistro.views.dashboard.modelos.anexo18  5      8    2ModeloRegistro.views.dashboard.modelos.anexo18.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo18     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 18��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      ��Modelo No. 2 Solicitud de la Adquisición de la Ciudadanía Cubana por Nacimiento. (Menores de edad o incapacitados judicialmente)6�   � 57      .+�58      �� -   5         ��Name$ nombre_hombre��58      $��12q�59       ! MaterialDesignOutlinedTextBox#��[ 5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5<      
   Hint$
 Nombre Hombre��5=      $	��230��5>      �� 5?      -   5        $ nombre_mujer��5?      $��12q�5@      #��[ 5A       . $	 1Q�5C      $
 Nombre Mujer��5D      $	��230��5E      �� 5F      -   5        $ ciudadania_hombre��5F      $��12q�5G      #��[ 5H       . $	 1Q�5J      $
 Ciudadania Hombre��5K      $	��230��5L      �� 5M      -   5        $ ciudadania_mujer��5M      $��12q�5N      #��[ 5O       . $	 1Q�5Q      $
 Ciudadania Mujer��5R      $	��230��5S      �� 5T      -   5        $ lugar_nacimiento_hombre��5T      $��12q�5U      #��[ 5V       . $	 1Q�5X      $ 
 Lugar de nacimiento Hombre��5Y      $	��230��5Z      �� 5[      -   5        $ lugar_nacimiento_mujer��5[      $��12q�5\      #��[ 5]       . $	 1Q�5_      $
 Lugar de nacimiento Mujer��5`      $	��230��5a      (  "System.Windows.Controls.DatePicker  5b      -   5          Name$ fecha_nacimiento_hombre��5b   !   $ 
 Fecha de nacimiento Hombre��5c   !   $��12q�5d   !    $  MaterialDesignOutlinedDatePicker#��[ 5e   !   $	 1Q�5f   !    . $	��230��5h   !     5i      -	   5        $ fecha_nacimiento_mujer��5i   !   $
 Fecha de nacimiento Mujer��5j   !   $��12q�5k   !   #��[ 5l   !   $	 1Q�5m   !    . $	��230��5o   !   �� 5p      -
   5        $ pasaporte_hombre��5p      $��12q�5q      #��[ 5r       . $	 1Q�5t      $
 Nro. Pasaporte Hombre��5u      $	��230��5v      �� 5w      -   5        $ pasaporte_mujer��5w      $��12q�5x      #��[ 5y       . $	 1Q�5{      $
 Nro. Pasaporte Mujer��5|      $	��230��5}      �� 5~      -   5        $ nombre_hijo_menor��5~      $��12q�5      #��[ 5�       . $	 1Q�5�      $
 Nombre hijo menor��5�      $	��230��5�      �� 5�      -   5        $ ciudadania_hijo_menor��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Ciudadania hijo menor��5�      $	��230��5�      �� 5�      -   5        $! lugar_nacimineto_hijo_menor��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $!
 Lugar nacimineto hijo menor��5�      $	��230��5�        5�      -   5        $! fecha_nacimiento_hijo_menor��5�   !   $$
 Fecha de nacimiento Hijo menor��5�   !   $��12q�5�   !   #��[ 5�   !   $	 1Q�5�   !    . $	��230��5�   !   �� 5�      -   5        $ pasaporte_hijo_menor��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Pasaporte hijo menor��5�      $	��230��5�      5�      �� 5�      $��12q�6   $��Center=�5�      $
��Bold"�5�      $
��Wrap=�5�      ��Nota: Si la solicitud se presenta por el representante legal, constatar los datos de los padres del niño menor o incapaz, de acuerdo con el documento legal que así lo declara.6�   � 5�      .+�5�      �� -   5        $ padre��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Padre��5�      $	��230��5�      �� 5�      -   5        $ ciudadania_padre��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Ciudadania Padre��5�      $	��230��5�      �� 5�      -   5        $ madre��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Madre��5�      $	��230��5�      �� 5�      -   5        $ ciudadania_madre��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Ciudadania Madre��5�      $	��230��5�      �� 5�      -   5        $ ultima_direccion_cuba��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $ 
 Última dirección en Cuba��5�      $	��230��5�      � 5�      $��12q�6    $	��482��5�       .+�5�      �� $��0,0,12,0q�6$   $��Center=�5�   $   $
��Bold"�5�   $   $��Center=�5�   $   Manifiesto mi intención de:6\   �� 5�      -   5         ��Name$ recidir_cuba��5�   #   $��Residir en Cuba��5�   #   $��0,0,12,0q�5�   #   �� 5�      -   5        $ recidir_en_exterior��5�   #   $��Residir en el exterior��5�   #   5�      5�      �� 5�      -   5        $ razones_personales��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Razones personales��5�       �� TextWrapping$
 Wrap=�5�      �� 5�      -   5        $ nombre_funcionario��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Nombre funcionario��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      $"DATOS DE CONTACTO DEL SOLICITANTE:6R   �� 5�      -   5        $ telefono��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 	Teléfono��5�      �� 5�      -   5        $ email��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 E-MAIL��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5     $	��Top=�5     $��12q�5     $	��246��5     $��46��5     .��5     � .+�5       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5	  2   $��20��5
  2   �� 5     $��Center=�6$   $��7,0,0,0q�5  $   	Adicionar6@   5     5     5     5     5     5     