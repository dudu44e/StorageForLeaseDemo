   M S B A M L   `   `   `  ����J  FStorageForLease, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:StorageForLeaseStorageForLease  5   	       StorageForLease.Main   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:StorageForLease     5   	     � Title$
  Main��5   	   $	��450��6   $	��500��6#   
����  � � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 0q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   $	��164��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?    � �� �#EAB01E6S   �� 51   "   $ border��6@    � �� �#EAB01E6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?    � �� �#F1CA686S   �� 55   "   $ border��6@    � �� �#F1CA686T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8   � ��6i   5;      5=      5?      5@      5A      .��5C      �� 
�������$
 20��6    $��30q�62   ._�5E   
   �� $��20q�6   .+�5F      �� $��Welcome to Storage4Lease��6   
���   �$��Center=�5H      $��25(�5I      $��Broadway)�5J      5K      �� 5M      6   �� 5N      $��Sign up��6   $��Center=�6&   $��5 20 0 5q�6C   $��18(�6U   
���   �$��Palatino Linotype)�6v   6�   �� 5O       �� Orientation$ 
Horizontal=�6   .+�5P      �� -   5         ��Name$ CustomerSignup��5P   A   #��� 
 6   $��30��5Q      ���	#FF44C9B5$��Blackadder ITC)�5S      $��UltraCondensed&�5T      $��Customer Sign up��5U      $��
20 20 20 0q�5W      �� 5X      -   5        $ ManagerSignup��5X   A   #��� 
 6   $��30��5Y      ���	#FF44C9B5$��Blackadder ITC)�5[      $��UltraCondensed&�5\      $��Manager Sign up��5]      $��
20 20 60 0q�5^      5_      5a      �� 5b      $��Log In��6   $��Center=�6%   $��Palatino Linotype)�6B   $��5 20 0 5q�6a   $��18(�6s   
���   �$��86��6�   6�   �� 5c      $ 
Horizontal=�6   .+�5d      �� -   5        $ CustomerLogin��5d   A   #��� 
 6   $��30��5e      ���	#FF44C9B5$��Blackadder ITC)�5g      $��UltraCondensed&�5h      $��CustomerLog in��5i      $��
20 20 20 0q�5k      �� 5l      -   5        $ ManagerLogin��5l   A   #��� 
 6   $��30��5m      ���	#FF44C9B5$��Blackadder ITC)�5o      $��UltraCondensed&�5p      $��Manager Log in��5q      $��
20 20 60 0q�5s      5t      5u      5v      5w      