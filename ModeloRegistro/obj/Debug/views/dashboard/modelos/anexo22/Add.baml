   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo22.ModeloRegistro.views.dashboard.modelos.anexo22  5      8    2ModeloRegistro.views.dashboard.modelos.anexo22.Add   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ModeloRegistro.views.dashboard.modelos.anexo22     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$	  Add��5	         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��800��5      $	��600��5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��120* �6   �� 5      $	��80* �6   �� 5      $
��486* �6   .+�5   
   ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Adicionar Anexo 22��5      $��Center=�5      $��24,0,0,0q�5      ���	#FF404E67$
��Left=�5      $
��Wrap=�5      � 5   
   $��1��6   .+�5       �� -   5         ! MaterialDesignFlatLightButton#��[ 5        � ToolTip$# MaterialDesignFlatLightButton��5!      $
��Left=�5"      $��Center=�5#      .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ArrowLeftDropCircleOutline=�6.   ���	#FF404E67$��20��5(   .   $��20��5)   .   $��Center=�5*   .   �� 5+      ���	#FF404E67$��16(�5,       $��Center=�5-       $��3,1,0,0q�5.       Atrás68   5/      50      51      �� 52   
   $��2��6   .��53      ��  �� Orientation$ Vertical=�6   .+�54      �� $��0q�6   $��Center=�55      $
��Bold"�56      +)SOLICITUD DE LEGALIZACIONES DE DOCUMENTOS6Y   (  "System.Windows.Controls.DatePicker  57      -   5          Name$ fecha_solicitud��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha de la solicitud��58      $��12q�59       $  MaterialDesignOutlinedDatePicker#��[ 5:      	   FloatingScale$	 1Q�5;      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5<      �� 5=      $��12q�6   $��Center=�5>      $
��Bold"�5?      DATOS DEL SOLICITANTE:6F   �� 5@      -   5         ��Name$ nombre��5@      $��12q�5A       ! MaterialDesignOutlinedTextBox#��[ 5B      
 . $	 1Q�5D      $) #NOMBRE Y APELLIDOS DEL QUE SOLICITA��5E      �� 5F      -   5        $ 
ciudadania��5F      $��12q�5G      #��[ 5H      
 . $	 1Q�5J      $ CIUDADANÍA��5K      �� 5L      -   5        $ estado_civil��5L      $��12q�5M      #��[ 5N      
 . $	 1Q�5P      $ ESTADO CIVIL��5Q        5R      -   5        $ fecha_nacimiento��5R      $ FECHA DE NACIMIENTO��5S      $��12q�5T      #��[ 5U      $	 1Q�5V      
 . 5W      �� 5X      -   5        $ 	profecion��5X      $��12q�5Y      #��[ 5Z      
 . $	 1Q�5\      $ 
PROFESIÓN��5]      �� 5^      -   5        $ carnet_pasaporte��5^      $��12q�5_      #��[ 5`      
 . $	 1Q�5b      $8 2NÚMERO DE IDENTIDAD PERMANENTE O PASAPORTE CUBANO��5c      �� 5d      -	   5        $ categoria_migratoria��5d      $��12q�5e      #��[ 5f      
 . $	 1Q�5h      $Y SSi es cubano CATEGORÍA MIGRATORIA (RESIDENTE EN EL TERRITORIO NACIONAL O EMIGRADO)��5i      �� 5j      -
   5        $ direccion_estados_unidos��5j      $��12q�5k      #��[ 5l      
 . $	 1Q�5n      $&  DIRECCIÓN EN LOS ESTADOS UNIDOS��5o      �� 5p      -   5        $ correo��5p      $��12q�5q      #��[ 5r      
 . $	 1Q�5t      $% DIRECCION DE CORREO ELECTRONICO��5u      �� 5v      -   5        $ celular��5v      $��12q�5w      #��[ 5x      
 . $	 1Q�5z      $ NUMERO DE CELULAR��5{      �� 5|      -   5        $ documento_legalizar��5|      $��12q�5}      #��[ 5~      
 . $	 1Q�5�      $ DOCUMENTO A LEGALIZAR��5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�      ���	#FF404E67���	#FFFAFAFA���	#FF404E67$
��Left=�5�      $	��Top=�5�      $��12q�5�      $	��246��5�      $��46��5�      .��5�      � .+�5�        $% CheckboxMarkedCirclePlusOutline=�62   $��20��5�   2   $��20��5�   2   �� 5�      $��Center=�6$   $��7,0,0,0q�5�   $   	Adicionar6@   5�      5�      5�      5�      5�      5�      