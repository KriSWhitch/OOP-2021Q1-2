   M S B A M L   `   `   `  ����  TrueFriendsApp$    TrueFriendsApp.View.AdvertPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      $	��620��5      $
��1200��6   .��5	      � 
�������.+�5
   
   �� $��10q�6     �� Orientation$  Vertical=�6!   .+�5      ]� $��40��6   $	��Top=�6$   .+�5      �� $  
Horizontal=�6   $
��Left=�66   .+�5      �� -   5         ��Name$ ButtonBackToHomePage��5      $��70��6d   $��35��6o   $��Center=�6�   $
��Left=�6�   ��6;   �� *buttonBackToHomePage+��6{   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
���   �$��30��6V   $��25��6a   6o   5      5      �� 5      $  
Horizontal=�6   $��Right=�66   .+�5      �� -   5        $ ButtonEditAdvert��5      $��70��6\   $��35��6g   $��Center=�6�   $��Right=�6�   ��67   �� *buttonEditAdvert+��6s   Z� ��6�   Z� .��5        $
 Edit=�62   
���   �$��30��6Q   $��25��6\   6j   5      �� 5      -   5        $ ButtonDeleteAdvert��5      $��70��6`   $��35��6k   $��Center=�6�   $��Right=�6�   ��69   �� *buttonDeleteAdvert+��6w   Z� ��6�   Z� .��5        $ Delete=�62   
���   �$��30��6S   $��25��6^   6l   5      5      5      �� 5      $  
Horizontal=�6   $��60��62   $	��Top=�6>   $
��Left=�6V   .+�5      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5      �� -   5         ��Name$ AdFullNameLabel��5         m_AdvertPage_FullName#���   65   $��20(�6g   $	��180��6u   $��40��6�   6�   �� 5      -   5         ��Name$ AdFullNameTextBox��5   ]    �� 
IsReadOnly$
 True��68   $��	10 0 20 0q�6J   
���   �$	��300��6�   $��40��6�   $��20(�6�    � Cursor$ IBeam��6�   ��6   �� *
FullName+6�   5      �� 5      $
��0 10q�6   $  
Horizontal=�6+   .+�5       �� -   5        $ AdShortNameLabel��5         m_AdvertPage_ShortName#���  66   $��20(�6i   $	��180��6w   $��40��6�   6�   �� 5!      -   5        $ AdShortNameTextBox��5!   ^   $
 True��69   $��	10 0 20 0q�6K   
���   �$	��300��6�   $��40��6�   $��20(�6�   ��6   �� *	ShortName+6�   5"      5#      �� 5$      $  
Horizontal=�6   $��60��62   $	��Top=�6>   $
��Left=�6V   .+�5%      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5&      �� -   5        $ AdRaitingLabel��5&        m_AdvertPage_AnimalWeight#���  64   $��20(�6j   $	��180��6x   $��40��6�   6�   �� 5'      -	   5        $ AdRaitingTextBox��5'   a   $
 True��6<   $��	10 0 20 0q�6N   
���   �$	��300��6�   $��40��6�   $��20(�6�   ��6   �� *AnimalWeight+6�   5(      �� 5)      $
��0 10q�6   $  
Horizontal=�6+   .+�5*      �� -
   5        $ AdCostLabel��5*        m_AdvertPage_AnimalAge#���  61   $��20(�6d   $	��180��6r   $��40��6~   6�   �� 5+      -   5        $ AdCostTextBox��5+   ^   $
 True��69   $��	10 0 20 0q�6K   
���   �$	��300��6�   $��40��6�   $��20(�6�   ��6   �� *	AnimalAge+6�   5,      5-      �� 5.      $  
Horizontal=�6   $��80��62   $	��Top=�6>   $
��Left=�6V   .+�5/      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�50      �� -   5        $ AdCategoryLabel��50        m_AdvertPage_KindOfAnimal#���  65   $��20(�6k   $	��180��6y   $��40��6�   6�   �� 51      -   5        $ AdCategoryTextBox��51   t   
���   �$
 True��6O   $��	10 0 20 0q�6a   $	��300��6�   $��40��6�   $	��Top=�6�   $��20(�6�   $ IBeam��6�   ��6   �� *KindOfAnimal+6�   52      �� 53      $��	0 10 0 10q�6   $  
Horizontal=�60   .+�54      �� -   5        $ AdAmountLabel��54        m_AdvertPage_Description#���  63   $��20(�6h   $	��180��6v   $��40��6�   6�   �� 55      -   5        $ AdAmountTextBox��55   `   $
 True��6;   $��	10 0 20 0q�6M   
���   �$	��300��6�   $��40��6�   $��20(�6�   ��6   �� *Description+6�   56      57      �� 58      $  Vertical=�6   $	��300��60   $	��Top=�6=   $
��Left=�6U   .+�59      ��   m_AdvertPage_Images#���  6   $��20(�6H   $	��180��6V   $��40��6b   $	��Top=�6n   $
��Left=�6�   6�   �� 5:      $  
Horizontal=�6   .+�5;      �� $  Vertical=�6!   .+�5<      �� $
��0 10q�6%   $  
Horizontal=�63   .+�5=      � -   5         �Name$ AdMainImageWrapper��5=   #   ���#C0C0C0.+�5>   "   �� -   5         ��Name$ AdMainImage��5>   G   $  ��6\   $	��400��6f   $	��300��6r   ��6(   �� *ImageSource+6�   5?      5@      5A      5B      5C      5D      5E      5F      