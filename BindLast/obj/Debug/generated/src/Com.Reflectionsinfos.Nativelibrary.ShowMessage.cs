using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Reflectionsinfos.Nativelibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='ShowMessage']"
	[global::Android.Runtime.Register ("com/reflectionsinfos/nativelibrary/ShowMessage", DoNotGenerateAcw=true)]
	public partial class ShowMessage : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/reflectionsinfos/nativelibrary/ShowMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowMessage); }
		}

		protected ShowMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='ShowMessage']/constructor[@name='ShowMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShowMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShowMessage)) {
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
