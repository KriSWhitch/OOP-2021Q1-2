   M S B A M L   `   `   `  ����  TrueFriendsApp&     TrueFriendsApp.View.CreateAdPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      Z	 VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/ 	 5      $	��620��5      $
��1220��6/   .��5	      � 
�������.+�5
   
   �� $��10q�6     �� Orientation$  Vertical=�6!   .+�5      �� $  
Horizontal=�6   $��60��62   $	��Top=�6>   $
��Left=�6V   .+�5      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5      �� -   5         ��Name$ AdFullNameLabel��5         m_CreateAdPage_FullName#���   65   $��20(�6i   $	��180��6w   $��40��6�   6�   �� 5      -   5         ��Name$ AdFullNameTextBox��5   L   $��	10 0 20 0q�69   
���   �$	��300��6z   $��40��6�   $��20(�6�    � Cursor$ IBeam��6�   ��6   �� *
FullName+6�   " 	 FontAwesome.WPF.ImageAwesome  5      -   5          Name$ FullNameValidationImage��5   }   $	��Top=�6   $��40��6  $��40��6#     Icon 6&   ��  �� Path$ FullNameValidationIcon� �� Mode$ TwoWay=� �� TargetNullValue$ MinusCircle��y�6�   �� $&  FullNameValidationIconVisibility�$ TwoWay=�$ Hidden��61  5      �� 5      $
��0 10q�6   $  
Horizontal=�6+   .+�5      �� -   5        $ AdShortNameLabel��5        m_CreateAdPage_ShortName#���  66   $��20(�6k   $	��180��6y   $��40��6�   6�   �� 5      -   5        $ AdShortNameTextBox��5   L   $��	10 0 20 0q�69   
���   �$	��300��6{   $��40��6�   $��20(�6�   ��6   �� *	ShortName+6�     5      -   5        $ ShortNameValidationImage��5   ~   $	��Top=�6  $��40��6  $��40��6&   6&   �� $ ShortNameValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $' !ShortNameValidationIconVisibility�$ TwoWay=�$ Hidden��64  5      5      �� 5      $  
Horizontal=�6   $��60��62   $	��Top=�6>   $
��Left=�6V   .+�5      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5      �� -   5        $ AdRaitingLabel��5        m_CreateAdPage_Raiting#���  64   $��20(�6g   $	��180��6u   $��40��6�   6�   �� 5      -   5        $ AdRaitingTextBox��5   T   $��	10 0 20 0q�6A   
���   �$	��300��6�   $��40��6�   $��20(�6�   $ IBeam��6�   ��6   �� *	Raiting+	 �� Delay$		 250��6�     5      -	   5        $ RaitingValidationImage��5   |   $	��Top=�6�   $��40��6  $��40��6    6&   �� $ RaitingValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $% RaitingValidationIconVisibility�$ TwoWay=�$ Hidden��6.  5      �� 5      $
��0 10q�6   $  
Horizontal=�6+   .+�5      �� -
   5        $ AdCostLabel��5        m_CreateAdPage_Cost#���  61   $��20(�6a   $	��180��6o   $��40��6{   6�   �� 5      -   5        $ AdCostTextBox��5   G   $��	10 0 20 0q�64   
���   �$	��300��6q   $��40��6}   $��20(�6�   ��6   �� *Cost+6�     5       -   5        $ CostValidationImage��5    y   $	��Top=�6�   $��40��6  $��40��6   6&   �� $ CostValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $" CostValidationIconVisibility�$ TwoWay=�$ Hidden��6%  5!      5"      �� 5#      $  
Horizontal=�6   $��80��62   $	��Top=�6>   $
��Left=�6V   .+�5$      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5%      �� -   5        $ AdCategoryLabel��5%        m_CreateAdPage_Category#���  65   $��20(�6i   $	��180��6w   $��40��6�   6�   �� 5&      -   5        
 ��Name$
 AdCategoryTextBox��5&   L   $��	10 0 20 0q�69   $	��300��6g   $��40��6s   $	��Top=�6   $��16(�6�    �� Text 6   �� *
Category+.@�5'      �� Одежда6,   �� 5(      
Обувь6+   �� 5)      Аксессуары60   �� 5*      Прочее6,   5+        5,      -   5        $ CategoryValidationImage��5,   }   $	��Top=�6   $��40��6  $��40��6#   6&   �� $ CategoryValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $&  CategoryValidationIconVisibility�$ TwoWay=�$ Hidden��61  5-      �� 5.      $��	0 10 0 10q�6   $  
Horizontal=�60   .+�5/      �� -   5        $ AdAmountLabel��5/        m_CreateAdPage_Amount#���  63   $��20(�6e   $	��180��6s   $��40��6   6�   �� 50      -   5        $ AdAmountTextBox��50   I   $��	10 0 20 0q�66   
���   �$	��300��6u   $��40��6�   $��20(�6�   ��6   �� *Amount+6�     51      -   5        $ AmountValidationImage��51   {   $��40��6�   $��40��6   6&   �� $ AmountValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $$ AmountValidationIconVisibility�$ TwoWay=�$ Hidden��6  52      53      �� 54      $  Vertical=�6   $	��400��60   $	��Top=�6=   $
��Left=�6U   .+�55      ��   m_CreateAdPage_Images#���  6   $��20(�6J   $	��180��6X   $��40��6d   $	��Top=�6p   $
��Left=�6�   6�   �� 56      $  
Horizontal=�6   .+�57      �� $  Vertical=�6!   $��0 0 50 0q�68   .+�58      �� $
��0 10q�6%   $  
Horizontal=�63   .+�59      � -   5         �Name$ AdMainImageWrapper��59   #   ���#C0C0C0.+�5:   "   �� -   5         ��Name$ AdMainImage��5:   (   $  ��6\   $	��580��6f   $	��320��6r   ��6=   �� *ImageSource+6�   �� 5;   "   -   5         ��Name$ AdMainImageButtonClose��5;   )   $y�	Collapsed=�6n    K� ZIndex$	 100��6�   $��60��6�   $��60��6�   ���#5AA9B0$	��Top=�6�   $��Right=�6�   $
 Hand��6  ��6I   �� *imageButtonClose+��6�   Z� .��5<   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6>   
�������$��35��6^   $��35��6i   $��Center=�6u   6�   5=   #   5>      5?      5@      �� 5A      $  Vertical=�6!   $	��Top=�68   $
��Left=�6P   .+�5B      �� -   5        $ AddPhotoButton��5B   !   $��Center=�6\   $��Center=�6y      m_CreateAdPage_AdPhotoButton#���  6�   $��	0 10 0 10q�6�   $	��470��6�   $��50��6�   $��20(�6�   
���   �
���   �$
 Hand��6C  ��69   �� *addPhotoButton+��6  Z� 6S  �� 5C      $��20(�6$     m_CreateAdPage_Text1#���  62   $��0 5 0 5q�6`   $ 10��6q   
���   �6�   �� 5D      $��20(�6$    	 m_CreateAdPage_Text2#��� 	 62   $��0 15 0 5q�6`   $ 10��6r   
���   �6�   �� 5E      -   5        $ CreateAdButton��5E   !   $��Center=�6\   $��Center=�6y    !
 m_CreateAdPage_CreateAdButton#��� 
 6�   $��
0 130 0 25q�6�   $	��470��6�   $��50��6�   $��20(�6�   ���#5AA9B0���#5AA9B0
���������69   �� *createAdButton+6H  5F      5G      5H      5I      5J      5K      