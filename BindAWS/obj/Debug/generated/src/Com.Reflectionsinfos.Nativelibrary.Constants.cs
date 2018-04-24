using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Reflectionsinfos.Nativelibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/reflectionsinfos/nativelibrary/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/field[@name='BUCKET_NAME']"
		[Register ("BUCKET_NAME")]
		public const string BucketName = (string) "businessdebatedevbucketone";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/field[@name='BUCKET_REGION']"
		[Register ("BUCKET_REGION")]
		public const string BucketRegion = (string) "us-east-1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/field[@name='BUCKET_UPLOADED_PATH']"
		[Register ("BUCKET_UPLOADED_PATH")]
		public const string BucketUploadedPath = (string) "https://s3.amazonaws.com/businessdebatedevbucketone/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/field[@name='COGNITO_POOL_ID']"
		[Register ("COGNITO_POOL_ID")]
		public const string CognitoPoolId = (string) "us-east-1:705270dc-eeed-46f7-b6cd-d868e0dd858a";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/field[@name='COGNITO_POOL_REGION']"
		[Register ("COGNITO_POOL_REGION")]
		public const string CognitoPoolRegion = (string) "us-east-1";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/reflectionsinfos/nativelibrary/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Constants)) {
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
