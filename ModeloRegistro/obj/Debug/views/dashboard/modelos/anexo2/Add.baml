   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo2-ModeloRegistro.views.dashboard.modelos.anexo2  5      7    1ModeloRegistro.views.dashboard.modelos.anexo2.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo2     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 2��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   $
��Auto=�55      .+�56      �� $��0q�6   $��Center=�57      $
��Bold"�58       SOLICITUD DE SERVICIO CONSULAR6N   � 59      .+�5:      �� -   5         ��Name$ pasaporte_1ra_vez��5:      $��Pasaporte por primera vez��5;      $��12q�5<      �� 5=      -   5        $ 	prorrogas��5=      $��
Prórrogas��5>      $��12q�5?      �� 5@      -   5        $
 he_1��5@      $
��HE-1��5A      $��12q�5B      �� 5C      -   5        $
 he_4��5C      $
��HE-4��5D      $��12q�5E      �� 5F      -   5        $	 dvt��5F      $	��DVT��5G      $��12q�5H      �� 5I      -   5        $ renovacion_pasaporte��5I      $��Renovación de Pasaporte��5J      $��12q�5K      �� 5L      -   5        $ habilitacion_de_entrada��5L      $��Habilitación de Entrada��5M      $��12q�5N      �� 5O      -	   5        $
 he_3��5O      $
