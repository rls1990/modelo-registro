   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo14.ModeloRegistro.views.dashboard.modelos.anexo14  5      8    2ModeloRegistro.views.dashboard.modelos.anexo14.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo14     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 14��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      '%SOLICITUD TRANSCRIPCION DE MATRIMONIO6U   �� 58      -   5         ��Name$ quien_suscribe��58      $��12q�59       ! MaterialDesignOutlinedTextBox#��[ 5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5<      
   Hint$
 Quien suscribe��5=      �� 5>      $��0q�6   $��Center=�5?      $
��Bold"�5@      DATOS DEL CONTRAYENTE6E   � 5A      .+�5B      �� -   5        $ nombre_contrayente��5B      $��12q�5C      #��[ 5D       . $	 1Q�5F      $
 	Nombre(s)��5G      $	��165��5H      �� 5I      -   5        $ ciudadania_contrayente��5I      $��12q�5J      #��[ 5K       . $	 1Q�5M      $
 Ciudadanía��5N      $	��165��5O      �� 5P      -   5        $! primer_apellido_contrayente��5P      $��12q�5Q      #��[ 5R       . $	 1Q�5T      $
 Primer Apellido��5U      $	��165��5V      �� 5W      -   5        $" segundo_apellido_contrayente��5W      $��12q�5X      #��[ 5Y       . $	 1Q�5[      $
 Segundo Apellido��5\      $	��165��5]      �� 5^      -   5        $  registro_civil_contrayente��5^      $��12q�5_      #��[ 5`       . $	 1Q�5b      $*
 $Registro Civil donde está Inscripto��5c      $	��165��5d      �� 5e      -   5        $ tomo_contrayente��5e      $��12q�5f      #��[ 5g       . $	 1Q�5i      $

 Tomo��5j      $	��165��5k      �� 5l      -	   5        $ folio_contrayente��5l      $��12q�5m      #��[ 5n       . $	 1Q�5p      $
 Folio��5q      $	��165��5r      �� 5s      -
   5        $" lugar_nacimiento_contrayente��5s      $��12q�5t      #��[ 5u       . $	 1Q�5w      $
 Lugar de nacimiento��5x      $	��165��5y      (  "System.Windows.Controls.DatePicker  5z      -   5          Name$" fecha_nacimiento_contrayente��5z   !   $
 Fecha Nacimiento��5{   !   $��12q�5|   !    $  MaterialDesignOutlinedDatePicker#��[ 5}   !   $	 1Q�5~   !    . $	��165��5�   !   �� 5�      -   5        $) #nro_pasaporte_identidad_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $ 
 Nro. Pasaporte o Identidad��5�      $	��165��5�      �� 5�      -   5        $/ )estado_civil_antes_matrimonio_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $+
 %Estado Civil: (antes del matrimonio )��5�      $	��165��5�      �� 5�      -   5        $ ocupacion_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 
Ocupación��5�      $	��165��5�      �� 5�      -   5        $ padre_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $%
 Nombre(s) y Apellidos del Padre��5�      $	��165��5�      �� 5�      -   5        $ madre_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $'
 !Nombre(s) y Apellidos de la Madre��5�      $	��165��5�      �� 5�      -   5        $ domicilio_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Domicilio permanente��5�      $	��165��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DE LA CONTRAYENTE6G   � 5�      .+�5�      �� -   5        $ nombre_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 	Nombre(s)��5�      $	��165��5�      �� 5�      -   5        $ ciudadania_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Ciudadanía��5�      $	��165��5�      �� 5�      -   5        $$ primer_apellido_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Primer Apellido��5�      $	��165��5�      �� 5�      -   5        $% segundo_apellido_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Segundo Apellido��5�      $	��165��5�      �� 5�      -   5        $# registro_civil_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $*
 $Registro Civil donde está Inscripto��5�      $	��165��5�      �� 5�      -   5        $ tomo_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $

 Tomo��5�      $	��165��5�      �� 5�      -   5        $ folio_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Folio��5�      $	��165��5�      �� 5�      -   5        $% lugar_nacimiento_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Lugar de nacimiento��5�      $	��165��5�        5�      -   5        $% fecha_nacimiento_la_contrayente��5�   !   $
 Fecha Nacimiento��5�   !   $��12q�5�   !   #��[ 5�   !   $	 1Q�5�   !    . $	��165��5�   !   �� 5�      -   5        $, &nro_pasaporte_identidad_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $ 
 Nro. Pasaporte o Identidad��5�      $	��165��5�      �� 5�      -   5        $2 ,estado_civil_antes_matrimonio_la_contrayente��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $+
 %Estado Civil: (antes del matrimonio )��5�      $	��165��5�      �� 5�      -   5        $ ocupacion_la_contrayente��5�      $��12q�5      #��[ 5      . $	 1Q�5     $
 
Ocupación��5     $	��165��5     �� 5     -   5        $ padre_la_contrayente��5     $��12q�5     #��[ 5      . $	 1Q�5
     $%
 Nombre(s) y Apellidos del Padre��5     $	��165��5     �� 5     -   5        $ madre_la_contrayente��5     $��12q�5     #��[ 5      . $	 1Q�5     $'
 !Nombre(s) y Apellidos de la Madre��5     $	��165��5     �� 5     -    5        $ domicilio_la_contrayente��5     $��12q�5     #��[ 5      . $	 1Q�5     $
 Domicilio permanente��5     $	��165��5     �� 5     -!   5        $" observaciones_la_contrayente��5     $��12q�5     #��[ 5      . $	 1Q�5     $
 Observaciones��5      $	��165��5!     5"     �� 5$     $��0q�6   $��Center=�5%     $
��Bold"�5&     $"DATOS DEL CERTIFCADO DE MATRIMONIO6R   � 5'     .+�5(     �� -"   5        $ lugar_certificado��5(     $��12q�5)     #��[ 5*      . $	 1Q�5,     $G
 ALugar donde se efectúo el Matrimonio (municipio, estado y país)��5-     $	��165��5.     �� 5/     -#   5        $ tomo_certificado��5/     $��12q�50     #��[ 51      . $	 1Q�53     $

 Tomo��54     $	��165��55     �� 56     -$   5        $ folio_certificado��56     $��12q�57     #��[ 58      . $	 1Q�5:     $
 Folio��5;     $	��165��5<       5=     -%   5        $ fecha_formalizacion��5=  !   $
 Fecha de Formalización��5>  !   $��12q�5?  !   #��[ 5@  !   $	 1Q�5A  !    . $	��165��5C  !   �� 5D     -&   5        $- 'nombre_funcionario_expidió_certificado��5D     $��12q�5E     #��[ 5F      . $	 1Q�5H     $F
 @Nombre del Funcionario que expidió el Certificado de Matrimonio��5I     $	��165��5J     �� 5K     -'   5        $, &cargo_funcionario_expidió_certificado��5K     $��12q�5L     #��[ 5M      . $	 1Q�5O     $
 Cargo��5P     $	��165��5Q       5R     -(   5        $ fecha_solicitud��5R  !   $
 Fecha de Solicitud��5S  !   $��12q�5T  !   #��[ 5U  !   $	 1Q�5V  !    . $	��165��5X  !   5Y     �� 5Z     -)   5          MaterialDesignRaisedButton#��[ 5Z     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5[     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5_     $	��Top=�5`     $��12q�5a     $	��246��5b     $��46��5c     .��5e     � .+�5f       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5g  2   $��20��5h  2   �� 5i     $��Center=�6$   $��7,0,0,0q�5j  $   	Adicionar6@   5k     5l     5n     5o     5q     5r     