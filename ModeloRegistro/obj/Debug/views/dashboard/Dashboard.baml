   M S B A M L   `   `   `  ����I  EModeloRegistro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ModeloRegistro.views.dashboardModeloRegistro.views.dashboard  5      .    (ModeloRegistro.views.dashboard.Dashboard   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ModeloRegistro.views.dashboard     5      _ [MaterialDesignThemes.Wpf, Version=5.2.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	Dashboard��5
         MaterialDesignBody#���   5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      $	��701��5      $
��1094��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��251* �6   �� 5      $
��843* �6    � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $	��73* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 0Q�6   ���	#FF404E67 K� ZIndex$ 1��5      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp3=�5      .��5      � .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  $��40��6*   $��40��5!   *      Kind$ ShieldAccountOutline=�5"   *   ���	#FFECEDF0$
��Left=�5$   *   $��Center=�5%   *   $��12,0,0,0q�5&   *   	 J� Effect	 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(      
   ShadowDepth$
 0Q�6+      
BlurRadius$ 3Q�5)   +      Opacity$ 1Q�5*   +   5,      �� 5.         MaterialDesignLightSeparator#��[ 6   $��18��5/       J� RenderTransformOrigin$ 0.5,0.5&�50      $��55,24,179,24q�51      $
��Auto��52      ���	#FFFD7A6B$��0q�54      $��0q�55      ��. 	 57        58      $
 0Q�6+   $ 3Q�59   +   z�5;      V� 5<      .~�5=      ��  �� ScaleY$ 3Q�6-   �� 5>      �� 5?       �� Angle$ 90Q�6.   T� 5@      5A      5C      �� 5E       $  MaterialDesignHeadline6TextBlock#��[ 6   $��Admin Dashboard��5F      $
��Left=�5G      $��Center=�5H      ���	#FFDEE1E5$��
74,20,0,17q�5J      $	��166��5K      	 5L        5M      $
 0Q�6+   $ 2Q�5N   +   5P      5Q      5R        5T   
   $ 0Q�6   $	 Dp3=�5U      $��1��5V      $ 1��5W      .��5X      � .+�5Y      �� -   5         ! MaterialDesignFlatLightButton#��[ 5Y      $��Right=�5Z      $��Center=�5[      $��63��5\      $	��155��5]      $��0,0,10,0q�5^      .��5`      � $	��122��6   .+�5a        $ AccountArrowLeftOutline=�62   $
��Left=�5b   2   $��Center=�5c   2   $��0,0,26,0q�5d   2   $��30��5e   2   $��30��5f   2   ���	#FF404E675g   2   �� 5h      ���	#FF404E67$��0q�5i   $   $��86��5j   $   $��Center=�5k   $   $��Right=�5l   $   �� 6A   $�Cerrar Sesión��6E   6^   5m      5n      5o      5p      � 5r   
   $��1��6   ���	#FF404E67.+�5t      �� $��0q�6   $��0q�5u      $
