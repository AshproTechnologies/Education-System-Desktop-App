   M S B A M L   `   `   `  ����  WpfControlKit(    "MultiEventCommand.Views.InfoDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Information��6@    � 
ResizeMode$ NoResize=�6T   $
��Auto��6k   $
��Auto��6x    � SizeToContent$ WidthAndHeight=�6�    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ 
ToolWindow=�6/   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��32��6   $��32��6    $��../Images/info.png��6+   $��2,0,0,0q�6G   �� 5      -   5         ��Name$ textblockMessage��5   %   $��0��6   $��	3,10,3,10q�6?   $
��Wrap=�6R   6h   5      �� 5   
   -   5         ��Name$ chkDontShow��5       $��1��6   	 d� IsThreeState	 .  $��8,10,0,4q�6J   .��6\   Dont Show this again6r   �� 5   
   -   5        $��3��5      $��Center=�6   $��60��6;   $��5q�6F   $��27��6�   ��6Q   �� *MergeCommand+��5      �� 5      $ 
Horizontal=�6   .+�5      �� $��../Images/OK.png��6   $��16��66   $��16��6B   �� 5      Ok6$   5      5      5      5      