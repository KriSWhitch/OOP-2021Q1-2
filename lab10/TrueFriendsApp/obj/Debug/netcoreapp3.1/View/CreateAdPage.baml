   M S B A M L   `   `   `  ����  TrueFriendsApp&     TrueFriendsApp.View.CreateAdPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      Z	 VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/ 	 5      $	��620��5      $
��1200��6/   .��5	      � 
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
Horizontal=�61   .+�5      �� -   5        $ AdRaitingLabel��5        m_CreateAdPage_AnimalWeight#���  64   $��20(�6l   $	��180��6z   $��40��6�   6�   �� 5      -   5        $ AdRaitingTextBox��5   Y   $��	10 0 20 0q�6F   
���   �$	��300��6�   $��40��6�   $��20(�6�   $ IBeam��6�   ��6   �� *AnimalWeight+	 �� Delay$		 250��6�     5      -	   5        $! AnimalWeightValidationImage��5   �   $	��Top=�6  $��40��6$  $��40��6/   6&   �� $  AnimalWeightValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $* $AnimalWeightValidationIconVisibility�$ TwoWay=�$ Hidden��6=  5      �� 5      $
��0 10q�6   $  
Horizontal=�6+   .+�5      �� -
   5        $ AdCostLabel��5        m_CreateAdPage_AnimalAge#���  61   $��20(�6f   $	��180��6t   $��40��6�   6�   �� 5      -   5        $ AdCostTextBox��5   L   $��	10 0 20 0q�69   
���   �$	��300��6v   $��40��6�   $��20(�6�   ��6   �� *	AnimalAge+6�     5       -   5        $ AnimalAgeValidationImage��5    ~   $	��Top=�6  $��40��6  $��40��6&   6&   �� $ AnimalAgeValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $' !AnimalAgeValidationIconVisibility�$ TwoWay=�$ Hidden��64  5!      5"      �� 5#      $  
Horizontal=�6   $��80��62   $	��Top=�6>   $
��Left=�6V   .+�5$      �� $��
0 10 80 10q�6   $  
Horizontal=�61   .+�5%      �� -   5        $ AdCategoryLabel��5%        m_CreateAdPage_KindOfAnimal#���  65   $��20(�6m   $	��180��6{   $��40��6�   6�   �� 5&      -   5        
 ��Name$
 AdCategoryTextBox��5&   P   $��	10 0 20 0q�6=   $	��300��6k   $��40��6w   $	��Top=�6�   $��16(�6�    �� Text 6   �� *KindOfAnimal+.@�5'      �� Собака6,   �� 5(      
Кошка6+   5)        5*      -   5        $! KindOfAnimalValidationImage��5*   �   $	��Top=�6  $��40��6$  $��40��6/   6&   �� $  KindOfAnimalValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $* $KindOfAnimalValidationIconVisibility�$ TwoWay=�$ Hidden��6=  5+      �� 5,      $��	0 10 0 10q�6   $  
Horizontal=�60   .+�5-      �� -   5        $ AdAmountLabel��5-        m_CreateAdPage_Description#���  63   $��20(�6j   $	��180��6x   $��40��6�   6�   �� 5.      -   5        $ AdAmountTextBox��5.   N   $��	10 0 20 0q�6;   
���   �$	��300��6z   $��40��6�   $��20(�6�   ��6   �� *Description+6�     5/      -   5        $  DescriptionValidationImage��5/   �   $��40��6	  $��40��6   6&   �� $ DescriptionValidationIcon�$ TwoWay=�$ MinusCircle��y�6�   �� $) #DescriptionValidationIconVisibility�$ TwoWay=�$ Hidden��6"  50      51      �� 52      $  Vertical=�6   $	��400��60   $	��Top=�6=   $
��Left=�6U   .+�53      ��   m_CreateAdPage_Images#���  6   $��20(�6J   $	��180��6X   $��40��6d   $	��Top=�6p   $
��Left=�6�   6�   �� 54      $  
Horizontal=�6   .+�55      �� $  Vertical=�6!   $��0 0 50 0q�68   .+�56      �� $
��0 10q�6%   $  
Horizontal=�63   .+�57      � -   5         �Name$ AdMainImageWrapper��57   #   ���#C0C0C0.+�58   "   �� -   5         ��Name$ AdMainImage��58   (   $  ��6\   $	��580��6f   $	��320��6r   ��6=   �� *ImageSource+6�   �� 59   "   -   5         ��Name$ AdMainImageButtonClose��59   )   $y�	Collapsed=�6n    K� ZIndex$	 100��6�   $��60��6�   $��60��6�   ���#5AA9B0$	��Top=�6�   $��Right=�6�   $
 Hand��6  ��6I   �� *imageButtonClose+��6�   Z� .��5:   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6>   
�������$��35��6^   $��35��6i   $��Center=�6u   6�   5;   #   5<      5=      5>      �� 5?      $  Vertical=�6!   $	��Top=�68   $
��Left=�6P   .+�5@      �� -   5        $ AddPhotoButton��5@   !   $��Center=�6\   $��Center=�6y      m_CreateAdPage_AdPhotoButton#���  6�   $��	0 10 0 10q�6�   $	��470��6�   $��50��6�   $��20(�6�   
���   �
���   �$
 Hand��6C  ��69   �� *addPhotoButton+��6  Z� 6S  �� 5A      $��20(�6$     m_CreateAdPage_Text1#���  62   $��0 5 0 5q�6`   $ 10��6q   
���   �6�   �� 5B      $��20(�6$    	 m_CreateAdPage_Text2#��� 	 62   $��0 15 0 5q�6`   $ 10��6r   
���   �6�   �� 5C      -   5        $ CreateAdButton��5C   !   $��Center=�6\   $��Center=�6y    !
 m_CreateAdPage_CreateAdButton#��� 
 6�   $��
0 130 0 25q�6�   $	��470��6�   $��50��6�   $��20(�6�   ���#5AA9B0���#5AA9B0
���������69   �� *createAdButton+6H  5D      5E      5F      5G      5H      5I      