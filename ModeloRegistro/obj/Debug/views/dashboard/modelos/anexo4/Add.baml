   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo4-ModeloRegistro.views.dashboard.modelos.anexo4  5      7    1ModeloRegistro.views.dashboard.modelos.anexo4.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo4     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 4��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   .+�55      �� $��0q�6   $��Center=�56      $
��Bold"�57      MISION CONSULAR6?   � 58       � ColumnDefinitions 59      �� 5:      �� 5;      .+�5=      �� -   5         ��Name$ ciudad��5=      $��12q�5>       ! MaterialDesignOutlinedTextBox#��[ 5?      .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . )  #MaterialDesignThemes.Wpf.HintAssist
   FloatingScale$
 1Q�5A         Hint$ Ciudad��5B      �� 5C      -   5        $
 pais��5C      $��12q�5D      $��1��5E      #��[ 5F      	 . $
 1Q�5H      $
 Pais��5I      5J      �� 5L      $��0q�6   $��Center=�5M      $
��Bold"�5N      #!SOLICITUD DE ANTECEDENTES PENALES6Q   � 5P       5Q      �� 5R      �� 5S      .+�5U      �� -   5        $ f_name��5U      $��12q�5V      #��[ 5W      	 . $
 1Q�5Y      $ 
1er Nombre��5Z      �� 5[      -   5        $ s_name��5[      $��12q�5\      $��1��5]      #��[ 5^      	 . $
 1Q�5`      $ 
2do Nombre��5a      5b      � 5d       5e      �� 5f      �� 5g      .+�5i      �� -   5        $ 
f_apellido��5i      $��12q�5j      #��[ 5k      	 . $
 1Q�5m      $ 1er Apellido��5n      �� 5o      -   5        $ 
s_apellido��5o      $��12q�5p      $��1��5q      #��[ 5r      	 . $
 1Q�5t      $ 2do Apellido��5u      5v      �� 5x      -   5        $ lugar_nacimiento��5x      $��12q�5y      #��[ 5z      	 . $
 1Q�5|      $ Lugar de Nacimiento��5}      � 5       5�      �� 5�      �� 5�      .+�5�      �� $ Vertical=�6!   .+�5�      �� -	   5        $ 
ciudadania��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Ciudadanía��5�   "   �� 5�      -
   5        $ nacionalidad��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Nacionalidad��5�   "   �� 5�      -   5        $ estado_civil��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Estado Civil��5�   "   5�      �� 5�      $ Vertical=�6!   $��1��68   .+�5�      (  "System.Windows.Controls.DatePicker  -   5          Name$ fecha_nacimiento��5�   %   $ Fecha de Nacimiento��5�   %   $��12q�5�   %    $  MaterialDesignOutlinedDatePicker#��[ 5�   %   $
 1Q�5�   %   	 . 5�   %   �� 5�      -   5         ��Name$
 sexo��5�   #   $
 Sexo��5�   #    " MaterialDesignOutlinedComboBox#��[ 5�   #   $
 1Q�5�   #   	 . $��12q�5�   #   .@�5�      �� $��	Masculino��6+   �� 5�      $��Femenino��6+   5�      �� 5�      -   5        $ 
color_piel��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Color de Piel��5�   "   5�      5�      �� 5�      -   5        $  profecion_oficio_ocupacion��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $% Profesión, Oficio u Ocupación��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ nombre_padre��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Nombre del Padre��5�      �� 5�      -   5        $ nombre_madre��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ Nombre del Madre��5�      5�      �� 5�      -   5        $ carnet_identidad��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $! Número Carné de Identidad��5�      �� 5�      -   5        $ 	pasaporte��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ No. Pasaporte��5�      �� 5�      $��0q�6   $��Center=�5�      $
��Bold"�5�      +)Última Dirección de residencia en Cuba:6W   �� 5�      $
��Auto=�6   $	��780��6D   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� -   5        $ calle��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Calle��5�   "   �� 5�      -   5        $ numero��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ Número��5�   "   �� 5�      -   5        $ entre��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ entre��5�   "   �� 5�      -   5        $ y��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5�   "   $ y��5�   "   �� 5�      -   5        $ barrio��5�   "   $��12q�5�   "   #��[ 5�   "   	 . $
 1Q�5  "   $ Barrio��5  "   �� 5     -   5        $ 	municipio��5  "   $��12q�5  "   #��[ 5  "   	 . $
 1Q�5  "   $ 	Municipio��5	  "   �� 5     -   5        $ 	provincia��5  "   $��12q�5  "   #��[ 5  "   	 . $
 1Q�5  "   $ 	Provincia��5  "   5     5     � 5      5     �� 5     �� 5     .+�5     �� -   5        $ legalizacion_minred��5     $��12q�5     #��[ 5     	 . $
 1Q�5     $ Legalización en MINREX��5     �� 5      -   5        $ legalizacion_embajada��5      $��1��5!     $��12q�5"     #��[ 5#     	 . $
 1Q�5%     $" Legalización en Embajada de��5&     5'       5)     -   5        $ fecha_solicitud��5)     $ Fecha de la solicitud��5*     $��12q�5+     #��[ 5,     $
 1Q�5-     	 . 5.     �� 50     -   5          MaterialDesignRaisedButton#��[ 50     .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�51     ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�55     $	��Top=�56     $��12q�57     $	��246��58     $��46��59     .��5;     � .+�5<       $% CheckboxMarkedCirclePlusOutline=�62   $��20��5=  2   $��20��5>  2   �� 5?     $��Center=�6$   $��7,0,0,0q�5@  $   	Adicionar6@   5A     5B     5D     5E     5F     5G     