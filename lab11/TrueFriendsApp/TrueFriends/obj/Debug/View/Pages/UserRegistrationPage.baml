   M S B A M L   `   `   `  ����  TrueFriends4    .TrueFriendsApp.View.Pages.UserRegistrationPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� 
Background
  ����� N� Title$ UserRegistrationPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��300 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $	��420 �6   �� 5      .+�5   
   �� $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $	��Top=�6h   .+�5      �� -   5         ��Name$ ButtonBackToHomePage��5      $��60��6n   $��35��6y   $��Center=�6�   $
��Left=�6�    � Cursor$
 Hand��6�   ��63   �� *LoadAuthorizationCommand+ �� Mode$ OneTime=���6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6*   
���   �$��30��6N   $��25��6Y   6g   5      5      �� 5   
   $��1��6   $��1��6"   .+�5      �� $��0, 40, 0, 0q�6   .+�5      �� $'��!Введите ваш логин:��6   �� 5      -   5        	 ��Name$	 EmailTextBox��5      $��15(�5!      
���   �$��5q�5#      $��5q�5$      ��5       �� *Login+5$      5%      �� 5&      $��0, 40, 0, 100q�6   .+�5'      �� $)��#Введите ваш пароль:��6   �� 5(      -   5        $	 PasswordTextBox��5)      $��15(�5+      
���   �$��5q�5-      $��5q�5.      $ IBeam��6!   ��5*      �� *
Password+5.   !   5/      �� 50      $��15(�51      $��40��6   $��0, 15, 0, 0q�52      
����������#5AA9B0���#5AA9B0$
 Hand��54   <   ��52   &   �� *signUp+.��55      �� 
 �� TextAlignment$
 Center=�6   &$Зарегистрироваться6G   56      57      58      59      