   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo12.ModeloRegistro.views.dashboard.modelos.anexo12  5      8    2ModeloRegistro.views.dashboard.modelos.anexo12.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo12     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 12��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      MISION CONSULAR6?   � 57       � ColumnDefinitions 58      �� 59      �� 5:      .+�5<      �� -   5         ��Name$ ciudad��5<      $��12q�5=       ! MaterialDesignOutlinedTextBox#��[ 5>      .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . )  #MaterialDesignThemes.Wpf.HintAssist
   FloatingScale$
 1Q�5@         Hint$ Ciudad��5A      �� 5B      -   5        $
 pais��5B      $��12q�5C      $��1��5D      #��[ 5E      	 . $
 1Q�5G      $
 Pais��5H      5I      �� 5K      $��0q�6   $��Center=�5L      $
��Bold"�5M      @>SOLICITUD DE CERTIFICADO DE CAPACIDAD LEGAL PARA EL MATRIMONIO6n   �� 5O      $��0q�6   $��Center=�5P      /-DATOS DE LA PERSONA QUE CONTRAERA MATRIMONIO:6h   �� 5R      -   5        $ nombre_apellidos��5R      $��12q�5S      #��[ 5T      	 . $
 1Q�5V      $ Ciudad��5W      �� 5X      -   5        $ 	ciudadano��5X      $��12q�5Y      #��[ 5Z      	 . $
 1Q�5\      $? 9Ciudadano(a) cubano(a), mayor de edad, de estado conyugal��5]      �� 5_      -   5        $ carnet_identidad��5_      $��12q�5`      #��[ 5a      	 . $
 1Q�5c      $% Número del Carné de Identidad��5d      (  "System.Windows.Controls.DatePicker  5f      -   5          Name$ fecha_nacimiento��5f      $ Fecha de nacimiento��5g      $��12q�5h       $  MaterialDesignOutlinedDatePicker#��[ 5i      $
 1Q�5j      	 . 5k      �� 5m      -   5        $  provincia_lugar_nacimineto��5m      $��12q�5n      #��[ 5o      	 . $
 1Q�5q      $' !Procincia del lugar de nacimiento��5r      �� 5s      -	   5        $  municipio_lugar_nacimineto��5s      $��12q�5t      #��[ 5u      	 . $
 1Q�5w      $' !Municipio del lugar de nacimiento��5x      �� 5y      -
   5        $ provincia_registro_civil��5y      $��12q�5z      #��[ 5{      	 . $
 1Q�5}      $" Provincia del registro civil��5~      �� 5      -   5        $ municipio_registro_civil��5      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Municipio del registro civil��5�      �� 5�      -   5        $ 	vecino_de��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Vecino de��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      31SI EL O LA SOLICITANTE ES UN (UNA) APODERADO (A):6a   �� 5�      -   5        $ nombre_apellido_apoderado��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $2 ,Nombres y apellidos del (de la) apoderado(a)��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      ?=Manifiesta, bajo su responsabilidad la subsistencia del poder6m   � 5�      $��Center=�6   $��12q�5�      .+�5�      �� -   5         ��Name$ si��5�      $	��Sí��5�      �� 5�      -   5        $ no��5�      $��No��5�      5�      �� 5�      $��12q�6   $��Center=�5�      $
��Bold"�5�      DATOS DEL PODER ESPECIAL6H   � 5�      $��Center=�6   .+�5�      �� -   5        $ numero��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Número��5�        5�      -   5        $ fecha_poder_especial��5�   !   $ Fecha��5�   !   $��12q�5�   !   #��[ 5�   !   $
 1Q�5�   !   	 . 5�   !   �� 5�      -   5        $ nombre_apellido_notario��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $1 +Nombres y apellidos del notario autorizante��5�      �� 5�      -   5        $ competencia��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Competencia��5�      �� 5�      -   5        $
 sede��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $
 Sede��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minrex��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      $��1��5�      5�        5�      -   5        $ fecha_de_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      