   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo28.ModeloRegistro.views.dashboard.modelos.anexo28  5      8    2ModeloRegistro.views.dashboard.modelos.anexo28.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo28     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 28��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      <:SOLICITUD DE PODER ESPECIAL PARA SACAR CARGA DE CONTENEDOR6j   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de Solicitud��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5=      $��0q�6   $��Center=�5>      $
��Bold"�5?      DATOS DEL PODERDANTE:6E   �� 5@      -   5         ��Name$ nombre_poderante��5@      $��12q�5A       ! MaterialDesignOutlinedTextBox#��[ 5B      
 . $	 1Q�5D      $ Nombre y apellidos��5E      �� 5F      -   5        $ sexo_poderante��5F      $��12q�5G      #��[ 5H      
 . $	 1Q�5J      $
 Sexo��5K      �� 5L      -   5        $* $lugar_nacimiento_municipio_poderante��5L      $��12q�5M      #��[ 5N      
 . $	 1Q�5P      $$ Lugar de Nacimiento; Municipio��5Q      �� 5R      -   5        $* $lugar_nacimiento_provincia_poderante��5R      $��12q�5S      #��[ 5T      
 . $	 1Q�5V      $$ Lugar de Nacimiento; Provincia��5W        5X      -   5        $  fecha_nacimineto_poderante��5X      $ Fecha de Nacimiento��5Y      $��12q�5Z      #��[ 5[      $	 1Q�5\      
 . 5]      �� 5^      -   5        $ estado_civil_poderante��5^      $��12q�5_      #��[ 5`      
 . $	 1Q�5b      $ Estado Civil��5c      �� 5d      -	   5        $ ciudadania_poderante��5d      $��12q�5e      #��[ 5f      
 . $	 1Q�5h      $ Ciudadanía��5i      �� 5j      -
   5        $ ocupacion_poderante��5j      $��12q�5k      #��[ 5l      
 . $	 1Q�5n      $ 
Ocupación��5o      �� 5p      -   5        $$ direccion_particular_poderante��5p      $��12q�5q      #��[ 5r      
 . $	 1Q�5t      $ Dirección Particular��5u      �� 5v      -   5        $ carne_pasaporte_poderante��5v      $��12q�5w      #��[ 5x      
 . $	 1Q�5z      $1 +Número de identidad permanente o pasaporte��5{      �� 5|      -   5        $$ condicion_migratoria_poderante��5|      $��12q�5}      #��[ 5~      
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
 . $	 1Q�5�      $Z TSi es cubano: CONDICIÓN MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5�      �� 5�      -   5        $ despacho_equipaje��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $A ;Despacho de equipaje no acompañado enviado a Cuba mediante��5�      �� 5�      -   5        $ numero_contenedor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ en el contenedor número��5�      �� 5�      -   5        $ bl��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ y el BL��5�      �� 5�      -   5        $ total��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ consignando un total de��5�      �� 5�      -   5        $ 
numeracion��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ con la numeración��5�      �� 5�      -    5        $ total_kg��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $&  siendo un total de kilogramos de��5�      �� 5�      -!   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5     $	��Top=�5     $��12q�5     $	��246��5     $��46��5     .��5
     � .+�5       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5  2   $��20��5  2   �� 5     $��Center=�6$   $��7,0,0,0q�5  $   	Adicionar6@   5     5     5     5     5     5     