   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo6-ModeloRegistro.views.dashboard.modelos.anexo6  5      7    1ModeloRegistro.views.dashboard.modelos.anexo6.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo6     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$	  Add��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 6��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
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
��Bold"�5N      $"SOLICITUD DE SENTENCIA DE DIVORCIO6R   �� 5P      $��0q�6   $��Center=�5Q      )'Nombres y Apellidos de los Divorciados:6b   �� 5R      -   5        $ nombre_apellido_hombre��5R      $��12q�5S      #��[ 5T      	 . $
 1Q�5V      $ Nombre Esposo��5W      �� 5X      -   5        $ nombre_apellido_mujer��5X      $��12q�5Y      #��[ 5Z      	 . $
 1Q�5\      $ Nombre Mujer��5]      �� 5_      -   5        $ tribunal_dicto_sentencia��5_      $��12q�5`      #��[ 5a      	 . $
 1Q�5c      $# Tribunal que dictó Sentencia��5d      �� 5f      -   5        $  nombre_secretario_actuante��5f      $��12q�5g      #��[ 5h      	 . $
 1Q�5j      $$ Nombre del Secretario actuante��5k      (  "System.Windows.Controls.DatePicker  5m      -   5          Name$ fecha_dicto_sentencia��5m      $# Fecha en que dictó Sentencia��5n      $��12q�5o       $  MaterialDesignOutlinedDatePicker#��[ 5p      $
 1Q�5q      	 . 5r        5t      -	   5        $ fecha_firmeza_sentencia��5t      $) #Fecha de la firmeza de la Sentencia��5u      $��12q�5v      #��[ 5w      $
 1Q�5x      	 . 5y      � 5{       5|      �� 5}      �� 5~      .+�5�      �� -
   5        $ no_sentencia��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ No. de la Sentencia��5�      �� 5�      -   5        $ no_radicacion��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ No. de la Radicación��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minred��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      5�        5�      -   5        $ fecha_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5�      5�      