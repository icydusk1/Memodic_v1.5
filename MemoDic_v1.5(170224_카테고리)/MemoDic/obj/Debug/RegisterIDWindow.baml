   M S B A M L   `   `   `  ����B  >MemoDic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MemoDicMemoDic  5   	       MemoDic.RegisterIDWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MemoDic     5   	     � Title$  Register ID��5   	   $	��225��6   $	��225��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ TB_NewID��5
      $
��Left=�6$   $��23��6?   $��	35,24,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��144��6�    �� 	MaxLength$ 10��6�   �� 5   
    J� IsHitTestVisible .  $�� New ID��6-   $	��Top=�6<   $
��Left=�6T   
���������6o   �� *Margin+ �� ElementName$ TB_NewID����5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63   	 �� Triggers	 5      �� 5      
 �� Binding
 6&   �� *Text+$ TB_NewID�� �� Value  6U   .a�5      ��  � y�$ Visible=�6;   5      5      5      G� 5   
   -   5         G�Name$ PB_NewPW��5      $
��Left=�6(   $��	35,47,0,0q�6C   $	��Top=�6V   $	��144��6n   $��23��6�   �� 5   
   -   5         ��Name$ 	TBL_NewPW��5       .  $�� New PW��6@   $	��Top=�6O   $
��Left=�6g   
���������6�   �� *Margin+$ PB_NewPW��6�   G� 5   
   -   5        $ PB_ConfirmNewPW��5      $
��Left=�6/   $��	35,70,0,0q�6J   $	��Top=�6]   $	��144��6u   $��23��6�   �� 5   
   -   5        $ TBL_ConfirmNewPW��5       .  $�� Confirm New PW��6G   $	��Top=�6^   $
��Left=�6v   
���������6�   �� *Margin+$ PB_ConfirmNewPW��6�   �� 5   
   -   5        $ TB_HintForPW��5      $
��Left=�6(   $��23��6C   $��	35,93,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��144��6�   $ 10��6�   �� 5   
    .  $�� Hint for PW��6-   $	��Top=�6A   $
��Left=�6Y   
���������6t   �� *Margin+$ TB_HintForPW����5      �� 5      " ��6   .�5      ��  � y�$ 	Collapsed=�63   	 5       �� 5!      
 6&   �� *Text+$ TB_HintForPW��  6Y   .a�5"      ��  � y�$ Visible=�6;   5#      5%      5'      �� 5(   
   -   5         ��Name$ BTT_OK��5(      $��OK��6!   $
��Left=�6.   $��31��6I   $��
26,134,0,0q�6U   $	��Top=�6i   $��59��6�   6�   �� 5)   
   -   5        $ 
BTT_Cancel��5)      $��Cancel��6%   $
��Left=�66   $��31��6Q   $��130,134,0,0q�6]   $	��Top=�6r   $��59��6�   6�   5*      5+      