   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo9-ModeloRegistro.views.dashboard.modelos.anexo9  5      7    1ModeloRegistro.views.dashboard.modelos.anexo9.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo9     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 9��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
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
��Bold"�5M      (&SOLICITUD DE CERTIFICACION DE SOLTERIA6V   �� 5N      -   5        $ encargado_registro_civil��5N      $��12q�5O      #��[ 5P      	 . $
 1Q�5R      $% Encargado del Registro Civil de��5S      � 5T       5U      �� 5V      �� 5W      .+�5Y      �� -   5        $ municipio_encargado��5Y      $��12q�5Z      #��[ 5[      	 . $
 1Q�5]      $ 	Municipio��5^      �� 5_      -   5        $ provincia_encargado��5_      $��12q�5`      $��1��5a      #��[ 5b      	 . $
 1Q�5d      $ 	Provincia��5e      5f      �� 5h      $��0q�6   $��Center=�5i      $
��Bold"�5j      =;Por medio de la presente solicito CERTIFICACION DE SOLTERIA6k   � 5k      $��Center=�6   .+�5l      �� -   5        $ nombre��5l      $��12q�5m      #��[ 5n      	 . $
 1Q�5p      $ a nombre de��5q      (  "System.Windows.Controls.DatePicker  5r      -   5          Name$ fecha_solicitud��5r   !   $ Fecha de Solicitud��5s   !   $��12q�5t   !    $  MaterialDesignOutlinedDatePicker#��[ 5u   !   $
 1Q�5v   !   	 . 5w   !   �� 5x      -	   5        $ tomo_certificado��5x      $��12q�5y      #��[ 5z      	 . $
 1Q�5|      $
 Tomo��5}      �� 5~      -
   5        $ folio_certificado��5~      $��12q�5      #��[ 5�      	 . $
 1Q�5�      $ Folio��5�        5�      -   5        $ fecha_nacimiento��5�   !   $ nacido el día��5�   !   $��12q�5�   !   #��[ 5�   !   $
 1Q�5�   !   	 . 5�   !   �� 5�      -   5        $ municipio_persona��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Municipio��5�      �� 5�      -   5        $ provincia_persona��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Provincia��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      
Hijo de:68   � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ padre��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Padre��5�      �� 5�      -   5        $ madre��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ Madre��5�      5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      GELa misma es para surtir efectos legales fuera del territorio Nacional6u   � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minrex��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      $��1��5�      5�        5�      -   5        $ fecha_de_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      