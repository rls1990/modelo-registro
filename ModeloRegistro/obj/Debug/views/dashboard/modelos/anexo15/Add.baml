   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo15.ModeloRegistro.views.dashboard.modelos.anexo15  5      8    2ModeloRegistro.views.dashboard.modelos.anexo15.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo15     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 15��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      +)SOLICITUD DE TRANSCRIPCIÓN DE DEFUNCIÓN6W   �� 58      $��12q�6   $��Center=�59      $
��Bold"�5:      DATOS DE LA PERSONA FALLECIDA6M   � 5;      .+�5<      �� -   5         ��Name$ nombre_fallecido��5<      $��12q�5=       ! MaterialDesignOutlinedTextBox#��[ 5>      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . )  #MaterialDesignThemes.Wpf.HintAssist	   FloatingScale$	 1Q�5@      
   Hint$
 Nombre(s) del Fallecido��5A      $	��165��5B      � 5C      $	��165��6    $��12q�5D       $��Center=�5E       $��Center=�5F       .+�5G      �� $��Center=�6$   $
��Bold"�5H   $   $��Center=�5I   $   Sexo:6F   �� 5J      -   5         ��Name$ m��5J   #   $��M��5K   #   �� 5L      -   5        $ f��5L   #   $��F��5M   #   5N      �� 5O      -   5        $ primer_apellido_fallecido��5O      $��12q�5P      #��[ 5Q       . $	 1Q�5S      $
 Primer Apellido��5T      $	��165��5U      �� 5V      -   5        $  segundo_apellido_fallecido��5V      $��12q�5W      #��[ 5X       . $	 1Q�5Z      $
 Segundo Apellido��5[      $	��165��5\      �� 5]      $��12q�6    $��Center=�5^       $��Center=�5_       $
