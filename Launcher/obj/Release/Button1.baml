   M S B A M L   `   `   `  ����   Launcher    Launcher.Button1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     >�Name$  UserControl�� � 	Resources    OnMouseLeftButtonDown1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OnMouseLeftButtonUp1  OnMouseEnter  OnMouseLeave2��%�	  &	        &	 Y     &	 �     &	 &    �� .��U� $ (Shape.StrokeThickness)�$ 	rectangle��.\�  $ 0:0:0.1��$ 2Q��� .��U� $ (Shape.StrokeThickness)�$ 	rectangle��.\�  $ 0��$ 2Q�  $ 0:0:0.3��$ 1Q��� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ 
LayoutRoot��.\�  $ 0:0:0.2��$ 1.019Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ 
LayoutRoot��.\�  $ 0:0:0.2��$ 1.062Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 
LayoutRoot��.\�  $ 0:0:0.2��$	 1.5Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ 
LayoutRoot��.\�  $ 0:0:0.2��$	 1.5Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 grid��.\�  $ 0:0:0.2��$ 1.007Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 grid��.\�  $ 0:0:0.2��$
 0.98Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 grid��.\�  $ 0:0:0.2��$ 0.491Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 grid��.\�  $ 0:0:0.2��$ -0.47Q��� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 grid��.\�  $ 0:0:0.4��$ 1.046Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 grid��.\�  $ 0:0:0.4��$ 1.115Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 grid��.\�  $ 0:0:0.4��$ 3.615Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 grid��.\�  $ 0:0:0.4��$ 2.772Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ 
LayoutRoot��.\�  $ 0:0:0.4��$ 0.956Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ 
LayoutRoot��.\�  $ 0:0:0.4��$ 0.917Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 
LayoutRoot��.\�  $ 0:0:0.4��$
 -3.5Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ 
LayoutRoot��.\�  $ 0:0:0.4��$ -2Q� � Triggers :�  :� RoutedEvent$ Mouse.MouseEnter��.[��� -    ��Name$, &OnMouseLeftButtonDown1_BeginStoryboard��#��[ :� $ Mouse.MouseLeave��.[��� -   $# OnMouseLeave2_BeginStoryboard��#��[ :� $# UIElement.MouseLeftButtonDown��.[��� -   $- 'OnMouseLeftButtonDown1_BeginStoryboard1��#��[  :� $! UIElement.MouseLeftButtonUp��.[��� -   $* $OnMouseLeftButtonUp1_BeginStoryboard��#��[ .��� -   	 �Name$	 
LayoutRoot��
 J� RenderTransformOrigin$
 0.5,0.5&�z�V� .~��� �� �� T� .+�� -   $
	 grid��$
 0.5,0.5&�z�V� .~��� �� �� T� .+��� -    ��Name$ 	rectangle�����	#FF518ED2���	#FFF4F4F5 �� RadiusY$	 3.5�� �� RadiusX$	 3.5��$
 0.5,0.5&�$��48��$��Bottom=�z�V� .~��� �� �� T� �� -	   $��Button1Image��$��3,4,0,4q�$
��Left=�$��45��$��Logo.ico���� -
   $��Button1Label��$��Age Bot��$��45,6,8,6q�$��21.333(�$��Elephant)����	#00C41E1E