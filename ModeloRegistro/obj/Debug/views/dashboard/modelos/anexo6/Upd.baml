   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo6-ModeloRegistro.views.dashboard.modelos.anexo6  5      7    1ModeloRegistro.views.dashboard.modelos.anexo6.Upd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo6     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Upd��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Actualizar Anexo 6��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
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
��Bold"�5M      $"SOLICITUD DE SENTENCIA DE DIVORCIO6R   �� 5O      $��0q�6   $��Center=�5P      )'Nombres y Apellidos de los Divorciados:6b   �� 5Q      -   5        $ nombre_apellido_hombre��5Q      $��12q�5R      #��[ 5S      	 . $
 1Q�5U      $ Nombre Esposo��5V      �� 5W      -   5        $ nombre_apellido_mujer��5W      $��12q�5X      #��[ 5Y      	 . $
 1Q�5[      $ Nombre Mujer��5\      �� 5^      -   5        $ tribunal_dicto_sentencia��5^      $��12q�5_      #��[ 5`      	 . $
 1Q�5b      $# Tribunal que dictó Sentencia��5c      �� 5e      -   5        $  nombre_secretario_actuante��5e      $��12q�5f      #��[ 5g      	 . $
 1Q�5i      $$ Nombre del Secretario actuante��5j      (  "System.Windows.Controls.DatePicker  5l      -   5          Name$ fecha_dicto_sentencia��5l      $# Fecha en que dictó Sentencia��5m      $��12q�5n       $  MaterialDesignOutlinedDatePicker#��[ 5o      $
 1Q�5p      	 . 5q        5s      -	   5        $ fecha_firmeza_sentencia��5s      $) #Fecha de la firmeza de la Sentencia��5t      $��12q�5u      #��[ 5v      $
 1Q�5w      	 . 5x      � 5z       5{      �� 5|      �� 5}      .+�5      �� -
   5        $ no_sentencia��5      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ No. de la Sentencia��5�      �� 5�      -   5        $ no_radicacion��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $ No. de la Radicación��5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ legalizacion_minred��5�      $��12q�5�      #��[ 5�      	 . $
 1Q�5�      $ Legalización en MINREX��5�      �� 5�      -   5        $ legalizacion_embajada��5�      $��12q�5�      $��1��5�      #��[ 5�      	 . $
 1Q�5�      $" Legalización en Embajada de��5�      5�        5�      -   5        $ fecha_solicitud��5�      $ Fecha de la solicitud��5�      $��12q�5�      #��[ 5�      $
 1Q�5�      	 . 5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $ CircleEditOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   
Actualizar6A   5�      5�      5�      5�      5�      5�      