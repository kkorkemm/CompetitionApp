   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CompetitionApp.PagesCompetitionApp.Pages  5      C&clr-namespace:CompetitionApp.ViewModelCompetitionApp.ViewModel  5      %    CompetitionApp.Pages.ExpertPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CompetitionApp.Pages     5      <	viewModel&clr-namespace:CompetitionApp.ViewModel     5        N� Title$  
ExpertPage��5
       � DataContext 5      %  CompetitionApp.ViewModel.MainVM  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � �� �	#FF1D2D756+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ Center=�62   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5       � RowDefinitions 5!   
   �� 5"      $��0.15* �6   �� 5#      .+�5&   
   � $��2��6   ���	#FF17479E5)      �� 5+   
   -   5         ��Name$
 Logo��5+      ��5,      �� 5-      	 �� Path$
	 Logo�6   
 �� TargetNullValue$
 Logos/wsrlogo-02.png��50   /   51      53      � 55   
   $��1��6   $��Center=�56      .+�57      �� $��15 0 0 0q�6   $
��Left=�58      .+�59      �� -   5         ��Name$ TextCompName��59      $��18(�5:      $
��Bold"�5;      
�������$��0 0 0 5q�5=      $
��Left=�5>      �� 5?      -   5        $ TextSkillName��5?      $��Компетенция: ��5@      $��14(�5A      
�������5B      5C      �� 5E      -   5         ��Name$ BtnExit��5E      $��
Выход��5F      $��Right=�5H      $	��150��5I      $��30��5J       
  BtnRed#��[  5K      $��0 0 15 0q�5L      5N      � 5P   
   $��1��6   ���	#FFD1D3D4 5S      �� 5T      $
��auto �6    �� 5U      �� 5V      $
��auto �6    .+�5Y      �� $��	0 20 0 20q�6   .+�5Z      �� -   5        $ 	TextHello��5Z      $��0 0 0 5q�5[      $��SemiBold"�5\      �� 5]      -   5        $ TextDay��5]      $��SemiBold"�5^      $��1��5_      5`      �� 5b      $��1��6   .+�5c      	� $'��!Список участников��6   $��14(�5d      ���	#FF1D2D75$��60��5f        
MenuButton#��[ 5g       d� 	IsChecked$
 TrueY�5h      ��5i      �� *ExpertUserCommand+	� 5k      $%��Список экспертов��6   $��14(�5l      ���	#FF1D2D75$��60��5n      #��[ 5o      ��5p      �� *ExpertExpertCommand+	� 5r      $��Протоколы��6   $��14(�5s      ���	#FF1D2D75$��60��5u      #��[ 5v      ��5w      �� *ExpertProtocolCommand+5x      �� 5z      $��2��6   $��	0 20 0 20q�5{      .+�5|      �� $8��2Ваш код доступа на сегодня: ��6   $��5q�5}      $��SemiBold"�5~      �� 5      -   5         ��Name$ TextCode��5       �� TextAlignment$ Center=�5�       �� 
IsReadOnly . $��5 0 5 0q�5�      5�      5�      �� 5�   
   $��1��6   $��1��5�      $��15q�5�      ��5�      �� *CurrentView+5�      5�      