   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CompetitionApp.PagesCompetitionApp.Pages  5      C&clr-namespace:CompetitionApp.ViewModelCompetitionApp.ViewModel  5      "    CompetitionApp.Pages.OrgPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CompetitionApp.Pages     5      <	viewModel&clr-namespace:CompetitionApp.ViewModel     5        N� Title$  OrgPage��5
       � DataContext 5      %  CompetitionApp.ViewModel.MainVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.25* �6   �� 5       � RowDefinitions 5   
   �� 5      $��0.15* �6   �� 5      .+�5   
   � $��2��6   ���	#FF17479E5      �� 5!   
   -   5         ��Name$
 Logo��5!      ��5"      �� 5#       �� Path$
 Logo�6    �� TargetNullValue$ /Logos/wsrlogo-02.png��5&   /   5'      5)      � 5+   
   $��1��6   $��Center=�5,      .+�5-      �� $��15 0 0 0q�6   $
��Left=�5.      $��Center=�5/      .+�50      �� -   5         ��Name$ TextCompName��50      $��18(�51      $
��Bold"�52      
�������53      54      �� 56      -   5         ��Name$ BtnExit��56      $��
Выход��57      $��Right=�59      $	��150��5:      $��30��5;       
  BtnRed#��[  5<      $��0 0 15 0q�5=      5?      � 5A   
   $��1��6   ���	#FFD1D3D4 5D      �� 5E      $
��auto �6    �� 5F      .+�5I      �� $��Center=�6   $��Center=�5J      $��	0 20 0 20q�5K      .+�5M      �� $-��'ТЕХНИЧЕСКАЯ ДИРЕКЦИЯ��6   $��14(�5N      ���	#FF1D2D75$��SemiBold"�5P      $
��Wrap=�5Q      	 �� TextAlignment$	 Center=�5R      $��Center=�5S      $��0 0 0 5q�5T      �� 5U      -   5        $ 	TextHello��5U      $��14(�5V      ���	#FF1D2D75$��SemiBold"�5X      $
��Wrap=�5Y      $	 Center=�5Z      $��Center=�5[      $��0 0 0 5q�5\      �� 5]      -   5        $ TextDay��5]      $��14(�5^      ���	#FF1D2D75$��SemiBold"�5`      $
��Wrap=�5a      $	 Center=�5b      $��Center=�5c      $��1��5d      5e      �� 5g      $��1��6   .+�5h      	� $'��!Список участников��6   $��14(�5i      ���	#FF1D2D75$��60��5k        
MenuButton#��[ 5l      
 d� 	IsChecked$

 TrueY�5m      ��5n      �� *OrgUserCommand+	� 5p      $-��'Настройка чемпионата��6   $��14(�5q      ���	#FF1D2D75$��60��5s      #��[ 5t      ��5u      �� *OrgSettingCommand+	� 5w      $4��.Список главных экспертов��6   $��14(�5x      ���	#FF1D2D75$��60��5z      #��[ 5{      ��5|      �� *OrgExpertCommand+	� 5~      $9��3Отчет по сданным протоколам��6   $��14(�5      ���	#FF1D2D75$��60��5�      #��[ 5�      ��5�      �� *OrgReportCommand+5�      5�      �� 5�   
   $��1��6   $��1��5�      $��15q�5�      ��5�      �� *CurrentView+5�      5�      