��HE-3��5P      $��12q�5Q      �� 5R      -
   5        $ he_11��5R      $��HE-11��5S      $��12q�5T      �� 5U      -   5        $	 ccv��5U      $	��CCV��5V      $��12q�5W      5X      � 5\       � ColumnDefinitions 5]      �� 5^      �� 5_      �� 5`      .+�5c      (  "System.Windows.Controls.DatePicker  -   5        	  Name$	 fecha_de_solicitud��5c   !   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Fecha de Solicitud��5d   !   $��12q�5e   !    $  MaterialDesignOutlinedDatePicker#��[ 5f   !      FloatingScale$ 1Q�5g   !   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . 5h   !   �� 5j      -   5         ��Name$ no_pasaporte��5j      $��12q�5k      $��1��5l       ! MaterialDesignOutlinedTextBox#��[ 5m       . $ 1Q�5o      $
 Número de Pasaporte��5p      �� 5r      -   5        $ carnet��5r      $��12q�5s      $��2��5t      #��[ 5u       . $ 1Q�5w      $
 Carné de Identidad��5x      5y      �� 5{      $��0q�6   $��Center=�5|      $
��Bold"�5}      Datos Generales6?   � 5~       5      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $ primer_apellido��5�      $��12q�5�      #��[ 5�       . $ 1Q�5�      $
 Primer apellido��5�      �� 5�      -   5        $ segundo_apellido��5�      $��12q�5�      $��1��5�      #��[ 5�       . $ 1Q�5�      $
 Segundo apellido��5�      �� 5�      -   5        $ primer_nombre��5�      $��12q�5�      $��2��5�      #��[ 5�       . $ 1Q�5�      $
 Primer nombre��5�      �� 5�      -   5        $ segundo_nombre��5�      $��12q�5�      $��3��5�      #��[ 5�       . $ 1Q�5�      $
 Segundo nombre��5�      5�      � 5�       5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $ padre��5�      $��12q�5�      #��[ 5�       . $ 1Q�5�      $
 Padre��5�      �� 5�      -   5        $ madre��5�      $��12q�5�      $��1��5�      #��[ 5�       . $ 1Q�5�      $
 Madre��5�      �� 5�      -   5        $  caracteristicas_especiales��5�      $��12q�5�      $��2��5�      #��[ 5�       . $ 1Q�5�      $!
 Características especiales��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ estatura��5�      $��12q�5�      #��[ 5�       . $ 1Q�5�      $
 Estatura(cm)��5�      �� 5�      -   5        $ estado_civil��5�      $��12q�5�      $��1��5�      #��[ 5�       . $ 1Q�5�      $
 Estado Civil��5�      5�      � 5�       5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5         ��Name$
 sexo��5�      $

 Sexo��5�       " MaterialDesignOutlinedComboBox#��[ 5�      $ 1Q�5�       . $��12q�5�      .@�5�      �� $��	Masculino��6'   �� 5�      $��Femenino��6'   5�      �� 5�      -   5        $ 
color_ojos��5�      $
 
Color Ojos��5�      #��[ 5�      $ 1Q�5�       . $��12q�5�      $��1��5�      .@�5�      �� $��Claros��6'   �� 5�      $��Negros��6'   �� 5�      $��Pardos��6'   5�      �� 5�      -   5        $ 
color_piel��5�      $
 
Color Piel��5�      #��[ 5�      $ 1Q�5�       . $��12q�5�      $��2��5�      .@�5�      �� $��Blanca��6'   �� 5�      $��Negra��6'   �� 5�      $��Amarilla��6'   �� 5�      $��Mestiza��6'   �� 5�      $��Albina��6'   5�      �� 5     -   5        $ color_cabello��5     $
 Color cabello��5     #��[ 5     $ 1Q�5      . $��12q�5     $��3��5     .@�5	     �� $��Canoso��6'   �� 5
     $��Negro��6'   �� 5     $��Rubio��6'   �� 5     $��Castaño��6'   �� 5     $
��Rojo��6'   �� 5     $��Otros��6'   5     5     �� 5     $��0q�6   $��Center=�5     $
��Bold"�5     ,*Clasificación Migratoria al salir de Cuba6Y   � 5     .+�5     �� -   5        $ permiso_emigracion��5     $��Permiso Emigración��5     $��12q�5     �� 5     -   5        $ residente_en_el_exterior��5     $��Residente en el Exterior��5     $��12q�5     �� 5     -   5        $ asunto_oficial��5     $��Asunto Oficial��5     $��12q�5     �� 5      -   5        $	 pve��5      $(��"Permiso de Viaje al Exterior (PVE)��5!     $��12q�5"     �� 5#     -    5        $	 psi��5#     $(��"Permiso de Salida Indefinido (PSI)��5$     $��12q�5%     �� 5&     -!   5        $ residencia_exterior��5&     $'��!Residente en el Exterior Especial��5'     $��12q�5(     �� 5)     -"   5        $	 pre��5)     $0��*Permiso de Residencia en el Exterior (PRE)��5*     $��12q�5+     �� 5,     -#   5        $	 pvt��5,     $%��Permiso de Viaje Temporal (PVT)��5-     $��12q�5.     �� 5/     -$   5        $ pre_e��5/     $:��4Permiso de Residenciaen el Exterior Especial (PRE-E)��50     $��12q�51     �� 52     -%   5        $ salida_ilegal��52     $��Salida Ilegal��53     $��12q�54     55       57     -&   5        $	 fecha_de_salida��57     $
 Fecha de Salida��58     $��12q�59     #��[ 5:     $ 1Q�5;      . $	��167��5=     $
��Left=�5>     �� 5@     $��0q�6   $��Center=�5A     $
��Bold"�5B     Lugar de nacimiento6C   � 5D     .+�5E     �� -'   5        $
 pais��5E     $��12q�5F     #��[ 5G      . $ 1Q�5I     $
 País��5J     $	��357��5K     �� 5L     -(   5        $ 	provincia��5L     $��12q�5M     #��[ 5N      . $ 1Q�5P     $
 	Provincia��5Q     $	��357��5R     �� 5S     -)   5        $ municipio_ciudad��5S     $��12q�5T     #��[ 5U      . $ 1Q�5W     $
 Municipio/ Ciudad��5X     $	��357��5Y       5Z     -*   5        $	 fecha_de_nacimiento��5Z  !   $
 Fecha de Nacimiento��5[  !   $��12q�5\  !   #��[ 5]  !   $ 1Q�5^  !    . $	��357��5`  !   5a     �� 5c     $��0q�6   $��Center=�5d     $
