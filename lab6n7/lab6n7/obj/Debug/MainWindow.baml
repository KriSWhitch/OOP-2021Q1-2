   M S B A M L   `   `   `  ����A  =lab6n7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab6n7lab6n7  5   	   clr-namespace:lab6n7lab6n7  5   	       lab6n7.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (myCtrlsclr-namespace:lab6n7     5   	   &localclr-namespace:lab6n7     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  TrueFriends��5
   	   $	��720��6   $	��720��6-   $
��1280��6:   $
��1280��6J    � Icon$ images/icon.ico��6W   
������� � 
ResizeMode$ CanMinimize=�5        � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  MouseCursor � Cursor��%�  &	        &	 �     &	 �    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 300Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 300Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      � 5   
   $ Images/arrow_bold.cur��6/   5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5    
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5!      �� #��[ 6   5"      .��5%      � .+�5&   
   � $��60��6   $	��Top=�6   ���#5AA9B0.+�5'      �� $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5(      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 5)      �� $	��150��6!   .+�5*      �� -   5         ��Name$ 	ButtonFAQ��5*   !   $	��FAQ��64   6B   �� 5+      �� 5,      -   5        $ ButtonPopUpLogout��5,   !    " m_MainWindow_ButtonPopUpLogout#���  6<   6w   5-      5.      5/      �� 50      $��0 0 60 0q�6   $��Center=�6+   $ 
Horizontal=�6F   $��Right=�6_   .+�51      �� -   5         ��Name$ ComboBoxLanguages��51      $��Center=�66   $��Center=�6Z   $��15(�6|   $	��5 0q�6�   $��30��6�   $	��200��6�   
���   ����#5AA9B0
�������6�   52      53      � 54   
   -   5         �Name$ GridMenu��54      $��60��6!   $
��Left=�6,   ���	#FF3E7585 K� ZIndex$	 100��6^   .+�55      �� -   5         ��Name$ MenuControlPanel��55      .+�56      � $��60��6   ���	#FF3E7585.+�57      �� -   5        $ ButtonCloseMenu��57      $y�	Collapsed=�6T   $��60��6k   $��60��6v   $	��Top=�6�   $��Right=�6�   ��6�   Z� ��6�   Z� .��58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
�������$��25��6V   $��25��6a   6o   59      �� 5:      -   5        $ ButtonOpenMenu��5:      $��60��6R   $��60��6]   $	��Top=�6�   $��Right=�6�   ��6i   Z� ��6   Z� .��5;        $
 Menu=�62   
�������$��25��6Q   $��25��6\   6j   5<      5=      �� 5>      -	   5        $ MenuButtons��5>      $	��0 0q�62   $��Disabled=�6?   $ Vertical=�6u   .+�5?      �� -
   5        $ 
HomeButton��5?      $��60��6J   $
��Left=�6�   ��6V   Z� ��6l   Z� .��5@      �� $ 
Horizontal=�6%   .+�5A        $ ViewDashboard=�66   $��25��6K   $��25��6V   $��Center=�6b   $��0 0 10 0q�6}   6�   �� 5B        m_MainWindow_Home#���  6(   $��Center=�6S   $��20 10q�6n   $��20(�6}   6�   5C      5D      �� 5E      -   5        $ CreateAdButton��5E   )   $��60��6   $
��Left=�6�   ��6^   Z� ��6t   Z� .��5F      �� $ 
Horizontal=�6%   .+�5G        $ Pencil=�66   $��25��6D   $��25��6O   $��Center=�6[   $��0 0 10 0q�6v   6�   �� 5H        m_MainWindow_CreateAd#���  6(   $��Center=�6W   $��20 10q�6r   $��20(�6�   6�   5I      5J      �� 5K      -   5        $ GitHubButton��5K   )   $��60��6   $
��Left=�6l   ��6?   Z� ��6U   Z� .��5L      �� $ 
Horizontal=�6%   .+�5M        $ Github=�66   $��25��6D   $��25��6O   $��Center=�6[   $��0 0 10 0q�6v   6�   �� 5N        m_MainWindow_GitHub#���  6(   $��Center=�6U   $��20 10q�6p   $��20(�6   6�   5O      5P      5Q      5R      5S      � 5T   
   -   5        $ GridMain��5T   $   ���#C1C0C0$��	60,60,0,0q�66   5U      5V      5W      