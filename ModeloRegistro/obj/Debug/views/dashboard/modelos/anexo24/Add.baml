   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo24.ModeloRegistro.views.dashboard.modelos.anexo24  5      8    2ModeloRegistro.views.dashboard.modelos.anexo24.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo24     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 24��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      86SOLICITUD DE PODER ESPECIAL PARA COMPRA VENTA DE AUTOS6f   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ fecha_solicitud��58      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de Solicitud��59      $��12q�5:       $  MaterialDesignOutlinedDatePicker#��[ 5;      	   FloatingScale$	 1Q�5<      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5=      �� 5>      $��0q�6   $��Center=�5?      $
��Bold"�5@      DATOS DEL PODERDANTE:6E   �� 5A      -   5         ��Name$ nombre��5A      $��12q�5B       ! MaterialDesignOutlinedTextBox#��[ 5C      
 . $	 1Q�5E      $ Nombre y apellidos��5F      �� 5G      -   5        $  lugar_nacimineto_municipio��5G      $��12q�5H      #��[ 5I      
 . $	 1Q�5K      $$ Lugar de Nacimiento; Municipio��5L      �� 5M      -   5        $  lugar_nacimineto_provincia��5M      $��12q�5N      #��[ 5O      
 . $	 1Q�5Q      $$ Lugar de Nacimiento; Provincia��5R        5S      -   5        $ fecha_nacimineto��5S      $ Fecha de Nacimiento��5T      $��12q�5U      #��[ 5V      $	 1Q�5W      
 . 5X      �� 5Y      -   5        $ estado_civil��5Y      $ Estado Civil��5Z      $��12q�5[      #��[ 5\      $	 1Q�5]      
 . 5^      �� 5_      -   5        $ 
ciudadania��5_      $ Ciudadanía:��5`      $��12q�5a      #��[ 5b      $	 1Q�5c      
 . 5d      �� 5e      -	   5        $ 	ocupacion��5e      $ 
Ocupación��5f      $��12q�5g      #��[ 5h      $	 1Q�5i      
 . 5j      �� 5k      -
   5        $ 	direccion��5k      $ Dirección:��5l      $��12q�5m      #��[ 5n      $	 1Q�5o      
 . 5p      �� 5q      -   5        $ carnet_pasaporte��5q      $1 +Número de identidad permanente o pasaporte��5r      $��12q�5s      #��[ 5t      $	 1Q�5u      
 . 5v      �� 5w      -   5        $ nombre_apellido_padres��5w      $' !Nombres y apellidos de los padres��5x      $��12q�5y      #��[ 5z      $	 1Q�5{      
 . 5|      �� 5}      -   5        $ condicion_migratoria��5}      $L FCONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5~      $��12q�5      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ correo��5�      $% DIRECCION DE CORREO ELECTRONICO��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ celular��5�      $ NUMERO DE CELULAR��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL APODERADO:6D   �� 5�      -   5        $ nombre_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Nombre y apellidos��5�      �� 5�      -   5        $* $lugar_nacimineto_municipio_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Municipio��5�      �� 5�      -   5        $* $lugar_nacimineto_provincia_apoderado��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $$ Lugar de Nacimiento; Provincia��5�        5�      -   5        $  fecha_nacimineto_apoderado��5�      $ Fecha de Nacimiento��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ estado_civil_apoderado��5�      $ Estado Civil��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ ciudadania_apoderado��5�      $ Ciudadanía:��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ ocupacion_apoderado��5�      $ 
Ocupación��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ direccion_apoderado��5�      $ Dirección:��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $  carnet_pasaporte_apoderado��5�      $1 +Número de identidad permanente o pasaporte��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ nombre_padres_apoderado��5�      $' !Nombres y apellidos de los padres��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $$ condicion_migratoria_apoderado��5�      $L FCONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL VEHÍCULO:6C   �� 5�      -   5        $ marca��5�      $ Marca��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ modelo��5�      $ Modelo��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $
 anno��5�      $ Del año��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ color��5�      $ Color��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $ 	nro_motor��5�      $ Número de Motor��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -    5        $ 
nro_chasis��5�      $ Número de Chasis��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5      �� 5     -!   5        $ 	matricula��5     $ 
Matrícula��5     $��12q�5     #��[ 5     $	 1Q�5     
 . 5     �� 5     -"   5          MaterialDesignRaisedButton#��[ 5     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5	     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5     $	��Top=�5     $��12q�5     $	��246��5     $��46��5     .��5     � .+�5       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5  2   $��20��5  2   �� 5     $��Center=�6$   $��7,0,0,0q�5  $   	Adicionar6@   5     5     5     5     5     5     