   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo7-ModeloRegistro.views.dashboard.modelos.anexo7  5      7    1ModeloRegistro.views.dashboard.modelos.anexo7.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo7     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 7��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
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
��Bold"�5M      '%SOLICITUD DE CERTIFICADO DE DEFUNCION6U   �� 5N      -   5        $ nombre_apellido��5N      $��12q�5O      #��[ 5P      	 . $
 1Q�5R      $ Nombre y Apellidos��5S      (  "System.Windows.Controls.DatePicker  5T      -   5          Name$ fecha_defuncion��5T      $ Fecha de Defunción��5U      $��12q�5V       $  MaterialDesignOutlinedDatePicker#��[ 5W      $
 1Q�5X      	 . 5Y      �� 5[      $��0q�6   $��Center=�5\      $
��Bold"�5]      Lugar del Fallecimiento6G   � 5^       5_      �� 5`      �� 5a      .+�5d      �� -   5        $ municipio_fallecimineto��5d      $��12q�5e      #��[ 5f      	 . $
 1Q�5h      $ 	Municipio��5i      �� 5j      -   5        $ provincia_fallecimineto��5j      $��12q�5k      #��[ 5l      	 . $
 1Q�5n      $ 	Provincia��5o      $��1��5p      5q      �� 5s      $��0q�6   $��Center=�5t      $
��Bold"�5u      QORegistro Civil donde se inscribió la defunción o, en su defecto, la funeraria6}   �� 5w      -   5        $ donde_fue_velado��5w      $��12q�5x      #��[ 5y      	 . $
 1Q�5{      $ Donde fue velado��5|      �� 5~      $��0q�6   $��Center=�5      $
��Bold"�5�      Registro o Funeraria6D   � 5�       5�      �� 5�      �� 5�      .+�5�      �� -	   5        $ municipio_funeraria��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Municipio��5�      �� 5�      -
   5        $ provincia_funeraria��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Provincia��5�      $��1��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $
 tomo��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $
 Tomo��5�      �� 5�      -   5        $ folio��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Folio��5�      $��1��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minrex��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      $��1��5�      5�        5�      -   5        $ fecha_de_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      