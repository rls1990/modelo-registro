   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo13.ModeloRegistro.views.dashboard.modelos.anexo13  5      8    2ModeloRegistro.views.dashboard.modelos.anexo13.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo13     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 13��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      *(SOLICITUD DE TRANSCRIPCION DE NACIMIENTO6X   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ fecha_solicitud��58      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$* $Sr. Cónsul General de Cuba en Fecha��59      $��12q�5:       $  MaterialDesignOutlinedDatePicker#��[ 5;      	   FloatingScale$	 1Q�5<      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5=      �� 5>      -   5         ��Name$ nombre_comparece��5>      $��12q�5?       ! MaterialDesignOutlinedTextBox#��[ 5@      
 . $	 1Q�5B      $ Quien comparece��5C      �� 5D      -   5        $ no_pasaporte_comparece��5D      $��12q�5E      #��[ 5F      
 . $	 1Q�5H      $, &Ciudadano(a) con pasaporte cubano Nro.��5I      �� 5J      $��0q�6   $��Center=�5K      $
��Bold"�5L      DATOS DE LA INSCRIPCION6G   �� 5M      -   5        $ nombre_inscripcion��5M      $��12q�5N      #��[ 5O      
 . $	 1Q�5Q      $ 	Nombre(s)��5R      �� 5T      $��12q�6   $��Center=�5U      $
��Bold"�5V      *(SOLICITUD DE TRANSCRIPCION DE NACIMIENTO6X   �� 5X      $��Center=�6   $
��Bold"�5Y      Sexo:65   � 5Z      $��Center=�6   .+�5[      �� -   5         ��Name$ m��5[      $��M��5\      $��12q�5]      �� 5^      -   5        $ f��5^      $��F��5_      $��12q�5`      5a      � 5d       � ColumnDefinitions 5e      �� 5f      �� 5g      .+�5i      �� -   5        $! primer_apellido_inscripcion��5i      $��12q�5j      #��[ 5k      
 . $	 1Q�5m      $ Primer Apellido��5n      �� 5o      -	   5        $" segundo_apellido_inscripcion��5o      $��12q�5p      #��[ 5q      
 . $	 1Q�5s      $ Segundo Apellido��5t      $��1��5u      5v      �� 5x      $��0q�6   $��Center=�5y      $
��Bold"�5z      Fecha Nacimiento6@   � 5|       5}      �� 5~      �� 5      .+�5�      )  #MaterialDesignThemes.Wpf.TimePicker  -
   5          Name$ hora_nacimiento��5�   0   $ Hora Nacimiento��5�   0    $  MaterialDesignOutlinedTimePicker#��[ 5�   0   $��12q�5�   0     5�      -   5        $ fecha_nacimineto��5�   !   $ Fecha de Nacimineto��5�   !   $��12q�5�   !   #��[ 5�   !   $	 1Q�5�   !   
 . $��1��5�   !   5�      �� 5�      -   5        $* $referencia_territorio_registro_civil��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $/ )Referencia Territorial del Registro Civil��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�       Referencia Registral del País6M   � 5�      $��Center=�6   .+�5�      �� -   5        $ tomo_referencia_registral��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $
 Tomo��5�      $	��165��5�      �� 5�      -   5        $  folio_referencia_registral��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Folio��5�      $	��165��5�      �� 5�      -   5        $ nro_asiento��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Nro. de Asiento��5�      $	��165��5�      �� 5�      -   5        $ lugar_nacimineto��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Lugar de nacimiento��5�      $	��165��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL PADRE6?   � 5�      $��Center=�6   .+�5�      �� -   5        $ nombre_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 	Nombre(s)��5�      $	��165��5�      �� 5�      -   5        $ primer_apellido_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Primer Apellido��5�      $	��165��5�      �� 5�      -   5        $ segundo_apellido_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 2do.Apellidos��5�      $	��165��5�      �� 5�      -   5        $ ciudadania_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Ciudadanía��5�      $	��165��5�      �� 5�      -   5        $ natural_de_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 
Natural de��5�      $	��165��5�      �� 5�      -   5        $ nro_pasaporte_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Nro. de Pasaporte��5�      $	��165��5�      �� 5�      -   5        $ domicilio_padre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 	Domicilio��5�      $	��165��5�      5�      �� 5�      $��12q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL MADRE6?   � 5�      $��Center=�6   .+�5�      �� -   5        $ nombre_madre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 	Nombre(s)��5�      $	��165��5�      �� 5�      -   5        $ primer_apellido_madre��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Primer Apellido��5�      $	��165��5      �� 5     -   5        $ segundo_apellido_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ 2do.Apellidos��5     $	��165��5     �� 5     -   5        $ ciudadania_madre��5     $��12q�5	     #��[ 5
     
 . $	 1Q�5     $ Ciudadanía��5     $	��165��5     �� 5     -   5        $ natural_de_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ 
Natural de��5     $	��165��5     �� 5     -   5        $ nro_pasaporte_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ Nro. de Pasaporte��5     $	��165��5     �� 5     -   5        $ domicilio_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5!     $ 	Domicilio��5"     $	��165��5#     5$     �� 5&     $��12q�6   $��Center=�5'     $
��Bold"�5(      Nombre de los Abuelos Paternos6N   � 5)      5*     �� 5+     �� 5,     .+�5.     �� -   5        $ nombre_abuelo_paterno��5.     $��12q�5/     #��[ 50     
 . $	 1Q�52     $ Abuelo paterno��53     �� 54     -    5        $ nombre_abuela_paterna��54     $��12q�55     #��[ 56     
 . $	 1Q�58     $ Abuela materna��59     $��1��5:     5;     �� 5=     $��12q�6   $��Center=�5>     $
��Bold"�5?      Nombre de los Abuelos Maternos6N   � 5@      5A     �� 5B     �� 5C     .+�5E     �� -!   5        $ nombre_abuelo_materno��5E     $��12q�5F     #��[ 5G     
 . $	 1Q�5I     $ Abuelo paterno��5J     �� 5K     -"   5        $ nombre_abuela_materna��5K     $��12q�5L     #��[ 5M     
 . $	 1Q�5O     $ Abuela materna��5P     $��1��5Q     5R     � 5T     .+�5U     �� -#   5        $# nombre_apellido_soltera_madre��5U     $��12q�5V     #��[ 5W     
 . $	 1Q�5Y     $. (Nombre y apellido de soltera de la Madre��5Z     $	��230��5[     �� 5\     -$   5        $% nombre_inscrito_pais_nacimineto��5\     $��12q�5]     #��[ 5^     
 . $	 1Q�5`     $4 .Nombre del Inscripto en el País de Nacimiento��5a     $	��230��5b     �� 5c     -%   5        $) #inscripcion_practicada_en_virtud_de��5c     $��12q�5d     #��[ 5e     
 . $	 1Q�5g     $* $Inscripción practicada en virtud de��5h     $	��230��5i     5j     �� 5l     -&   5        $ observaciones��5l     $��12q�5m     #��[ 5n     
 . $	 1Q�5p     $ Observaciones��5q     $	��100��5r      �� TextWrapping$
 Wrap=�5s     " �� VerticalScrollBarVisibility$
 Auto=�5t     �� 5v     -'   5          MaterialDesignRaisedButton#��[ 5v     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5w     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5{     $	��Top=�5|     $��12q�5}     $	��246��5~     $��46��5     .��5�     � .+�5�       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�  2   $��20��5�  2   �� 5�     $��Center=�6$   $��7,0,0,0q�5�  $   	Adicionar6@   5�     5�     5�     5�     5�     5�     