   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo13.ModeloRegistro.views.dashboard.modelos.anexo13  5      8    2ModeloRegistro.views.dashboard.modelos.anexo13.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo13     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 13��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      *(SOLICITUD DE TRANSCRIPCION DE NACIMIENTO6X   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$* $Sr. Cónsul General de Cuba en Fecha��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5=      -   5         ��Name$ nombre_comparece��5=      $��12q�5>       ! MaterialDesignOutlinedTextBox#��[ 5?      
 . $	 1Q�5A      $ Quien comparece��5B      �� 5C      -   5        $ no_pasaporte_comparece��5C      $��12q�5D      #��[ 5E      
 . $	 1Q�5G      $, &Ciudadano(a) con pasaporte cubano Nro.��5H      �� 5I      $��0q�6   $��Center=�5J      $
��Bold"�5K      DATOS DE LA INSCRIPCION6G   �� 5L      -   5        $ nombre_inscripcion��5L      $��12q�5M      #��[ 5N      
 . $	 1Q�5P      $ 	Nombre(s)��5Q      �� 5S      $��12q�6   $��Center=�5T      $
��Bold"�5U      *(SOLICITUD DE TRANSCRIPCION DE NACIMIENTO6X   �� 5W      $��Center=�6   $
��Bold"�5X      Sexo:65   � 5Y      $��Center=�6   .+�5Z      �� -   5         ��Name$ m��5Z      $��M��5[      $��12q�5\      �� 5]      -   5        $ f��5]      $��F��5^      $��12q�5_      5`      � 5c       � ColumnDefinitions 5d      �� 5e      �� 5f      .+�5h      �� -   5        $! primer_apellido_inscripcion��5h      $��12q�5i      #��[ 5j      
 . $	 1Q�5l      $ Primer Apellido��5m      �� 5n      -	   5        $" segundo_apellido_inscripcion��5n      $��12q�5o      #��[ 5p      
 . $	 1Q�5r      $ Segundo Apellido��5s      $��1��5t      5u      �� 5w      $��0q�6   $��Center=�5x      $
��Bold"�5y      Fecha Nacimiento6@   � 5{       5|      �� 5}      �� 5~      .+�5�      )  #MaterialDesignThemes.Wpf.TimePicker  -
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
 . $	 1Q�5�      $ Primer Apellido��5�      $	��165��5�      �� 5      -   5        $ segundo_apellido_madre��5      $��12q�5     #��[ 5     
 . $	 1Q�5     $ 2do.Apellidos��5     $	��165��5     �� 5     -   5        $ ciudadania_madre��5     $��12q�5     #��[ 5	     
 . $	 1Q�5     $ Ciudadanía��5     $	��165��5     �� 5     -   5        $ natural_de_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ 
Natural de��5     $	��165��5     �� 5     -   5        $ nro_pasaporte_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ Nro. de Pasaporte��5     $	��165��5     �� 5     -   5        $ domicilio_madre��5     $��12q�5     #��[ 5     
 . $	 1Q�5      $ 	Domicilio��5!     $	��165��5"     5#     �� 5%     $��12q�6   $��Center=�5&     $
��Bold"�5'      Nombre de los Abuelos Paternos6N   � 5(      5)     �� 5*     �� 5+     .+�5-     �� -   5        $ nombre_abuelo_paterno��5-     $��12q�5.     #��[ 5/     
 . $	 1Q�51     $ Abuelo paterno��52     �� 53     -    5        $ nombre_abuela_paterna��53     $��12q�54     #��[ 55     
 . $	 1Q�57     $ Abuela materna��58     $��1��59     5:     �� 5<     $��12q�6   $��Center=�5=     $
��Bold"�5>      Nombre de los Abuelos Maternos6N   � 5?      5@     �� 5A     �� 5B     .+�5D     �� -!   5        $ nombre_abuelo_materno��5D     $��12q�5E     #��[ 5F     
 . $	 1Q�5H     $ Abuelo paterno��5I     �� 5J     -"   5        $ nombre_abuela_materna��5J     $��12q�5K     #��[ 5L     
 . $	 1Q�5N     $ Abuela materna��5O     $��1��5P     5Q     � 5S     .+�5T     �� -#   5        $# nombre_apellido_soltera_madre��5T     $��12q�5U     #��[ 5V     
 . $	 1Q�5X     $. (Nombre y apellido de soltera de la Madre��5Y     $	��230��5Z     �� 5[     -$   5        $% nombre_inscrito_pais_nacimineto��5[     $��12q�5\     #��[ 5]     
 . $	 1Q�5_     $4 .Nombre del Inscripto en el País de Nacimiento��5`     $	��230��5a     �� 5b     -%   5        $) #inscripcion_practicada_en_virtud_de��5b     $��12q�5c     #��[ 5d     
 . $	 1Q�5f     $* $Inscripción practicada en virtud de��5g     $	��230��5h     5i     �� 5k     -&   5        $ observaciones��5k     $��12q�5l     #��[ 5m     
 . $	 1Q�5o     $ Observaciones��5p     $	��100��5q      �� TextWrapping$
 Wrap=�5r     " �� VerticalScrollBarVisibility$
 Auto=�5s     �� 5u     -'   5          MaterialDesignRaisedButton#��[ 5u     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5v     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5z     $	��Top=�5{     $��12q�5|     $	��246��5}     $��46��5~     .��5�     � .+�5�       $ CircleEditOutline=�62   $��20��5�  2   $��20��5�  2   �� 5�     $��Center=�6$   $��7,0,0,0q�5�  $   
Actualizar6A   5�     5�     5�     5�     5�     5�     