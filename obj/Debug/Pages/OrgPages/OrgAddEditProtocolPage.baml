   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CompetitionApp.Pages.OrgPagesCompetitionApp.Pages.OrgPages  5      :    4CompetitionApp.Pages.OrgPages.OrgAddEditProtocolPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:CompetitionApp.Pages.OrgPages     5        N� Title$  OrgAddEditProtocolPage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%G  '��       '  I     '�� �     �� 5   
   " ��6   .�5      ��  � ��$	 300��6&   5      �� 5   
   "  6   .�5      ��  � ��$	 300��6&   5      �� 5   
   " ��6   .�5      ��  � ��$	 150��6&   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ Center=�62   5      5      .��5      � .+�5   
   �� $��Center=�6   $��Center=�5      .+�5      �� -   5         ��Name$ 	TextTitle��5       $'��!Добавить протокол��5         H1#��[  5      5       �� 5"      -   5         ��Name$ StackPanelAdded��5#      $��0 0 0 20q�5"      .+�5%      ��  �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�5&      .+�5'      �� $ ��Наименование: ��6    �� 5(      ��6   �� *ProtocolName+5)      �� 5+      $ 
Horizontal=�6   $��0 0 0 10q�5,      .+�5-      �� $��Содержание: ��6    �� 5.      ��6   �� *	Content+5/      �� 51      $ 
Horizontal=�6   $��0 0 0 10q�52      .+�53      �� $��
Роль: ��6    �� 54      -   5         ��Name$ 
ComboRoles��54      $	��300��55      	 �� DisplayMemberPath$	 RoleName��57      
 �� SelectedItem
 56      �� *
UserRole+57      58      �� 5:      $ 
Horizontal=�6   $��0 0 0 10q�5;      .+�5<      �� $%��День чемпионата: ��6    �� 5=      -   5        $ 	ComboDays��5=      $	��300��5>      $	 DayName��5?      
 5@      �� *Day+5A      5C      � 5F      $��0 0 0 20q�6   .+�5G      �� -   5         ��Name$ BtnAddField��5G      $��Добавить поле��5I      $	��200��5J      $
��Left=�5K        BtnBlue#��[ 5L      �� 5M      -   5        $ BtnAddColumn��5M      $%��Добавить столбец��5O      $	��200��5P      $��Right=�5Q      #��[ 5R      5S      � 5U      .+�5V      �� -   5        $ BtnSave��5V      $��Сохранить��5X      $	��200��5Y      $
��Left=�5Z       
 BtnRed#��[ 5[      �� 5\      -   5        $ BtnBack��5\      $��
Назад��5^      $	��200��5_      $��Right=�5`      #��[ 5a      5b      5d      5f      5g      