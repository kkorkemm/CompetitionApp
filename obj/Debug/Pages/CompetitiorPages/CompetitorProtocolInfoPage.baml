   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:CompetitionApp.Pages.CompetitiorPages%CompetitionApp.Pages.CompetitiorPages  5      F    @CompetitionApp.Pages.CompetitiorPages.CompetitorProtocolInfoPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:CompetitionApp.Pages.CompetitiorPages     5        N� Title$   CompetitorProtocolInfoPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� .+�5      �� $��20(�5      $��SemiBold"�5       �� TextAlignment$ Center=�5      $
��Wrap=�5      $��Center=�5      $��5q�5      ��5      �� *ProtocolName+5      �� 5      $��16(�5      $ Justify=�5      $
��Wrap=�5      $��Center=�5       $��5q�5!      ��5      �� *	Content+5!      �� 5#      -   5         ��Name$ TextMainExpertName��5'      $"��ГЭ на площадке: ��5#      $ Center=�5$      $
��Wrap=�5%      $��Center=�5&      $��5q�5(      �� 5*      -   5         ��Name$ StackPanelAdded��5*      $��Center=�5+       � 	Resources 5,       �� 
TargetType �� Property �� Value��%�   '��       �� 5-      " ��6   .�5.      ��  � ��$ 0 0 20 5q�63   �� 5/       � ��$
 Wrap=�69   �� 50       � ��$ Center=�6>   51      52      53      55      &   System.Windows.Controls.DataGrid  57   
   -   5        	  Name$	 
DGridUsers��57      
   AutoGenerateColumns
 .     
IsReadOnly . $��1��5:      $��	0 20 0 20q�5;         Columns 5=      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5?   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5@   %   �� *User.FullName+  5A      $/ )Комментарий участника��6%   $ 2* 5B   %    5C   %   �� *	Comment+  5D      $	 PIN��6%   $ * 5E   %    5F   %   �� *
IsSigned+5I      � 5K   
   $��2��6    � Orientation$ 
Horizontal=�5L      $��Center=�5M      $��10 10 20 10q�5N      .+�5P      ��  �� Orientation$ 
Horizontal=�6   $��5q�5Q      .+�5R      �� $/��)Оставить комментарий: ��6   $��0 0 20 0q�5S      $��Center=�5T      �� 5V      -   5         ��Name$ TextComment��5V      $	��300��5W      $��Center=�5X      5Y      �� 5[      $ 
Horizontal=�6   $��5q�5\      .+�5]      �� $!��Введите PIN-код: ��6   $��0 0 20 0q�5^      $��Center=�5_      �� 5a      -   5        $ TextPin��5a      $	��200��5b      $��0 0 20 0q�5c      $��Center=�5d      �� 5f      -   5         ��Name$ BtnPin��5f      $)��#Подписать протокол��5g         	BtnYellow#��[  5h      $	��150��5i      5j      5k      5m      �� 5o   
   -   5        $ BtnBack��5o      $��
Назад��5p        BtnBlue#��[ 5q      $��3��5s      5u      5v      