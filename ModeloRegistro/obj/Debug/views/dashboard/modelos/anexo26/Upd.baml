   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo26.ModeloRegistro.views.dashboard.modelos.anexo26  5      8    2ModeloRegistro.views.dashboard.modelos.anexo26.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo26     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Upd��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 26��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      42SOLICITUD DE PODER ESPECIAL PARA DIVORCIO NOTARIAL6b   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ fecha_solicitud��58      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de Solicitud��59      $��12q�5:       $  MaterialDesignOutlinedDatePicker#��[ 5;      	   FloatingScale$	 1Q�5<      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5=      �� 5?      $��0q�6   $��Center=�5@      $
��Bold"�5A      DATOS DEL PODERDANTE:6E   �� 5B      -   5         ��Name$ nombre_poderante��5B      $��12q�5C       ! MaterialDesignOutlinedTextBox#��[ 5D      
 . $	 1Q�5F      $ Nombre y apellidos��5G      �� 5H      -   5        $ sexo_poderante��5H      $��12q�5I      #��[ 5J      
 . $	 1Q�5L      $
 Sexo��5M      �� 5N      -   5        $* $lugar_nacimiento_municipio_poderante��5N      $��12q�5O      #��[ 5P      
 . $	 1Q�5R      $$ Lugar de Nacimiento; Municipio��5S      �� 5T      -   5        $* $lugar_nacimiento_provincia_poderante��5T      $��12q�5U      #��[ 5V      
 . $	 1Q�5X      $$ Lugar de Nacimiento; Provincia��5Y        5Z      -   5        $  fecha_nacimineto_poderante��5Z      $ Fecha de Nacimiento��5[      $��12q�5\      #��[ 5]      $	 1Q�5^      
 . 5_      �� 5`      -   5        $ estado_civil_poderante��5`      $��12q�5a      #��[ 5b      
 . $	 1Q�5d      $ Estado Civil��5e      �� 5f      -	   5        $ ciudadania_poderante��5f      $��12q�5g      #��[ 5h      
 . $	 1Q�5j      $ Ciudadanía��5k      �� 5l      -
   5        $ ocupacion_poderante��5l      $��12q�5m      #��[ 5n      
 . $	 1Q�5p      $ 
Ocupación��5q      �� 5r      -   5        $$ direccion_particular_poderante��5r      $��12q�5s      #��[ 5t      
 . $	 1Q�5v      $ Dirección Particular��5w      �� 5x      -   5        $ carne_pasaporte_poderante��5x      $��12q�5y      #��[ 5z      
 . $	 1Q�5|      $1 +Número de identidad permanente o pasaporte��5}      �� 5~      -   5        $$ condicion_migratoria_poderante��5~      $��12q�5      #��[ 5�      
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
 . $	 1Q�5�      $ Estado Civil��5�      �� 5�      -!   5        $ ciudadania_contrayente��5�      $��12q�5�      #��[ 5      
 . $	 1Q�5     $ Ciudadanía��5     �� 5     -"   5        $ ocupacion_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $ 
Ocupación��5	     �� 5
     -#   5        $&  direccion_particular_contrayente��5
     $��12q�5     #��[ 5     
 . $	 1Q�5     $ Dirección Particular��5     �� 5     -$   5        $! carne_pasaporte_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $1 +Número de identidad permanente o pasaporte��5     �� 5     -%   5        $&  condicion_migratoria_contrayente��5     $��12q�5     #��[ 5     
 . $	 1Q�5     $Z TSi es cubano: CONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5       5     -&   5        $ fecha_celebracion��5     $* $Fecha de celebración del matrimonio��5     $��12q�5     #��[ 5      $	 1Q�5!     
 . 5"     �� 5$     $��0q�6   $��Center=�5%     $
��Bold"�5&     Datos de la inscripción6G   �� 5'     -'   5        $
 tomo��5'     $��12q�5(     #��[ 5)     
 . $	 1Q�5+     $
 Tomo��5,     �� 5-     -(   5        $ folio��5-     $��12q�5.     #��[ 5/     
 . $	 1Q�51     $ Folio��52     �� 53     -)   5        $ registro_civil_municipio��53     $��12q�54     #��[ 55     
 . $	 1Q�57     $, &Registro de Estado Civil del Municipio��58     �� 5:     $��0q�6   $��Center=�5;     $
��Bold"�5<     ESPECIFICAR SI TIENEN HIJOS:6L   �� 5=     -*   5        $ patria_potestad��5=     $��12q�5>     #��[ 5?     
 . $	 1Q�5A     $/ )A quien corresponderá la patria potestad��5B     �� 5C     -+   5        $ nombre_apellido_menor��5C     $��12q�5D     #��[ 5E     
 . $	 1Q�5G     $" Nombre y apellidos del menor��5H     �� 5I     -,   5        $ pension_alimenticia��5I     $��12q�5J     #��[ 5K     
 . $	 1Q�5M     $ Pensión alimenticia��5N     �� 5O     --   5        $ regimen_comunicacion��5O     $��12q�5P     #��[ 5Q     
 . $	 1Q�5S     $ Régimen de comunicación��5T     �� 5V     -.   5          MaterialDesignRaisedButton#��[ 5V     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5W     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5[     $	��Top=�5\     $��12q�5]     $	��246��5^     $��46��5_     .��5a     � .+�5b       $ CircleEditOutline=�62   $��20��5c  2   $��20��5d  2   �� 5e     $��Center=�6$   $��7,0,0,0q�5f  $   
Actualizar6A   5g     5h     5k     5l     5m     5n     