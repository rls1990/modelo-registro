   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo3-ModeloRegistro.views.dashboard.modelos.anexo3  5      7    1ModeloRegistro.views.dashboard.modelos.anexo3.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo3     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 3��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   $
��Auto=�54      .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      MISION CONSULAR6?   � 58       � ColumnDefinitions 59      �� 5:      �� 5;      .+�5=      �� -   5         ��Name$ ciudad��5=      $��12q�5>       ! MaterialDesignOutlinedTextBox#��[ 5?      .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . )  #MaterialDesignThemes.Wpf.HintAssist
   FloatingScale$
 1Q�5A         Hint$ Ciudad��5B      �� 5C      -   5        $
 pais��5C      $��12q�5D      $��1��5E      #��[ 5F      	 . $
 1Q�5H      $
 Pais��5I      5J      �� 5L      $��0q�6   $��Center=�5M      $
��Bold"�5N      +)SOLICITUD DE CERTIFICACIÓN DE NACIMIENTO6X   �� 5P      -   5        $ nombre_apellido��5P      $��12q�5Q      #��[ 5R      	 . $
 1Q�5T      $ Nombre y Apellidos:��5U      (  "System.Windows.Controls.DatePicker  5W      -   5          Name$ fecha_nacimiento��5W      $ Fecha de Nacimiento��5X      $��12q�5Y       $  MaterialDesignOutlinedDatePicker#��[ 5Z      $
 1Q�5[      	 . 5\      �� 5^      $��0q�6   $��Center=�5_      $
��Bold"�5`      Lugar de Nacimiento:6D   � 5b       5c      �� 5d      �� 5e      .+�5g      �� -   5        $ 	municipio��5g      $��12q�5h      #��[ 5i      	 . $
 1Q�5k      $ 	Municipio��5l      �� 5m      -   5        $ 	provincia��5m      $��12q�5n      $��1��5o      #��[ 5p      	 . $
 1Q�5r      $ 	Provincia��5s      5u      �� 5w      $��0q�6   $��Center=�5x      $
��Bold"�5y      %#Registro Civil donde se inscribió:6R   � 5{       5|      �� 5}      �� 5~      �� 5      .+�5�      �� -   5        $ registro��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Registro��5�      �� 5�      -	   5        $ municipio_registro��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ Municipio del Registro��5�      �� 5�      -
   5        $ provincia_registro��5�      $��12q�5�      $��2��5�      #��[ 5�      	 . $
 1Q�5�      $ Provincia del Registro��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $
 tomo��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $
 Tomo��5�      �� 5�      -   5        $ folio��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ Folio��5�      5�        5�      -   5        $ fecha_asiento��5�      $< 6Fecha del asiento (si es distinta a la del nacimiento)��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ nombre_padre��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Nombre del Padre��5�      �� 5�      -   5        $ nombre_madre��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ Nombre del Madre��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minred��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��1��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      5�        5�      -   5        $ fecha_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      