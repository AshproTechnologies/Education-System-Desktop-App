   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollButtonControlTemplate  �� 
TargetType ��Name �� CornerRadius ! ScrollViewerButtonBorderBrush % !ScrollViewerButtonBackgroundBrush  TransparentBrush ��Name 
� Center 
� GradientOrigin 
� RadiusY � Color � Offset	 �� Triggers
 P� Property P� Value ]� 
Conditions �� Property �� Value �� 
TargetName  ButtonHoverInnerBorderBrush �� Value �� Property # ButtonHoverInnerBackgroundBrush # ButtonHoverOuterBackgroundBrush  ButtonHoverOuterBorderBrush  ScrollButtonStyle �� 
TargetType 	 DefaultFontBrush 
 ControlStyleEmptyFocus $  MenuScrollingVisibilityConverter  RibbonScrollViewer �Name J� IsHitTestVisible ��Name �� CanContentScroll �� LineLeftCommand �� RelativeSource �� FallbackValue `� 	Converter `� ConverterParameter �� Path �� Stretch �� LineRightCommand  RibbonTabScrollViewer  MenuScrollViewer �� 	ClickMode  �� LineUpCommand! �� EndPoint" �� 
StartPoint# �� LineDownCommand  ScrollViewerStyle$ �� Triggers  ScrollViewerControlTemplate% � ColumnDefinitions& � RowDefinitions' �� CanHorizontallyScroll( �� CanVerticallyScroll) ��Name4   .System.Windows.Automation.AutomationProperties*    AutomationId+ � Cursor, �� ScrollableHeight- � Maximum. � Minimum*/ �� #ComputedVerticalScrollBarVisibility0 �� ViewportHeight1 �� ViewportSize2 � Value3 �� Mode4 �� ScrollableWidth5 �� Orientation,6 �� %ComputedHorizontalScrollBarVisibility7 �� ViewportWidth�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %<&  &	        &	 y    7   &	     &	 %    7  7  7  7  &	 �    7  7  7  7  &	 7    7  7  7  7  &	 �     &	 �!    �� 5      "  ��68   .R�5      �� $ border��6   $��1q�6   $ 2��61   #���  5      $
��Auto��6K   $��Stretch=�6Y   $��Stretch=�5      #���  6)   ._�5      �� $ border1��6   $
��Auto��6    #���  6.   $��1q�6_   $ 2��5	      #���  6    ._�5
   
   � $