��Bold"�5e     Lugar de Residencia actual6J   � 5g      5h     �� 5i     �� 5j      5l     �� 5m     $��3* �6+   �� 5n     .+�5q     �� -+   5        $ 	direccion��5q     $��12q�5r     #��[ 5s      . $ 1Q�5u     $6
 0Dirección (Calle, Ave, Nr., Apto, entre calles)��5v     �� 5w     -,   5        $ codigo_postal��5w     $��12q�5x     #��[ 5y      . $ 1Q�5{     $
 Código Postal��5|     $��Stretch=�5}     $��1��5~     �� 5�     --   5        $ provincia_estado_region��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $$
 Provincia – Estado - Región��5�     $��1��5�     �� 5�     -.   5        $ pais_residencia_actual��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 País��5�     $��Stretch=�5�     $��1��5�     $��1��5�     5�     � 5�      5�     �� 5�     �� 5�     �� 5�     .+�5�     �� -/   5        $ telefono_residencia��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 	Teléfono��5�     �� 5�     -0   5        $ fax_residencia��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $	
 Fax��5�     $��1��5�     �� 5�     -1   5        $ email_residencia��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Email��5�     $��2��5�     5�     �� 5�     $��0q�6   $��Center=�5�     $
��Bold"�5�     %#Datos Laborales o de Estudio actual6S   � 5�     .+�5�     �� -2   5        $# nombre_centro_trabajo_estudio��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $*
 $Nombre de Centro de Trabajo/ Estudio��5�     $	��360��5�     �� 5�     -3   5        $ 	profesion��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 
Profesión��5�     $	��165��5�     �� 5�     -4   5        $ 	ocupacion��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 
Ocupación��5�     $	��165��5�     �� 5�     -5   5        $&  direccion_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $6
 0Dirección (calle, ave, nr., apto, entre calles)��5�     $	��548��5�     �� 5�     -6   5        $* $codigo_postal_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Código Postal��5�     $	��165��5�     �� 5�     -7   5        $4 .provincia_estado_region_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $$
 Provincia – Estado - Región��5�     $	��548��5�     �� 5�     -8   5        $! pais_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 País��5�     $	��165��5�     �� 5�     -9   5        $% telefono_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 	Teléfono��5�     $	��230��5�     �� 5�     -:   5        $  fax_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $	
 Fax��5�     $	��230��5�     �� 5�     -;   5        $" email_centro_estudio_trabajo��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 E-mail��5�     $	��230��5�     �� 5�     -<   5        $ nivel_de_escolaridad��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Nivel de escolaridad��5�     $	��230��5�     �� 5�     -=   5        $&  ocupacion_centro_estudio_trabajo��5�     $��12q�5      #��[ 5      . $ 1Q�5     $
 
Ocupación��5     $	��230��5     �� 5     ->   5        $- 'profecion_oficio_centro_estudio_trabajo��5     $��12q�5     #��[ 5      . $ 1Q�5
     $
 Profesión u oficio��5     $	��230��5     5     �� 5     $��0q�6   $
��Bold"�5     $��Center=�5     -+Nombre y apellidos de la referencia en Cuba6f   �� 5     $��0q�6   $
��Bold"�5     $��Center=�5     rp(persona que puede ser contactada para verificar sus generales, añadir, de ser posible, el número telefónico)6�   �� 5     -?   5        $ nombre_referencia_cuba��5     $��12q�5     #��[ 5      . $ 1Q�5     $1
 +Nombre y apellidos de la referencia en Cuba��5     �� 5     -@   5        $ direccion_referencia_cuba��5     $��12q�5     #��[ 5      . $ 1Q�5     $8
 2Dirección de la Referencia (incluir la provincia)��5      �� 5"     $��0q�6   $
