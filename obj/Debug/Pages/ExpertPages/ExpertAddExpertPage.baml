   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:CompetitionApp.Pages.ExpertPages CompetitionApp.Pages.ExpertPages  5      :    4CompetitionApp.Pages.ExpertPages.ExpertAddExpertPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:CompetitionApp.Pages.ExpertPages     5        N� Title$  ExpertAddExpertPage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� m     �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$	 150��6&   5      �� 5   
   " ��6   .�5      ��  � ��$	 300��6&   5      5      .��5      � .+�5   
   �� $��Center=�6   $��Center=�5      .+�5      �� -   5         ��Name$ 	TextTitle��5      $'��!Добавить эксперта��5         H1#��[  5      5      �� 5       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�5      .+�5       �� $��Фамилия: ��6   �� 5!      ��6   �� *	Surname+5"      �� 5$      $ 
Horizontal=�6   $��0 0 0 10q�5%      .+�5&      �� $��Имя: ��6   �� 5'      ��6   �� *Name+5(      �� 5*      $ 
Horizontal=�6   $��0 0 0 10q�5+      .+�5,      �� $��Отчество: ��6   �� 5-      ��6   �� *
LastName+5.      �� 50      $ 
Horizontal=�6   $��0 0 0 10q�51      .+�52      �� $��Пол: ��6   �� 53      -   5         ��Name$ ComboGender��54      $	��300��53       �� DisplayMemberPath$ 
GenderName��56      	 �� SelectedItem	 55      �� *Gender+56      57      �� 59      $ 
Horizontal=�6   $��0 0 0 10q�5:      .+�5;      �� $!��Дата рождения: ��6   (  "System.Windows.Controls.DatePicker  5<      $	��300��6   
   SelectedDate
 5=      �� *	BirthDate+5>      �� 5@      $ 
Horizontal=�6   $��0 0 0 10q�5A      .+�5B      �� $��Участник: ��6   �� 5C      -   5        $ ComboCompetitor��5D      $	��300��5C      $ 	ShortName��5F      	 5E      �� *Expert1.User+5F      5G      �� 5I      $ 
Horizontal=�6   $��0 0 0 10q�5J      .+�5K      �� $��Регион: ��6   �� 5L      -   5        $ ComboRegion��5M      $	��300��5L      $ 
RegionName��5O      	 5N      �� *Region+5O      5P      �� 5R      $ 
Horizontal=�6   $��0 0 0 10q�5S      .+�5T      �� $��Email: ��6   �� 5U      ��6   �� *Email+5V      �� 5X      $ 
Horizontal=�6   $��0 0 0 20q�5Y      .+�5Z      �� $��Телефон: ��6   �� 5[      ��6   �� *Phone+5\      � 5^      .+�5_      �� -   5         ��Name$ BtnAdd��5_      $��Сохранить��5`       
 BtnRed#��[ 5b      $	��200��5c      $
��Left=�5d      �� 5e      -   5        $ BtnBack��5e      $��
Назад��5f        BtnBlue#��[ 5h      $	��200��5i      $��Right=�5j      5k      5m      5o      5p      