��Auto��6   .+�5      �� $ 	rectangle��6   $��0��6)   $y�	Collapsed=�6=   ��5      
� 5      $ 0.503,1&�6$   $ 0.503,1&�65   $ 0.202Q�6N   .��5      � $ 	#7FFFFFFF��6   $ 0Q�61   � 5      $ 1Q�6   5      5      �� 5      $��Center=�6   $��Center=�6:   5      5   	   5      	 5      P� 5      
 �@J�IsMouseOver .  6'   P� 5      
 � {� .  65   ]� 5        5!   
   �� 5"       �@J�IsMouseOver . 6-   ./�5$   
   �� $ border1��6(   # �  6=    � ���� 5%   
   $ border1��6'   # �  6<    � ���� 5&   
   $ border��6'   # �  6;    � ���� 5'   
   $ border��6(   # �  6<    � ���� 5(   
   $ 	rectangle��6'    � y�$ Visible=�6>   5)   	   ]� 5*       5+   
   �� 5,       �@J�IsKeyboardFocusWithin . 67   ./�5.   
   �� $ border1��6(   # �  6=    � ���� 5/   
   $ border1��6'   # �  6<    � ���� 50   
   $ border��6'   # �  6;    � ���� 51   
   $ border��6(   # �  6<    � ��52   	   54      �� 55      " ��6$   .�56      ��  � ��8   6!   �� 57       � ��# � 	 6#   �� 58       �@�FocusVisualStyle# � 
 6)   59      l� 5:      6%   �� 5;      " ��6%   .�5<      ��  �@�OverridesDefaultStyle . 6.   �� 5=       �@+�IsFocusScope .  62   �� 5>       � �� 5?      �� 5@   
   "  ��6   .R�5A      � $
 Grid��6   #��z��6    . .+�5B      �� $! PART_ScrollContentPresenter��6H   #��z��6%   #��z��5C   %   #��z��6I   # z��5D   %    . 6[   �� 5E      #��Z 6   |�.  $
��Left=�5F   w   $��13��5G      $
��Auto��6&   $��Stretch=�64   8��  ��5F      ��  �� *TemplatedParent+y�5H      `� 5I      $ Visibility.Collapsed��6   8  $ 0��5J   ]   .1�5K      �� $+ %ComputedHorizontalScrollBarVisibility�5L       5K      �� *TemplatedParent+5L      �� 5M      $ HorizontalOffset�6N    6   �� *TemplatedParent+6N   �� 5N      $ ExtentWidth�6N    6   �� *TemplatedParent+6N   �� 5O      $ ViewportWidth�6N    6   �� *TemplatedParent+6N   5P      .��5R      F� 
���   �$
 Fill=�6"   $��0��6C   $��Center=�6W   $��0q�5S      $��Center=�6    $��3��6;   $��5��6E   "����        �@B @B �@B ����	��5R   1   Z� 5S   P   5T      �� 5U      #��Z 6   |�.  $��Right=�5V   w   $��13��5W      $
��Auto��6&   $��Stretch=�64   8�� ��5V      ��  �� *TemplatedParent+y�5X      `� 5Y      $ Visibility.Collapsed��6   8  $	 100��5Z   ]   .1�5[      �� $+ %ComputedHorizontalScrollBarVisibility�5\       5[      �� *TemplatedParent+5\      �� 5]      $ HorizontalOffset�6N    6   �� *TemplatedParent+6N   �� 5^      $ ExtentWidth�6N    6   �� *TemplatedParent+6N   �� 5_      $ ViewportWidth�6N    6   �� *TemplatedParent+6N   5`      .��5b      F� 
���   �$
 Fill=�6"   $��0��6C   $��Center=�6W   $��0q�5c      $��Center=�6    $��3��6;   $��5��6E   "����@B     �    @B �    ����	��5b   1   Z� 5c   P   5d      5e      5f      5h      �� 5i       � �� . 6)   �� 5j       � ��$
 Auto=�66   �� 5k       � ��$ Disabled=�64   �� 5l       � |� .  6"   5m      �� 5n      " ��6(   .�5o      ��  �@�OverridesDefaultStyle . 6.   �� 5p       �@+�IsFocusScope .  62   �� 5q       � �� 5r      �� 5s   
   "  ��6   .R�5t      � $
 Grid��6   #��z��6    . .+�5u      �� $! PART_ScrollContentPresenter��6H   #��z��6%   #��z��5v   %   #��z��6I   # z��5w   %    . 6[   �� 5x      #��Z 6   |�.  $
��Left=�5y   w   $��13��5z      $
��Auto��6&   $��Stretch=�64   8��  $��0,7,0,1q�6{   ��5y      ��  �� *TemplatedParent+y�5{      `� 5|      $ Visibility.Collapsed��6   8  $ 0��5}   ]   .1�5~      �� $+ %ComputedHorizontalScrollBarVisibility�5       5~      �� *TemplatedParent+5      �� 5�      $ HorizontalOffset�6N    6   �� *TemplatedParent+6N   �� 5�      $ ExtentWidth�6N    6   �� *TemplatedParent+6N   �� 5�      $ ViewportWidth�6N    6   �� *TemplatedParent+6N   5�      .��5�      F� 
���   �$
 Fill=�6"   $��0��6C   $��Center=�6W   $��0q�5�      $��Center=�6    $��3��6;   $��5��6E   "����        �@B @B �@B ����	��5�   1   Z� 5�   P   5�      �� 5�      #��Z 6   |�.  $��Right=�5�   w   $��13��5�      $
��Auto��6&   $��Stretch=�64   8�� $��0,7,0,1q�6{   ��5�      ��  �� *TemplatedParent+y�5�      `� 5�      $ Visibility.Collapsed��6   8  $	 100��5�   ]   .1�5�      �� $+ %ComputedHorizontalScrollBarVisibility�5�       5�      �� *TemplatedParent+5�      �� 5�      $ HorizontalOffset�6N    6   �� *TemplatedParent+6N   �� 5�      $ ExtentWidth�6N    6   �� *TemplatedParent+6N   �� 5�      $ ViewportWidth�6N    6   �� *TemplatedParent+6N   5�      .��5�      F� 
���   �$
 Fill=�6"   $��0��6C   $��Center=�6W   $��0q�5�      $��Center=�6    $��3��6;   $��5��6E   "����@B     �    @B �    ����	��5�   1   Z� 5�   P   5�      5�      5�      5�      �� 5�       � �� . 6)   �� 5�       � ��$
 Auto=�66   �� 5�       � ��$ Disabled=�64   �� 5�       � |� .  6"   5�      �� 5�      " ��6#   .�5�      ��  �@�OverridesDefaultStyle . 6.   �� 5�       �@+�IsFocusScope .  62   �� 5�       � �� 5�      �� 5�   
   "  ��6   .R�5�      � $
 Grid��6   #��z��6    . .+�5�      �� $! PART_ScrollContentPresenter��6H   #��z��6%   #��z��5�   %   #��z��6I   # z��5�   %    . 6[   �� 5�      $ Hover=�6   #��Z  6-   |�.  $��Stretch=�5�      $
��Auto��69   $��12��6F   $	��Top=�6R   8��  ��5�      ��  �� *TemplatedParent+y�5�      `� 5�      $ Visibility.Collapsed��6   8  $ 0��5�   ]   .1�5�      �� $) #ComputedVerticalScrollBarVisibility�6N    6   �� *TemplatedParent+6N   �� 5�      $ VerticalOffset�6N    6   �� *TemplatedParent+6N   �� 5�      $ ExtentHeight�6N    6   �� *TemplatedParent+6N   �� 5�      $ ViewportHeight�6N    6   �� *TemplatedParent+6N   5�      .��5�      F� $
 Fill=�6   $��0��66   $��Center=�6J   $��0q�6g   $��Center=�5�      $��5��60   $��3��6:   "����        �@B ����р�     	��5�   $   Z� ��5�      �� 5�      $! 0.5,1&�6(   $" 0.5,0&�69   ��5�      � $ 	#FF1A52AD��6%   $ 0Q�67   � 5�      $ 	#FF0F3168��6%   $ 1Q�67   5�      5�      5�      �� 5�      $ Hover=�6   #��Z# 6-   |�.  $��Stretch=�5�      $
