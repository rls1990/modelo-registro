   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo29.ModeloRegistro.views.dashboard.modelos.anexo29  5      8    2ModeloRegistro.views.dashboard.modelos.anexo29.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo29     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 29��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      $
��Wrap=�6.   �SOLICITUD DE PODER ESPECIAL PARA ESCRITURA DE AUTORIZACION PARA SUBSANAR ASIENTO DE INSCRIPCION EN EL REGISTRO DEL ESTADO CIVIL6�   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de Solicitud��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5=      $��0q�6   $��Center=�5>      $
��Bold"�5?      DATOS DEL PODERDANTE:6E   �� 5@      -   5         ��Name$ nombre��5@      $��12q�5A       ! MaterialDesignOutlinedTextBox#��[ 5B      
 . $	 1Q�5D      $ Nombre y apellidos��5E      �� 5F      -   5        $
 sexo��5F      $��12q�5G      #��[ 5H      
 . $	 1Q�5J      $
 Sexo��5K      �� 5L      -   5        $  lugar_nacimineto_municipio��5L      $��12q�5M      #��[ 5N      
 . $	 1Q�5P      $$ Lugar de Nacimiento; Municipio��5Q      �� 5R      -   5        $  lugar_nacimineto_provincia��5R      $��12q�5S      #��[ 5T      
 . $	 1Q�5V      $$ Lugar de Nacimiento; Provincia��5W        5X      -   5        $ fecha_nacimineto��5X      $ Fecha de Nacimiento��5Y      $��12q�5Z      #��[ 5[      $	 1Q�5\      
 . 5]      �� 5^      -   5        $ estado_civil��5^      $ Estado Civil��5_      $��12q�5`      #��[ 5a      $	 1Q�5b      
 . 5c      �� 5d      -	   5        $ 
ciudadania��5d      $ Ciudadanía:��5e      $��12q�5f      #��[ 5g      $	 1Q�5h      
 . 5i      �� 5j      -
   5        $ 	ocupacion��5j      $ 
Ocupación��5k      $��12q�5l      #��[ 5m      $	 1Q�5n      
 . 5o      �� 5p      -   5        $ 	direccion��5p      $ Dirección:��5q      $��12q�5r      #��[ 5s      $	 1Q�5t      
 . 5u      �� 5v      -   5        $ carnet_pasaporte��5v      $1 +Número de identidad permanente o pasaporte��5w      $��12q�5x      #��[ 5y      $	 1Q�5z      
 . 5{      �� 5|      -   5        $ condicion_migratoria��5|      $L FCONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5}      $��12q�5~      #��[ 5      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ correo��5�      $% DIRECCION DE CORREO ELECTRONICO��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ celular��5�      $ NUMERO DE CELULAR��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL APODERADO:6D   �� 5�      -   5        $ nombre_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Nombre y apellidos��5�      �� 5�      -   5        $ sexo_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Sexo Apoderado��5�      �� 5�      -   5        $* $lugar_nacimineto_municipio_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Municipio��5�      �� 5�      -   5        $* $lugar_nacimineto_provincia_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Provincia��5�        5�      -   5        $  fecha_nacimineto_apoderado��5�      $ Fecha de Nacimiento��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ estado_civil_apoderado��5�      $ Estado Civil��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ ciudadania_apoderado��5�      $ Ciudadanía:��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ ocupacion_apoderado��5�      $ 
Ocupación��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ direccion_apoderado��5�      $ Dirección:��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $  carnet_pasaporte_apoderado��5�      $1 +Número de identidad permanente o pasaporte��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $$ condicion_migratoria_apoderado��5�      $L FCONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      0.Datos de la inscripción que se va a subsanar:6]   �� 5�      -   5        $ nombre_menor��5�      $ Nombre del menor��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ 
natural_de��5�      $ 
Natural de��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�        5�      -   5        $ fecha_nacimineto_menor��5�      $ Fecha de nacimiento��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $
 edad��5�      $��12q�5�      $ Edad del niño��5�      #��[ 5�      
 . $	 1Q�5�      �� 5�      -   5        $
 tomo��5�      $��12q�5�      $ Tomo de la inscripción��5�      #��[ 5�      
 . $	 1Q�5�      �� 5�      -    5        $ folio��5�      $��12q�5�      $ Folio de la inscripción��5�      #��[ 5�      
 . $	 1Q�5�      �� 5�      -!   5        $ registro_estado_civil��5�      $��12q�5      $" Registro del Estado Civil de��5     #��[ 5     
 . $	 1Q�5     �� 5     -"   5        $ tipo_tramites��5     $��12q�5     $F @Especifique para qué tipo de trámite usted otorga dicho poder:��5     #��[ 5     
 . $	 1Q�5
      �� TextWrapping$
 Wrap=�6F   �� 5     -#   5          MaterialDesignRaisedButton#��[ 5     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5     $	��Top=�5     $��12q�5     $	��246��5     $��46��5     .��5     � .+�5       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5  2   $��20��5  2   �� 5     $��Center=�6$   $��7,0,0,0q�5  $   	Adicionar6@   5     5     5!     5"     5#     5$     