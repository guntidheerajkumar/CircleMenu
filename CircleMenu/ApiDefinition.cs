using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CircleMenu
{
	// @interface KYCircleMenu : UIViewController
	[BaseType(typeof(UIViewController))]
	interface KYCircleMenu
	{
		// @property (nonatomic, strong) UIView * menu;
		[Export("menu", ArgumentSemantic.Strong)]
		UIView Menu { get; set; }

		// @property (nonatomic, strong) UIButton * centerButton;
		[Export("centerButton", ArgumentSemantic.Strong)]
		UIButton CenterButton { get; set; }

		// @property (assign, nonatomic) BOOL isOpening;
		[Export("isOpening")]
		bool IsOpening { get; set; }

		// @property (assign, nonatomic) BOOL isInProcessing;
		[Export("isInProcessing")]
		bool IsInProcessing { get; set; }

		// @property (assign, nonatomic) BOOL isClosed;
		[Export("isClosed")]
		bool IsClosed { get; set; }

		// -(instancetype)initWithButtonCount:(NSInteger)buttonCount menuSize:(CGFloat)menuSize buttonSize:(CGFloat)buttonSize buttonImageNameFormat:(NSString *)buttonImageNameFormat centerButtonSize:(CGFloat)centerButtonSize centerButtonImageName:(NSString *)centerButtonImageName centerButtonBackgroundImageName:(NSString *)centerButtonBackgroundImageName;
		[Export("initWithButtonCount:menuSize:buttonSize:buttonImageNameFormat:centerButtonSize:centerButtonImageName:centerButtonBackgroundImageName:")]
		IntPtr Constructor(nint buttonCount, nfloat menuSize, nfloat buttonSize, string buttonImageNameFormat, nfloat centerButtonSize, string centerButtonImageName, string centerButtonBackgroundImageName);

		// -(void)runButtonActions:(id)sender;
		[Export("runButtonActions:")]
		void RunButtonActions(NSObject sender);

		// -(void)pushViewController:(id)viewController;
		[Export("pushViewController:")]
		void PushViewController(NSObject viewController);

		// -(void)open;
		[Export("open")]
		void Open();

		// -(void)recoverToNormalStatus;
		[Export("recoverToNormalStatus")]
		void RecoverToNormalStatus();
	}
}