��Auto��69   $��12��6F   $��Bottom=�6R   8�� ��5�      ��  �� *TemplatedParent+y�5�      `� 5�      $ Visibility.Collapsed��6   8  $	 100��5�   ]   .1�5�      �� $) #ComputedVerticalScrollBarVisibility�6N    6   �� *TemplatedParent+6N   �� 5�      $ VerticalOffset�6N    6   �� *TemplatedParent+6N   �� 5�      $ ExtentHeight�6N    6   �� *TemplatedParent+6N   �� 5�      $ ViewportHeight�6N    6   �� *TemplatedParent+6N   5�      .��5�      F� $
 Fill=�6   $��0��66   $��Center=�6J   $��0q�6g   $��Center=�5�      $��5��60   $��3��6:   "����        �@B @B р�     	��5�   $   Z� ��5�      �� 5�      $! 0.5,1&�6(   $" 0.5,0&�69   ��5�      � $ 	#FF1A52AD��6%   $ 0Q�67   � 5�      $ 	#FF0F3168��6%   $ 1Q�67   5�      5�      5�      5�      5�      5�      �� 5�       � �� . 6)   �� 5�       � ��$
 Auto=�66   �� 5�       � ��$ Disabled=�64   �� 5�       � |� .  6"   5�      �� 5�      " ��6$   $ 5�      P� 5�      
 � {� .  . �5�   
   ��  � ��# � ��6'   5�   	   .�5�      ��  � ��# �  6!   5�      �� 5�      "  ��68   .R�5�      �� #��z��6   #��z��69   ._�5�      � $
 Grid��6   #��z��6   % 5�   
   �� 5�      $��* �6   �� 5�      $
��Auto �6   & 5�   
   �� 5�      $��* �6   �� 5�      $
��Auto �6   .+�5�   
   �� $ Corner��6   $��1��6$   #��� ��64   $��1��5�      �� 5�   
   $! PART_ScrollContentPresenter��6!   # z��5�   !   ' .  ( .  #��z��5   !   #��z��6U   $��0��6y   #��z��5  !   $��0��6D   �� 5  
   $) PART_VerticalScrollBar��6   $* VerticalScrollBar��64   $+ Arrow��6j   $��1��5     #- z, 6$   $. 0Q�6Q   $��0��6]   #y�z/ 5     #1 z0 5     2 5     �� *VerticalOffset+$3 OneWay=� �� *TemplatedParent+5     �� 5  
   $) PART_HorizontalScrollBar��6   $* HorizontalScrollBar��66   $+ Arrow��5     $��0��6#   #- z4 63   $. 0Q�6_   $5 
Horizontal=�6k   $��1��5	     #y�z6 6!   #1 z7 5     2 5
     �� *HorizontalOffset+$3 OneWay=� �� *TemplatedParent+5     5  	   5     5     5     