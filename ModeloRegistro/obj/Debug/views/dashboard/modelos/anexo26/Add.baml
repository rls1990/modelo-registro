   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo26.ModeloRegistro.views.dashboard.modelos.anexo26  5      8    2ModeloRegistro.views.dashboard.modelos.anexo26.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo26     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 26��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      42SOLICITUD DE PODER ESPECIAL PARA DIVORCIO NOTARIAL6b   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de Solicitud��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5>      $��0q�6   $��Center=�5?      $
��Bold"�5@      DATOS DEL PODERDANTE:6E   �� 5A      -   5         ��Name$ nombre_poderante��5A      $��12q�5B       ! MaterialDesignOutlinedTextBox#��[ 5C      
 . $	 1Q�5E      $ Nombre y apellidos��5F      �� 5G      -   5        $ sexo_poderante��5G      $��12q�5H      #��[ 5I      
 . $	 1Q�5K      $
 Sexo��5L      �� 5M      -   5        $* $lugar_nacimiento_municipio_poderante��5M      $��12q�5N      #��[ 5O      
 . $	 1Q�5Q      $$ Lugar de Nacimiento; Municipio��5R      �� 5S      -   5        $* $lugar_nacimiento_provincia_poderante��5S      $��12q�5T      #��[ 5U      
 . $	 1Q�5W      $$ Lugar de Nacimiento; Provincia��5X        5Y      -   5        $  fecha_nacimineto_poderante��5Y      $ Fecha de Nacimiento��5Z      $��12q�5[      #��[ 5\      $	 1Q�5]      
 . 5^      �� 5_      -   5        $ estado_civil_poderante��5_      $��12q�5`      #��[ 5a      
 . $	 1Q�5c      $ Estado Civil��5d      �� 5e      -	   5        $ ciudadania_poderante��5e      $��12q�5f      #��[ 5g      
 . $	 1Q�5i      $ Ciudadanía��5j      �� 5k      -
   5        $ ocupacion_poderante��5k      $��12q�5l      #��[ 5m      
 . $	 1Q�5o      $ 
Ocupación��5p      �� 5q      -   5        $$ direccion_particular_poderante��5q      $��12q�5r      #��[ 5s      
 . $	 1Q�5u      $ Dirección Particular��5v      �� 5w      -   5        $ carne_pasaporte_poderante��5w      $��12q�5x      #��[ 5y      
 . $	 1Q�5{      $1 +Número de identidad permanente o pasaporte��5|      �� 5}      -   5        $$ condicion_migratoria_poderante��5}      $��12q�5~      #��[ 5      
 . $	 1Q�5�      $Z TSi es cubano: CONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5�      �� 5�      -   5        $ correo_poderante��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $% DIRECCION DE CORREO ELECTRONICO��5�      �� 5�      -   5        $ celular_poderante��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ NUMERO DE CELULAR��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL APODERADO:6D   �� 5�      -   5        $ nombre_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Nombre y apellidos��5�      �� 5�      -   5        $ sexo_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $
 Sexo��5�      �� 5�      -   5        $* $lugar_nacimiento_municipio_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Municipio��5�      �� 5�      -   5        $* $lugar_nacimiento_provincia_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Provincia��5�        5�      -   5        $  fecha_nacimineto_apoderado��5�      $ Fecha de Nacimiento��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ estado_civil_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Estado Civil��5�      �� 5�      -   5        $ ciudadania_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Ciudadanía��5�      �� 5�      -   5        $ ocupacion_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ 
Ocupación��5�      �� 5�      -   5        $$ direccion_particular_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Dirección Particular��5�      �� 5�      -   5        $ carne_pasaporte_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $1 +Número de identidad permanente o pasaporte��5�      �� 5�      -   5        $$ condicion_migratoria_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $Z TSi es cubano: CONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL MATRIMONIO:6E   �� 5�      -   5        $ nombre_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $) #Nombres y apellidos del contrayente��5�      �� 5�      -   5        $ sexo_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $
 Sexo��5�      �� 5�      -   5        $, &lugar_nacimiento_municipio_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Municipio��5�      �� 5�      -   5        $, &lugar_nacimiento_provincia_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Provincia��5�        5�      -   5        $" fecha_nacimineto_contrayente��5�      $ Fecha de Nacimiento��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -    5        $ estado_civil_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Estado Civil��5�      �� 5�      -!   5        $ ciudadania_contrayente��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5     $ Ciudadanía��5     �� 5     -"   5        $ ocupacion_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ 
Ocupación��5     �� 5	     -#   5        $&  direccion_particular_contrayente��5	     $��12q�5
     #��[ 5     
 . $	 1Q�5     $ Dirección Particular��5     �� 5     -$   5        $! carne_pasaporte_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $1 +Número de identidad permanente o pasaporte��5     �� 5     -%   5        $&  condicion_migratoria_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $Z TSi es cubano: CONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5       5     -&   5        $ fecha_celebracion��5     $* $Fecha de celebración del matrimonio��5     $��12q�5     #��[ 5     $	 1Q�5      
 . 5!     �� 5#     $��0q�6   $��Center=�5$     $
��Bold"�5%     Datos de la inscripción6G   �� 5&     -'   5        $
 tomo��5&     $��12q�5'     #��[ 5(     
 . $	 1Q�5*     $
 Tomo��5+     �� 5,     -(   5        $ folio��5,     $��12q�5-     #��[ 5.     
 . $	 1Q�50     $ Folio��51     �� 52     -)   5        $ registro_civil_municipio��52     $��12q�53     #��[ 54     
 . $	 1Q�56     $, &Registro de Estado Civil del Municipio��57     �� 59     $��0q�6   $��Center=�5:     $
��Bold"�5;     ESPECIFICAR SI TIENEN HIJOS:6L   �� 5<     -*   5        $ patria_potestad��5<     $��12q�5=     #��[ 5>     
 . $	 1Q�5@     $/ )A quien corresponderá la patria potestad��5A     �� 5B     -+   5        $ nombre_apellido_menor��5B     $��12q�5C     #��[ 5D     
 . $	 1Q�5F     $" Nombre y apellidos del menor��5G     �� 5H     -,   5        $ pension_alimenticia��5H     $��12q�5I     #��[ 5J     
 . $	 1Q�5L     $ Pensión alimenticia��5M     �� 5N     --   5        $ regimen_comunicacion��5N     $��12q�5O     #��[ 5P     
 . $	 1Q�5R     $ Régimen de comunicación��5S     �� 5U     -.   5          MaterialDesignRaisedButton#��[ 5U     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5V     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5Z     $	��Top=�5[     $��12q�5\     $	��246��5]     $��46��5^     .��5`     � .+�5a       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5b  2   $��20��5c  2   �� 5d     $��Center=�6$   $��7,0,0,0q�5e  $   	Adicionar6@   5f     5g     5j     5k     5m     5n     