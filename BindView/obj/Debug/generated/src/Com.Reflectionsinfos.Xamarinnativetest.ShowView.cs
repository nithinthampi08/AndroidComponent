using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Reflectionsinfos.Xamarinnativetest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.reflectionsinfos.xamarinnativetest']/class[@name='ShowView']"
	[global::Android.Runtime.Register ("com/reflectionsinfos/xamarinnativetest/ShowView", DoNotGenerateAcw=true)]
	public partial class ShowView : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/reflectionsinfos/xamarinnativetest/ShowView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowView); }
		}

		protected ShowView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.reflectionsinfos.xamarinnativetest']/class[@name='ShowView']/constructor[@name='ShowView' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShowView ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShowView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