��Auto=�5v      $��8��5w      $	��600��5x      $	��Top=�5y      $��Center=�5z      .��5{      � .+�5|      �� #��[ 6    $��Navegación��5}       $��Center=�5~       $	��Top=�5       ���	#FF8A9499$��20,29,125,0q�5�       $��17(�5�       $	��106��5�       � 5�      $��0,70,0,0q�6   $	��Top=�5�       5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      R� $��38��6#   ���	#E5FFFFFF$��1q�5�   #   $��LeftToRight=�5�   #   $��Center=�5�   #   $
��Left=�5�   #   $��0q�5�   #   $
��Auto=�5�   #   $
��Auto=�5�   #   $	��450��5�   #   |�.   � 	Resources 5�       �� 
TargetType  MaterialDesignTreeViewItem �� BasedOn-  'MaterialDesignThemes.Wpf.TreeViewAssist �� Property �� Value��%l   'Q�       7  �� 5�   "   " Q�6(   8   .�5�   &   ��  �@ ExpanderSize$ 24Q�5�   -   5�   #   5�      .@�5�      Q� $��Modelos��6+   $��8q�5�   +   $��7,4,20,0q�5�   +   $	��Top=�5�   +   |�.  .@�5�   "   Q� -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *    �� Orientation$ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 2��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 3��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 4��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 5��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 6��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 7��5�   8   5�   +   5�   #   Q� 5�   "   -   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 9��5�   8   5�   +   5�   #   Q� 5�   "   -	   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5�   &   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��8,0,0,0q�68   $��Anexo 10��5�   8   5�   +   5�   #   Q� 5�   "   -
   5        $��Center=�5�   /   $��-7,8,8,8q�5�   /   ��5  &   �� 5  *   $ 
Horizontal=�65   .+�5  .   �� $��8,0,0,0q�68   $��Anexo 11��5  8   5  +   5  #   Q� 5	  "   -   5        $��Center=�5	  /   $��-7,8,8,8q�5
  /   ��5  &   �� 5  *   $ 
Horizontal=�65   .+�5  .   �� $��8,0,0,0q�68   $��Anexo 12��5  8   5  +   5  #   Q� 5  "   -   5        $��Center=�5  /   $��-7,8,8,8q�5  /   ��5  &   �� 5  *   $ 
Horizontal=�65   .+�5  .   �� $��8,0,0,0q�68   $��Anexo 13��5  8   5  +   5  #   Q� 5  "   -   5        $��Center=�5  /   $��-7,8,8,8q�5   /   ��5"  &   �� 5#  *   $ 
Horizontal=�65   .+�5$  .   �� $��8,0,0,0q�68   $��Anexo 14��5%  8   5&  +   5(  #   Q� 5*  "   -   5        $��Center=�5*  /   $��-7,8,8,8q�5+  /   ��5-  &   �� 5.  *   $ 
Horizontal=�65   .+�5/  .   �� $��8,0,0,0q�68   $��Anexo 15��50  8   51  +   53  #   Q� 55  "   -   5        $��Center=�55  /   $��-7,8,8,8q�56  /   ��58  &   �� 59  *   $ 
Horizontal=�65   .+�5:  .   �� $��8,0,0,0q�68   $��Anexo 16��5;  8   5<  +   5>  #   Q� 5@  "   -   5        $��Center=�5@  /   $��-7,8,8,8q�5A  /   ��5C  &   �� 5D  *   $ 
Horizontal=�65   .+�5E  .   �� $��8,0,0,0q�68   $��Anexo 17��5F  8   5G  +   5I  #   Q� 5K  "   -   5        $��Center=�5K  /   $��-7,8,8,8q�5L  /   ��5N  &   �� 5O  *   $ 
Horizontal=�65   .+�5P  .   �� $��8,0,0,0q�68   $��Anexo 18��5Q  8   5R  +   5T  #   Q� 5V  "   -   5        $��Center=�5V  /   $��-7,8,8,8q�5W  /   ��5Y  &   �� 5Z  *   $ 
Horizontal=�65   .+�5[  .   �� $��8,0,0,0q�68   $��Anexo 19��5\  8   5]  +   5_  #   Q� 5a  "   -   5        $��Center=�5a  /   $��-7,8,8,8q�5b  /   ��5d  &   �� 5e  *   $ 
Horizontal=�65   .+�5f  .   �� $��8,0,0,0q�68   $��Anexo 20��5g  8   5h  +   5j  #   Q� 5l  "   -   5        $��Center=�5l  /   $��-7,8,8,8q�5m  /   ��5o  &   �� 5p  *   $ 
Horizontal=�65   .+�5q  .   �� $��8,0,0,0q�68   $��Anexo 21��5r  8   5s  +   5u  #   Q� 5w  "   -   5        $��Center=�5w  /   $��-7,8,8,8q�5x  /   ��5z  &   �� 5{  *   $ 
Horizontal=�65   .+�5|  .   �� $��8,0,0,0q�68   $��Anexo 22��5}  8   5~  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 23��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 24��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 25��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 26��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 27��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 28��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 29��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 30��5�  8   5�  +   5�  #   Q� 5�  "   -   5        $��Center=�5�  /   $��-7,8,8,8q�5�  /   ��5�  &   �� 5�  *   $ 
Horizontal=�65   .+�5�  .   �� $��8,0,0,0q�68   $��Anexo 31��5�  8   5�  +   5�  #   5�     5�     �� 5     -   5        #��[ 5  !   $��38��5	  !   $��3��5
  !   |�. .��5     � $	��253��6#   .+�5  "     $ Logout=�6:   $��20��5  :   $��20��5  :   ���	#FFECEDF0$��Center=�5  :   �� 5  "   ���	#FFCECCC8$��Center=�5  ,   $��	35,2,13,2q�5  ,   Cerrar sesión6N   5     5     5     5     5     5      � 5  
   -    5          �Name$ frame_dashboard��5     $��1��5      $��1��5!       � NavigationUIVisibility$ Hidden=�5"     5$     5%     