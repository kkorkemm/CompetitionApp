   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:CompetitionApp.Pages.CompetitiorPages%CompetitionApp.Pages.CompetitiorPages  5      C&clr-namespace:CompetitionApp.ViewModelCompetitionApp.ViewModel  5      >    8CompetitionApp.Pages.CompetitiorPages.CompetitorMainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:CompetitionApp.Pages.CompetitiorPages     5      <	viewModel&clr-namespace:CompetitionApp.ViewModel     5        N� Title$  CompetitorMainPage��5
       � DataContext 5      %  CompetitionApp.ViewModel.MainVM  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � �� �	#FF1D2D756+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ Center=�62   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5       � RowDefinitions 5    
   �� 5!      $��0.15* �6   �� 5"      .+�5%   
   � $��2��6   ���	#FF17479E5(      �� 5*   
   -   5         ��Name$
 Logo��5*      ��5+      �� 5,      	 �� Path$
	 Logo�6   
 �� TargetNullValue$
 Logos/wsrlogo-02.png��5/   /   50      52      � 54   
   $��1��6   $��Center=�55      .+�56      �� $��15 0 0 0q�6   $
��Left=�57      .+�58      �� -   5         ��Name$ TextCompName��58      $��18(�59      $
��Bold"�5:      
�������$��0 0 0 5q�5<      $
��Left=�5=      �� 5>      -   5        $ TextSkillName��5>      $��Компетенция: ��5?      $��14(�5@      
�������5A      5B      �� 5D      -   5         ��Name$ BtnExit��5D      $��
Выход��5E      $��Right=�5G      $	��150��5H      $��30��5I       
  BtnRed#��[  5J      $��0 0 15 0q�5K      5M      � 5O   
   $��1��6   ���	#FFD1D3D4 5R      �� 5S      $
��auto �6    �� 5T      .+�5W      �� $��	0 20 0 20q�6   .+�5X      �� -   5        $ 	TextHello��5X      $��0 0 0 5q�5Y      $��SemiBold"�5Z      �� 5[      -   5        $ TextDay��5[      $��SemiBold"�5\      $��1��5]      5^      �� 5`      $��1��6   .+�5a      	� $'��!Список участников��6   $��14(�5b      ���	#FF1D2D75$��60��5d        
MenuButton#��[ 5e       d� 	IsChecked$
 TrueY�5f      ��5g      �� *CompetitorUsersCommand+	� 5i      $'��!Список протоколов��6   $��14(�5j      ���	#FF1D2D75$��60��5l      #��[ 5m      ��5n      �� *CompetitorProtocolsCommand+5o      5q      �� 5s   
   $��1��6   $��1��5t      $��15q�5u      ��5v      �� *CurrentView+5x      5y      