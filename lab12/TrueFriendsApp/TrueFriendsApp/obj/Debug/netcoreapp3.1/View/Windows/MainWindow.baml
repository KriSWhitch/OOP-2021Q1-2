   M S B A M L   `   `   `  ����  TrueFriendsApp$    TrueFriendsApp.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   -   5          � Title$  TrueFriends��5   	   $	��720��6   $	��720��6-   $
��1280��6:   $
��1280��6J    � Icon$ ../../images/icon.ico��6W   
������� � 
ResizeMode$ CanMinimize=�5	   $    � 	Resources 5
         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  MouseCursor � Cursor��%�  &	        &	 �     &	 �    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 300Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 300Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      � 5   
   $! ../../images/arrow_bold.cur��6/   5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5"      � .+�5#   
   � $��60��6   $	��Top=�6   ���#5AA9B0.+�5$      �� $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5%      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen$ False��6_      PopupContent. 5&      �� $	��150��6!   .+�5'      �� -   5         ��Name$ 	ButtonFAQ��5'   !   $	��FAQ��64   ��6B   �� *	buttonFAQ+�� 5(      �� 5)      -   5        $ ButtonPopUpLogout��5)   !    " m_MainWindow_ButtonPopUpLogout#���  6<   ��6w   �� *buttonPopUpLogout+5*      5+      5,      �� 5-      $��0 0 60 0q�6   $��Center=�6+   $ 
Horizontal=�6F   $��Right=�6_   5.      � 5/   
   -   5         �Name$ GridMenu��5/      $��60��6!   $
��Left=�6,   ���	#FF3E7585 K� ZIndex$	 100��6^   .+�50      �� -   5         ��Name$ MenuControlPanel��50      .+�51      � $��60��6   ���	#FF3E7585.+�52      �� -   5        $ ButtonCloseMenu��52      $��60��6�   $��60��6�   $	��Top=�6�   $��Right=�6  $
 Hand��6+  ��66   �� *buttonCloseMenu+y�6Z   �� *ButtonCloseMenuVisibility+ �� Mode$ TwoWay=� �� TargetNullValue$ 	Collapsed����6�   Z� ��6�   Z� .��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
�������$��25��6V   $��25��6a   6o   54      �� 55      -   5        $ ButtonOpenMenu��55      $��60��6�   $��60��6�   $	��Top=�6�   $��Right=�6
  ��65   �� *buttonOpenMenu+y�6X   �� *ButtonOpenMenuVisibility+$ TwoWay=�$ Visible����6�   Z� ��6�   Z� .��56        $
 Menu=�62   
�������$��25��6Q   $��25��6\   6j   57      58      �� 59      -   5        $ MenuButtons��59      $	��0 0q�62   $��Disabled=�6?   $ Vertical=�6u   .+�5:      �� -	   5        $ 
HomeButton��5:      $��60��6c   $
��Left=�6�   ��61   �� *LoadMainCommand+$ OneTime=���6o   Z� ��6�   Z� .��5;      �� $ 
Horizontal=�6%   .+�5<        $ ViewDashboard=�66   $��25��6K   $��25��6V   $��Center=�6b   $��0 0 10 0q�6}   6�   �� 5=        m_MainWindow_Home#���  6(   $��Center=�6S   $��20 10q�6n   $��20(�6}   6�   5>      5?      �� 5@      -
   5        $ CreateAdButton��5@   )   $��60��6   $
��Left=�6�   $
 Hand��6�   y�6A   �� *CreateAdButtonVisibility+��6q   �� *LoadCreateAdPageCommand+$ OneTime=���6�   Z� ��6�   Z� .��5A      �� $ 
Horizontal=�6%   .+�5B        $ Pencil=�66   $��25��6D   $��25��6O   $��Center=�6[   $��0 0 10 0q�6v   6�   �� 5C        m_MainWindow_CreateAd#���  6(   $��Center=�6W   $��20 10q�6r   $��20(�6�   6�   5D      5E      �� 5F      -   5        $ GitHubButton��5F   )   $��60��6   $
��Left=�6l   ��6?   Z� ��6U   Z� ��6�   �� *gitHubButton+.��5G      �� $ 
Horizontal=�6%   .+�5H        $ Github=�66   $��25��6D   $��25��6O   $��Center=�6[   $��0 0 10 0q�6v   6�   �� 5I        m_MainWindow_GitHub#���  6(   $��Center=�6U   $��20 10q�6p   $��20(�6   6�   5J      5K      5L      5M      5N      �� 5O   
   -   5         ��Name$ 
OutputView��5O   K   $��1��6;   $��	60,60,0,0q�6_   ��6   �� *CurrentPage+5P      5Q      5R      