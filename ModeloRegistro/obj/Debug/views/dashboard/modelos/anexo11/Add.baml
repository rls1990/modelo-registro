   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo11.ModeloRegistro.views.dashboard.modelos.anexo11  5      8    2ModeloRegistro.views.dashboard.modelos.anexo11.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo11     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 11��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
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
��Bold"�5M      53SOLICITUD DE CERTIFICADO DEL REGISTRO DE EXTRANJERO6c   � 5N       5O      �� 5P      �� 5Q      .+�5S      �� -   5        $ solicito_certificado��5S      $��12q�5T      #��[ 5U      	 . $
 1Q�5W      $  Solicito Certificación de��5X      �� 5Y      -   5        $ de_mi��5Y      $��12q�5Z      $��1��5[      #��[ 5\      	 . $
 1Q�5^      $ de mi��5_      5`      �� 5a      -   5        $ nombre_apellidos��5a      $��12q�5b      #��[ 5c      	 . $
 1Q�5e      $ Nombres y Apellidos��5f      (  "System.Windows.Controls.DatePicker  5g      -   5          Name$ fecha_nacimiento��5g      $ Fecha de Nacimiento��5h      $��12q�5i       $  MaterialDesignOutlinedDatePicker#��[ 5j      $
 1Q�5k      	 . 5l      �� 5m      -   5        $ lugar_nacimiento��5m      $��12q�5n      #��[ 5o      	 . $
 1Q�5q      $ Lugar de Nacimiento��5r      �� 5s      -	   5        $ nombre_padres��5s      $��12q�5t      #��[ 5u      	 . $
 1Q�5w      $ Nombre de los Padres��5x      �� 5y      -
   5        $ lugar_vivio_cuba��5y      $��12q�5z      #��[ 5{      	 . $
 1Q�5}      $' !Lugar donde vive o vivió en Cuba��5~        5      -   5        $ fecha_fallecimiento��5      $ Fecha de fallecimiento��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5        $ otros_datos_interes��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Otros datos de interés��5�      �� 5�      -   5        $" nombre_apellidos_solicitante��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $( "Nombre y Apellidos del Solicitante��5�      �� 5�      -   5        $ doc_identidad��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Doc. Identidad��5�      �� 5�      -   5        $ 	pasaporte��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Pasaporte��5�      �� 5�      -   5        $ 	direccion��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 
Dirección��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ telefono��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ 	Teléfono��5�      �� 5�      -   5        $ email��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ e-mail��5�      $��1��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minrex��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      $��1��5�      5�        5�      -   5        $ fecha_de_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5�      5�      