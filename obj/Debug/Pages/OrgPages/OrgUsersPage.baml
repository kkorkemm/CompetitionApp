   M S B A M L   `   `   `  ����I  ECompetitionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CompetitionApp.Pages.OrgPagesCompetitionApp.Pages.OrgPages  5      0    *CompetitionApp.Pages.OrgPages.OrgUsersPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:CompetitionApp.Pages.OrgPages     5        N� Title$  OrgUsersPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � $��10q�6   $��Center=�5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 0 20 0q�5      .+�5      �� $��Компетенция: ��6   $��Center=�5      $��0 0 5 0q�5      �� 5      -   5         ��Name$ 
ComboSkill��5      $	��200��5       �� DisplayMemberPath$ 	SkillName��5      5      5      �� 5       $ 
Horizontal=�6   $��0 0 20 0q�5!      .+�5"      �� $��
Роль: ��6   $��Center=�5#      $��0 0 5 0q�5$      �� 5%      -   5        $ 	ComboRole��5%      $	��200��5&      $ RoleName��5'      5(      5)      �� 5+      $ 
Horizontal=�6   $��Center=�5,      .+�5-      �� -   5         ��Name$ CheckStatus��5-      5/      �� 50      $3��-Только неподтврежденные��6   $��5 0 0 0q�51      52      54      &   System.Windows.Controls.DataGrid  56   
   -   5          Name$ 
DGridUsers��56         AutoGenerateColumns .     
IsReadOnly . $��1��59      	   Columns	 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5?   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5>   %   �� *	Surname+5?   %     5@      $
 Имя��6%   $ * 5B   %    5A   %   �� *Name+5B   %     5C      $
 Отчество��6%   $ * 5E   %    5D   %   �� *
LastName+5E   %     5F      $
 Компетенция��6%   $ * 5G   %    5H   %   �� *Skill.SkillName+  5I      $
 Роль��6%   $ * 5J   %    5K   %   �� *UserRole.RoleName+  5L      $-
 'Статус подтверждения��6%    5M   %   �� *Status+4  .System.Windows.Controls.DataGridTemplateColumn  5N      $	 100 6)   $
 Согласование��5O   )      CellTemplate 5P      �� 5Q      .R�5R      ��  ��Name$ 
BtnConfirm��6%   -   5        $��Согласовать��5S   %      	BtnYellow#��[  5U   %   {�5V   %   �� *UserConfirm+5W      5Y      5[      5]      5^      