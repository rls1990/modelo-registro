   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo20.ModeloRegistro.views.dashboard.modelos.anexo20  5      8    2ModeloRegistro.views.dashboard.modelos.anexo20.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo20     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 20��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      {yModelo No. 4. Solicitud de la Adquisición de la Ciudadanía Cubana por Nacimiento. Cuando la realiza una tercera persona6�   � 58      .+�59      �� -   5         ��Name$ nombre_apellidos��59      $��12q�5:       ! MaterialDesignOutlinedTextBox#��[ 5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5=      
   Hint$
 Nombre y dos apellidos��5>      $	��230��5?      �� 5@      -   5        $ 	ciudadano��5@      $��12q�5A      #��[ 5B       . $	 1Q�5D      $
 	Ciudadano��5E      $	��230��5F      �� 5G      -   5        $! nombre_apellidos_menor_edad��5G      $��12q�5H      #��[ 5I       . $	 1Q�5K      $'
 !Nombre y dos apellidos menor edad��5L      $	��230��5M      �� 5N      -   5        $ ciudadania_menor_edad��5N      $��12q�5O      #��[ 5P       . $	 1Q�5R      $
 	Ciudadano��5S      $	��230��5T      �� 5U      -   5        $ lugar_nacimiento_menor��5U      $��12q�5V      #��[ 5W       . $	 1Q�5Y      $
 Lugar de nacimiento��5Z      $	��230��5[      (  "System.Windows.Controls.DatePicker  5\      -   5          Name$ fecha_nacimiento_menor��5\   !   $
 Fecha de Nacimiento��5]   !   $��12q�5^   !    $  MaterialDesignOutlinedDatePicker#��[ 5_   !   $	 1Q�5`   !    . $	��230��5b   !   �� 5c      -   5        $ pasaporte_menor��5c      $��12q�5d      #��[ 5e       . $	 1Q�5g      $
 Nro. Pasaporte��5h      $	��230��5i      �� 5j      -	   5        $ padre��5j      $��12q�5k      #��[ 5l       . $	 1Q�5n      $
 Padre��5o      $	��230��5p      �� 5q      -
   5        $ ciudadania_padre��5q      $��12q�5r      #��[ 5s       . $	 1Q�5u      $
 Ciudadania Padre��5v      $	��230��5w      �� 5x      -   5        $ madre��5x      $��12q�5y      #��[ 5z       . $	 1Q�5|      $
 Madre��5}      $	��230��5~      �� 5      -   5        $ ciudadania_madre��5      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Ciudadania Madre��5�      $	��230��5�      �� 5�      -   5        $ ultima_direccion_padres��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $1
 +Última dirección en Cuba del o los padres��5�      $	��230��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      FDManifiesto que la intención de los padres/padre/representante legal6s   �� 5�      -   5        $( "nombre_persona_representante_legal��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $1
 +Última dirección en Cuba del o los padres��5�      �� 5�      $��12q�6   $��Center=�5�      $
��Bold"�5�      respecto a su hijo es que6I   � 5�      $��12q�6   $	��482��5�      .+�5�      �� -   5         ��Name$ recidir_cuba��5�      $��Resida en Cuba��5�      $��0,0,12,0q�5�      �� 5�      -   5        $ recidir_en_exterior��5�      $��Resida en el exterior��5�      5�      �� 5�      -   5        $ razones_personales��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $1
 +Última dirección en Cuba del o los padres��5�       �� TextWrapping$
 Wrap=�5�      �� 5�      -   5        $! nombre_funcionario_consular��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $!
 Nombre Funcionario Consular��5�      �� 5�      -   5        $ telefono��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 	Teléfono��5�      �� 5�      -   5        $ email��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 E-MAIL��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      