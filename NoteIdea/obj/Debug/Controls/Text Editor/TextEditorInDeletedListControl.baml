   M S B A M L   `   `   `  ����C  ?NoteIdea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:NoteIdeaNoteIdea  5      -    'NoteIdea.TextEditorInDeletedListControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:NoteIdea     5      .��5	      � .+�5
   
   ��   J� Effect  5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF959595��6#      	Direction$	 360Q�65      ShadowDepth$ 1Q�6E      RenderingBias$ Quality=�6U      
BlurRadius$ 10Q�6m      Opacity$	 0.3Q�6}   .+�5      ��    
DateBorder#���   6   ._�5      �  � ColumnDefinitions 5      �� 5      $
��auto �6+   �� 5      $
��auto �6+   �� 5      $
��auto �6+   �� 5      $
��auto �6+   �� 5      $��* �6+   .+�5      A�   StatusGreenBrush#���  6   $��10��6I   $��10��6T   $��Right=�6`   $��	20,10,0,0q�6|    K� ZIndex$ 2��6�   6�   �� 5      $��1��6     TextEditorDeletedButton#���  6-   .��5      �� $E��?/NoteIdea;component/Images/ButtonIcons/TextEditorIcons/undo.png��6!   5      �� 5!      $��4��6    $��
2019.01.02��60     Date#���  6B   $ 2��6a   6t   5#      5%      �� 5(        	NoteTitle#���  6   $ 1��6;   $*��$Tytuł notatki która jest edytowana��6L   �� 5+      -   5        	 ��Name$	 rTextBox��5+        
TextEditor#���  6,   �� 5.      $��	50 0 50 0q�6   $��40��6(   
�������
 �� CornerRadius$
 	0 0 10 10��6I   50      51      52      53      