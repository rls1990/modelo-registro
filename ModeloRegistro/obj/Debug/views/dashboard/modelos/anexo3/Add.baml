   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo3-ModeloRegistro.views.dashboard.modelos.anexo3  5      7    1ModeloRegistro.views.dashboard.modelos.anexo3.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo3     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 3��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5    
   $��1��6   .+�5!      �� -   5         ! MaterialDesignFlatLightButton#��[ 5!       � ToolTip$# MaterialDesignFlatLightButton��5"      $
��Left=�5#      $��Center=�5$      .��5&      � .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5)   .   $��20��5*   .   $��Center=�5+   .   �� 5,      ���	#FF404E67$��16(�5-       $��Center=�5.       $��3,1,0,0q�5/       Atrás68   50      51      52      �� 53   
   $��2��6   .��54      ��  �� Orientation$ Vertical=�6   $
��Auto=�55      .+�56      �� $��0q�6   $��Center=�57      $
��Bold"�58      MISION CONSULAR6?   � 59       � ColumnDefinitions 5:      �� 5;      �� 5<      .+�5>      �� -   5         ��Name$ ciudad��5>      $��12q�5?       ! MaterialDesignOutlinedTextBox#��[ 5@      .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . )  #MaterialDesignThemes.Wpf.HintAssist
   FloatingScale$
 1Q�5B         Hint$ Ciudad��5C      �� 5D      -   5        $
 pais��5D      $��12q�5E      $��1��5F      #��[ 5G      	 . $
 1Q�5I      $
 Pais��5J      5K      �� 5M      $��0q�6   $��Center=�5N      $
��Bold"�5O      +)SOLICITUD DE CERTIFICACIÓN DE NACIMIENTO6X   �� 5Q      -   5        $ nombre_apellido��5Q      $��12q�5R      #��[ 5S      	 . $
 1Q�5U      $ Nombre y Apellidos:��5V      (  "System.Windows.Controls.DatePicker  5X      -   5          Name$ fecha_nacimiento��5X      $ Fecha de Nacimiento��5Y      $��12q�5Z       $  MaterialDesignOutlinedDatePicker#��[ 5[      $
 1Q�5\      	 . 5]      �� 5_      $��0q�6   $��Center=�5`      $
��Bold"�5a      Lugar de Nacimiento:6D   � 5c       5d      �� 5e      �� 5f      .+�5h      �� -   5        $ 	municipio��5h      $��12q�5i      #��[ 5j      	 . $
 1Q�5l      $ 	Municipio��5m      �� 5n      -   5        $ 	provincia��5n      $��12q�5o      $��1��5p      #��[ 5q      	 . $
 1Q�5s      $ 	Provincia��5t      5v      �� 5x      $��0q�6   $��Center=�5y      $
��Bold"�5z      %#Registro Civil donde se inscribió:6R   � 5|       5}      �� 5~      �� 5      �� 5�      .+�5�      �� -   5        $ registro��5�      $��12q�5�      #��[ 5�      	 . $
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
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5      5     