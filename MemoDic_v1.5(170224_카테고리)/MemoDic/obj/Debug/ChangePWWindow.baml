   M S B A M L   `   `   `  ����B  >MemoDic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MemoDicMemoDic  5   	       MemoDic.ChangePWWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MemoDic     5   	     � Title$  	Change PW��5   	   $	��225��6   $	��225��6(   .��5	      � .+�5
   
   G� -   5         G�Name$ PB_PW��5
      $
��Left=�6%   $��23��6@   $��	35,24,0,0q�6L   $	��Top=�6_   $	��144��6w   6�   �� 5   
   -   5         ��Name$ TBL_PW��5       J� IsHitTestVisible .  $	�� PW��6=   $	��Top=�6H   $
��Left=�6`   
���������6{   �� *Margin+ �� ElementName$ PB_PW��6�   G� 5   
   -   5        $ PB_NewPW��5      $
��Left=�6(   $��23��6C   $��	35,47,0,0q�6O   $	��Top=�6b   $	��144��6z   6�   �� 5   
   -   5        $ 	TBL_NewPW��5       .  $�� New PW��6@   $	��Top=�6O   $
��Left=�6g   
���������6�   �� *Margin+$ PB_NewPW��6�   G� 5   
   -   5        $ PB_ConfirmNewPW��5      $
��Left=�6/   $��23��6J   $��	35,70,0,0q�6V   $	��Top=�6i   $	��144��6�   6�   �� 5   
   -   5        $ TBL_ConfirmNewPW��5       .  $�� Confirm New PW��6G   $	��Top=�6^   $
��Left=�6v   
���������6�   �� *Margin+$ PB_ConfirmNewPW��6�   �� 5   
   -   5         ��Name$ TB_HintForPW��5      $
��Left=�6(   $��23��6C   $��	35,93,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��144��6�    �� 	MaxLength$ 10��6�   �� 5   
    .  $�� Hint for PW��6-   $	��Top=�6A   $
��Left=�6Y   
���������6t   �� *Margin+$ TB_HintForPW����5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� *Text+$ TB_HintForPW�� �� Value  6Y   .a�5      �� 	 � y�$
 Visible=�6;   5      5      5      �� 5   
   -   5         ��Name$ BTT_OK��5      $��OK��6!   $
��Left=�6.   $��31��6I   $��
26,134,0,0q�6U   $	��Top=�6i   $��59��6�   6�   �� 5   
   -	   5        $ 
BTT_Cancel��5      $��Cancel��6%   $
��Left=�66   $��31��6Q   $��130,134,0,0q�6]   $	��Top=�6r   $��59��6�   6�   5      5       