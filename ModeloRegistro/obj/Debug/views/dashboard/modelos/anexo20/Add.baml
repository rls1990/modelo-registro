   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo20.ModeloRegistro.views.dashboard.modelos.anexo20  5      8    2ModeloRegistro.views.dashboard.modelos.anexo20.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo20     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 20��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      {yModelo No. 4. Solicitud de la Adquisición de la Ciudadanía Cubana por Nacimiento. Cuando la realiza una tercera persona6�   � 59      .+�5:      �� -   5         ��Name$ nombre_apellidos��5:      $��12q�5;       ! MaterialDesignOutlinedTextBox#��[ 5<      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5>      
   Hint$
 Nombre y dos apellidos��5?      $	��230��5@      �� 5A      -   5        $ 	ciudadano��5A      $��12q�5B      #��[ 5C       . $	 1Q�5E      $
 	Ciudadano��5F      $	��230��5G      �� 5H      -   5        $! nombre_apellidos_menor_edad��5H      $��12q�5I      #��[ 5J       . $	 1Q�5L      $'
 !Nombre y dos apellidos menor edad��5M      $	��230��5N      �� 5O      -   5        $ ciudadania_menor_edad��5O      $��12q�5P      #��[ 5Q       . $	 1Q�5S      $
 	Ciudadano��5T      $	��230��5U      �� 5V      -   5        $ lugar_nacimiento_menor��5V      $��12q�5W      #��[ 5X       . $	 1Q�5Z      $
 Lugar de nacimiento��5[      $	��230��5\      (  "System.Windows.Controls.DatePicker  5]      -   5          Name$ fecha_nacimiento_menor��5]   !   $
 Fecha de Nacimiento��5^   !   $��12q�5_   !    $  MaterialDesignOutlinedDatePicker#��[ 5`   !   $	 1Q�5a   !    . $	��230��5c   !   �� 5d      -   5        $ pasaporte_menor��5d      $��12q�5e      #��[ 5f       . $	 1Q�5h      $
 Nro. Pasaporte��5i      $	��230��5j      �� 5k      -	   5        $ padre��5k      $��12q�5l      #��[ 5m       . $	 1Q�5o      $
 Padre��5p      $	��230��5q      �� 5r      -
   5        $ ciudadania_padre��5r      $��12q�5s      #��[ 5t       . $	 1Q�5v      $
 Ciudadania Padre��5w      $	��230��5x      �� 5y      -   5        $ madre��5y      $��12q�5z      #��[ 5{       . $	 1Q�5}      $
 Madre��5~      $	��230��5      �� 5�      -   5        $ ciudadania_madre��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
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
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5�      5�      