��Bold"�5#     $��Center=�5$     86Lugar de Residencia en Cuba (dos últimas direcciones)6p   � 5&      5'     �� 5(     $��2* �6+   �� 5)     �� 5*      5-     �� 5.     �� 5/     .+�52     �� -A   5        $ direccion1_referencia��52     $��12q�53     #��[ 54      . $ 1Q�56     $
 Dirección uno��57       58     -B   5        $'	 !fecha_direccion1_referencia_desde��58  !   $
 Desde��59  !   $��12q�5:  !   #��[ 5;  !   $ 1Q�5<  !    . $��1��5>  !     5?     -C   5        $-	 'fecha_direccion1_referencia_fecha_hasta��5?  !   $
 Hasta��5@  !   $��12q�5A  !   #��[ 5B  !   $ 1Q�5C  !    . $��2��5E  !   �� 5G     -D   5        $ direccion2_referencia��5G     $��12q�5H     #��[ 5I      . $ 1Q�5K     $
 Dirección dos��5L     $��1��5M       5N     -E   5        $'	 !fecha_direccion2_referencia_desde��5N  !   $
 Desde��5O  !   $��12q�5P  !   #��[ 5Q  !   $ 1Q�5R  !    . $��1��5T  !   $��1��5U  !     5V     -F   5        $-	 'fecha_direccion2_referencia_fecha_hasta��5V  !   $
 Hasta��5W  !   $��12q�5X  !   #��[ 5Y  !   $ 1Q�5Z  !    . $��2��5\  !   $��1��5]  !   5^     � 5`     .+�5a     �� -G   5        $! apellido_soltera_referencia��5a     $��12q�5b     #��[ 5c      . $ 1Q�5e     $
 Apellidos de soltera��5f     $	��165��5g     �� 5h     -H   5        $ otros_nombres_referencia��5h     $��12q�5i     #��[ 5j      . $ 1Q�5l     $
 Otros nombres��5m     $	��165��5n     �� 5o     -I   5        $" numero_residencia_referencia��5o     $��12q�5p     #��[ 5q      . $ 1Q�5s     $
 Número de residencia��5t     $	��165��5u     �� 5w     -J   5        $% pasaporte_extranjero_referencia��5w     $��12q�5x     #��[ 5y      . $ 1Q�5{     $
 Pasaporte extranjero��5|     $	��165��5}     5~     �� 5�     $��0q�6   $
��Bold"�5�     $��Center=�5�     LJPara la confección del Pasaporte el titular presentó y se comprobó con:6�   �� 5�     $��0q�6   $
��Bold"�5�     $��Center=�5�     Pasaporte vencido6L   � 5�     .+�5�     �� -K   5        $ numero_pasaporte_vencido��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Número��5�     $	��230��5�       5�     -L   5        $(	 "fecha_expedicion_pasaporte_vencido��5�  !   $ 
 Fecha de expedición Lugar��5�  !   $��12q�5�  !   #��[ 5�  !   $ 1Q�5�  !    . $	��230��5�  !   �� 5�     -M   5        $ lugar_pasaporte_vencido��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Lugar��5�     $	��230��5�     5�     �� 5�     $��0q�6   $
��Bold"�5�     $��Center=�5�     Certificación de Nacimiento6V   � 5�     .+�5�     �� -N   5        $! tomo_certificado_nacimiento��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $

 Tomo��5�     $	��230��5�     �� 5�     -O   5        $" folio_certificado_nacimiento��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Folio��5�     $	��230��5�     �� 5�     -P   5        $+ %registro_civil_certificado_nacimiento��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Registro Civil��5�     $	��230��5�     5�     �� 5�     $��0q�6   $
��Bold"�5�     $��Center=�5�     Inscripción Consular6O   � 5�     .+�5�     �� -Q   5        $! numero_inscripcion_consular��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Número��5�     $	��230��5�       5�     -R   5        $ 	 fecha_inscripcion_consular��5�  !   $
 De Fecha��5�  !   $��12q�5�  !   #��[ 5�  !   $ 1Q�5�  !    . $	��230��5�  !   �� 5�     -S   5        $" arancel_inscripcion_consular��5�     $��12q�5�     #��[ 5�      . $ 1Q�5�     $
 Arancel��5�     $	��230��5�     5�     �� 5�     -T   5        $ valoracion_consular��5�     $	��200��5�     $	��Top=�5�     $��12q�5�     $
 Valoración Consular��5�      �� AcceptsReturn . #��[ 5�      �� TextWrapping$
 Wrap=�5�     " �� VerticalScrollBarVisibility$
 Auto=�5�     {�5�     ��  �� Path$ 	IsChecked� �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5�     �� 5�     -U   5          MaterialDesignRaisedButton#��[ 5�     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�     $	��Top=�5�     $��12q�5�     $	��246��5�     $��46��5�     .��5�     � .+�5�       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�  2   $��20��5�  2   �� 5�     $��Center=�6$   $��7,0,0,0q�5�  $   	Adicionar6@   5�     5�     5�     5�     5�     5�     