��Bold"�5`       $	��165��5a       Fecha del Fallecimiento:6F   )  #MaterialDesignThemes.Wpf.TimePicker  5b      -   5          Name$ hora_fallecido��5b   0   $	��165��5c   0   $��12q�5d   0   $

 Hora��5e   0    $  MaterialDesignOutlinedTimePicker#��[ 5f   0    . $	 1Q�5h   0   (  "System.Windows.Controls.DatePicker  5j      -   5          Name$ fecha_fallecimineto��5j   !   $
 Fecha��5k   !   $��12q�5l   !    $  MaterialDesignOutlinedDatePicker#��[ 5m   !    . $	 1Q�5o   !   $	��165��5p   !   �� 5r      -	   5        $  lugar_nacimineto_fallecido��5r      $��12q�5s      #��[ 5t       . $	 1Q�5v      $
 Lugar de Nacimiento��5w      $	��165��5x      �� 5z      -
   5        $( "municipio_provincia_pais_fallecido��5z      $��12q�5{      #��[ 5|       . $	 1Q�5~      $!
 (Mncpio. Provincia, País )��5      $	��165��5�        5�      -   5        $ fecha_nacimiento��5�   !   $
 Fecha Nacimiento��5�   !   $��12q�5�   !   #��[ 5�   !    . $	 1Q�5�   !   $	��165��5�   !   �� 5�      -   5        $ pasaporte_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $ 
 Nro. Pasaporte o Identidad��5�      $	��165��5�      �� 5�      -   5        $ edad_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Edad al fallecer��5�      $	��165��5�      �� 5�      -   5        $ registro_civil_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $"
 Registro Civil de Nacimiento��5�      $	��165��5�      �� 5�      -   5        $ tomo_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $

 Tomo��5�      $	��165��5�      �� 5�      -   5        $ folio_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Folio��5�      $	��165��5�      �� 5�      -   5        $ estado_civil_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Estado Civil��5�      $	��165��5�      �� 5�      -   5        $ ocupacion_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 
Ocupación��5�      $	��165��5�      �� 5�      -   5        $ padre_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $%
 Nombre(s) y Apellidos del Padre��5�      $	��165��5�      �� 5�      -   5        $ madre_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $'
 !Nombre(s) y Apellidos de la Madre��5�      $	��165��5�      �� 5�      -   5        $ domicilio_fallecido��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $(
 "Domicilio permanente del fallecido��5�      $	��165��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DE LA DEFUNCIÓN6E   � 5�      $
��Left=�6   .+�5�      �� $��12q�6    $��Center=�5�       $
��Bold"�5�       Fecha:6:     5�      -   5        $ fecha_defuncion��5�   !   $
 Fecha de Defunción��5�   !   $��12q�5�   !   #��[ 5�   !   $	 1Q�5�   !    . $	��165��5�   !     5�      -   5        $ hora_defuncion��5�   0   $	��165��5�   0   $��12q�5�   0   $
 Hora de Defunción��5�   0   #��[ 5�   0   $	 1Q�5�   0    . 5�   0   5�      �� 5�      -   5        $ lugar_fallecimiento��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $j
 dLugar del Fallecimiento: (Hospital o Domicilio particular: en cualquier caso la Dirección completa)��5�       �� TextWrapping$
 Wrap=�5�      �� 5�      -   5        $  causa_muerte_fallecimiento��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $
 Causa de la Muerte��5�      $
 Wrap=�5�      �� 5�      -   5        $$ enfermedad_causa_fallecimiento��5�      $��12q�5�      #��[ 5�       . $	 1Q�5�      $H
 BEnfermedad o estado patológico que produjo la muerte directamente��5      $
 Wrap=�5     �� 5     -   5        $+ %nombre_medico_certifica_fallecimiento��5     $��12q�5     #��[ 5      . $	 1Q�5     $?
 9Nombre(s) y Apellidos del Médico que Certifica la Muerte��5     $
 Wrap=�5	     �� 5     -   5        $ lugar_cepultura��5     $��12q�5     #��[ 5      . $	 1Q�5     $!
 Lugar donde será sepultado��5     $
 Wrap=�5     �� 5     $��12q�6   $��Center=�5     $
��Bold"�5     GEDATOS DEL CERTIFICADO. DEL REGISTRO CIVIL O SU EQUIVALENTE EXTRANJERO6u   � 5     .+�5     �� -   5        $ registro_civil��5     $��12q�5     #��[ 5      . $	 1Q�5     $]
 WRegistro Civil de: (Poner el Nombre del Reg. Civil; Lugar, Municipio, Provincia, País)��5     $	��165��5     �� 5     -   5        $
 tomo��5     $��12q�5     #��[ 5       . $	 1Q�5"     $

 Tomo��5#     $	��165��5$     �� 5%     -   5        $ folio��5%     $��12q�5&     #��[ 5'      . $	 1Q�5)     $
 Folio��5*     $	��165��5+       5,     -    5        $ fecha_certificado��5,  !   $
 Fecha��5-  !   $��12q�5.  !   #��[ 5/  !   $	 1Q�50  !    . $	��165��52  !   53     �� 55     $��12q�6   $��Center=�56     $
��Bold"�57     *(DATOS DE QUIEN SOLICITA LA TRANSCRIPCION6X   � 58     .+�59     �� -!   5        $ nombre_apellido_solicita��59     $��12q�5:     #��[ 5;      . $	 1Q�5=     $
 Nombre(s) y Apellidos��5>     $	��165��5?     �� 5@     -"   5        $ nro_pasaporte_carnet��5@     $��12q�5A     #��[ 5B      . $	 1Q�5D     $$
 Nro. del Pasaporte o Identidad��5E     $	��165��5F     �� 5G     -#   5        $ parentesco_fallecido��5G     $��12q�5H     #��[ 5I      . $	 1Q�5K     $!
 Parentesco con el Fallecido��5L     $	��165��5M     �� 5N     -$   5        $ direccion_solicita��5N     $��12q�5O     #��[ 5P      . $	 1Q�5R     $a
 [Dirección : (Poner Calle, Nro., Entre Calle, Apto., Barrio, Municipio Ciudad, Prov. País)��5S     5U     �� 5W     -%   5        $* $nombre_apellido_funcionario_consular��5W     $��12q�5X     #��[ 5Y      . $	 1Q�5[     $:
 4Nombre y Apellidos, y Cargo del funcionario consular��5\     �� 5_     -&   5          MaterialDesignRaisedButton#��[ 5_     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5`     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5d     $	��Top=�5e     $��12q�5f     $	��246��5g     $��46��5h     .��5j     � .+�5k       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5l  2   $��20��5m  2   �� 5n     $��Center=�6$   $��7,0,0,0q�5o  $   	Adicionar6@   5p     5q     5s     5t     5w     5x     