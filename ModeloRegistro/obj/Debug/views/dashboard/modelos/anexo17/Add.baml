   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo17.ModeloRegistro.views.dashboard.modelos.anexo17  5      8    2ModeloRegistro.views.dashboard.modelos.anexo17.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo17     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 17��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      fdModelo No. 1 Solicitud de la Adquisición de la Ciudadanía Cubana por Nacimiento. (Mayores de edad)6�   � 58      .+�59      �� -   5         ��Name$ nombre_apellidos��59      $��12q�5:       ! MaterialDesignOutlinedTextBox#��[ 5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5=      
   Hint$
 Nombre y dos apellidos��5>      $	��230��5?      �� 5@      -   5        $ 	ciudadano��5@      $��12q�5A      #��[ 5B       . $	 1Q�5D      $
 	Ciudadano��5E      $	��230��5F      �� 5G      -   5        $ lugar_nacimiento��5G      $��12q�5H      #��[ 5I       . $	 1Q�5K      $
 Lugar de nacimiento��5L      $	��230��5M      (  "System.Windows.Controls.DatePicker  5N      -   5          Name$ fecha_nacimiento��5N   !   $
 Fecha de Nacimiento��5O   !   $��12q�5P   !    $  MaterialDesignOutlinedDatePicker#��[ 5Q   !   $	 1Q�5R   !    . $	��230��5T   !   �� 5U      -   5        $ 	pasaporte��5U      $��12q�5V      #��[ 5W       . $	 1Q�5Y      $
 Nro. Pasaporte��5Z      $	��230��5[      �� 5\      -   5        $ padre��5\      $��12q�5]      #��[ 5^       . $	 1Q�5`      $
 Padre��5a      $	��230��5b      �� 5c      -   5        $ ciudadania_padre��5c      $��12q�5d      #��[ 5e       . $	 1Q�5g      $
 Ciudadania Padre��5h      $	��230��5i      �� 5j      -	   5        $ madre��5j      $��12q�5k      #��[ 5l       . $	 1Q�5n      $
 Madre��5o      $	��230��5p      �� 5q      -
   5        $ ciudadania_madre��5q      $��12q�5r      #��[ 5s       . $	 1Q�5u      $
 Ciudadania Madre��5v      $	��230��5w      � 5x      $��12q�6    $	��482��5y       .+�5z      �� $��0,0,12,0q�6$   $��Center=�5{   $   $
��Bold"�5|   $   $��Center=�5}   $   Manifiesto mi intención de:6\   �� 5~      -   5         ��Name$ recidir_cuba��5~   #   $��Residir en Cuba��5   #   $��0,0,12,0q�5�   #   �� 5�      -   5        $ recidir_en_exterior��5�   #   $��Residir en el exterior��5�   #   5�      5�      �� 5�      -   5        $ razones_personales��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Razones personales��5�       �� TextWrapping$
 Wrap=�5�      �� 5�      -   5        $ nombre_funcionario��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Nombre funcionario��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      $"DATOS DE CONTACTO DEL SOLICITANTE:6R   �� 5�      -   5        $ telefono��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 	Teléfono��5�      �� 5�      -   5        $ email��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 E-MAIL��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5�      5�      