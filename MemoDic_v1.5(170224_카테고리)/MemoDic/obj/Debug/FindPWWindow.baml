   M S B A M L   `   `   `  ����B  >MemoDic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MemoDicMemoDic  5   	       MemoDic.FindPWWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MemoDic     5   	     � Title$  Find PW��5   	   $��155.769��6   $	��225��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ BTT_OK��5
      $��OK��6!   $
��Left=�6.   $��31��6I   $��	24,68,0,0q�6U   $	��Top=�6h   $��59��6�   6�   �� 5   
   -   5        $ 
BTT_Cancel��5      $��Cancel��6%   $
��Left=�66   $��31��6Q   $��
131,68,0,0q�6]   $	��Top=�6q   $��59��6�   6�   �� 5   
   -   5         ��Name$ TB_ID��5      $
��Left=�6!   $��23��6<   $��	43,24,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��124��6�    �� 	MaxLength$ 10��6�   �� 5   
    J� IsHitTestVisible .  $	�� ID��6-   $	��Top=�68   $
��Left=�6P   
���������6k   �� *Margin+ �� ElementName$ TB_ID����5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y�	 �� Value$	 	Collapsed=�63   
 �� Triggers
 5      �� 5       �� Binding 6&   �� *Text+$ TB_ID�� �� Value  6R   .a�5      ��  � y�$	 Visible=�6;   5      5      5      5      5      