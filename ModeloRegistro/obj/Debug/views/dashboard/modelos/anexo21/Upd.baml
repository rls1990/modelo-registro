   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo21.ModeloRegistro.views.dashboard.modelos.anexo21  5      8    2ModeloRegistro.views.dashboard.modelos.anexo21.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo21     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 21��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      QOAUTORIZACIÓN PARA OBTENCIÓN DE PASAPORTE DE MENOR DE EDAD Y VIAJE AL EXTERIOR6}   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de la solicitud��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5>      $��0q�6   $��Center=�5?      $
��Bold"�5@      DATOS DEL SOLICITANTE:6F   �� 5A      -   5         ��Name$ nombre_padre��5A      $��12q�5B       ! MaterialDesignOutlinedTextBox#��[ 5C      
 . $	 1Q�5E      $/ )NOMBRE Y APELLIDOS DEL PADRE QUE SOLICITA��5F      �� 5G      -   5        $ ciudadania_padre��5G      $��12q�5H      #��[ 5I      
 . $	 1Q�5K      $ CIUDADANÍA��5L      �� 5M      -   5        $ estado_civil_padre��5M      $��12q�5N      #��[ 5O      
 . $	 1Q�5Q      $ ESTADO CIVIL��5R      �� 5S      -   5        $  minicipio_nacimineto_padre��5S      $��12q�5T      #��[ 5U      
 . $	 1Q�5W      $ MUNICIPO DE NACIMIENTO��5X      �� 5Y      -   5        $  provincia_nacimineto_padre��5Y      $��12q�5Z      #��[ 5[      
 . $	 1Q�5]      $ PROVINCIA DE NACIMIENTO��5^        5_      -   5        $ fecha_nacimiento_padre��5_      $ FECHA DE NACIMIENTO��5`      $��12q�5a      #��[ 5b      $	 1Q�5c      
 . 5d      �� 5e      -	   5        $ profecion_padre��5e      $��12q�5f      #��[ 5g      
 . $	 1Q�5i      $ 
PROFESIÓN��5j      �� 5k      -
   5        $ carnet_pasaporte_padre��5k      $��12q�5l      #��[ 5m      
 . $	 1Q�5o      $8 2NÚMERO DE IDENTIDAD PERMANENTE O PASAPORTE CUBANO��5p      �� 5q      -   5        $  categoria_migratoria_padre��5q      $��12q�5r      #��[ 5s      
 . $	 1Q�5u      $N HCATEGORÍA MIGRATORIA: (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO):��5v      �� 5w      -   5        $ direccion_eu_padre��5w      $��12q�5x      #��[ 5y      
 . $	 1Q�5{      $&  DIRECCIÓN EN LOS ESTADOS UNIDOS��5|      �� 5}      -   5        $ correo��5}      $��12q�5~      #��[ 5      
 . $	 1Q�5�      $% DIRECCION DE CORREO ELECTRONICO��5�      �� 5�      -   5        $ celular��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ NUMERO DE CELULAR��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      Datos Menor6;   �� 5�      -   5        $ nombre_menor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $" NOMBRE Y APELLIDOS DEL MENOR��5�      �� 5�      -   5        $  municipio_nacimiento_menor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ MUNICIPIO DE NACIMIENTO��5�      �� 5�      -   5        $  provincia_nacimiento_menor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ PROVINCIA DE NACIMIENTO��5�        5�      -   5        $ fecha_nacimiento_menor��5�      $ FECHA DE NACIMIENTO��5�      $��12q�5�      #��[ 5�      $	 1Q�5�      
 . 5�      �� 5�      -   5        $&  registro_estado_nacimiento_menor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $D >REGISTRO DEL ESTADO CIVIL DONDE CONSTA INSCRIPTO SU NACIMIENTO��5�      �� 5�      -   5        $
 tomo��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $
 Tomo��5�      �� 5�      -   5        $ folio��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $ Folio��5�      �� 5�      -   5        $ tarjeta_menor��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $" NÚMERO DE TARJETA DEL MENOR��5�      �� 5�      -   5        $ direccion_menor_cuba��5�      $��12q�5�      #��[ 5�      
 . $	 1Q�5�      $" DIRECCIÓN DEL MENOR EN CUBA��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      