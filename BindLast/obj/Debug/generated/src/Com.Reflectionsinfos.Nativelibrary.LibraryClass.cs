using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Reflectionsinfos.Nativelibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']"
	[global::Android.Runtime.Register ("com/reflectionsinfos/nativelibrary/LibraryClass", DoNotGenerateAcw=true)]
	public partial class LibraryClass : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/reflectionsinfos/nativelibrary/LibraryClass", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LibraryClass); }
		}

		protected LibraryClass (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']/constructor[@name='LibraryClass' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibraryClass ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LibraryClass)) {
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

		static Delegate cb_openCamera_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOpenCamera_Landroid_content_Context_Handler ()
		{
			if (cb_openCamera_Landroid_content_Context_ == null)
				cb_openCamera_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OpenCamera_Landroid_content_Context_);
			return cb_openCamera_Landroid_content_Context_;
		}

		static void n_OpenCamera_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Reflectionsinfos.Nativelibrary.LibraryClass __this = global::Java.Lang.Object.GetObject<global::Com.Reflectionsinfos.Nativelibrary.LibraryClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openCamera_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']/method[@name='openCamera' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("openCamera", "(Landroid/content/Context;)V", "GetOpenCamera_Landroid_content_Context_Handler")]
		public virtual unsafe void OpenCamera (global::Android.Content.Context p0)
		{
			if (id_openCamera_Landroid_content_Context_ == IntPtr.Zero)
				id_openCamera_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "openCamera", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openCamera_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openCamera", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openGallery_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOpenGallery_Landroid_content_Context_Handler ()
		{
			if (cb_openGallery_Landroid_content_Context_ == null)
				cb_openGallery_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OpenGallery_Landroid_content_Context_);
			return cb_openGallery_Landroid_content_Context_;
		}

		static void n_OpenGallery_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Reflectionsinfos.Nativelibrary.LibraryClass __this = global::Java.Lang.Object.GetObject<global::Com.Reflectionsinfos.Nativelibrary.LibraryClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenGallery (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openGallery_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']/method[@name='openGallery' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("openGallery", "(Landroid/content/Context;)V", "GetOpenGallery_Landroid_content_Context_Handler")]
		public virtual unsafe void OpenGallery (global::Android.Content.Context p0)
		{
			if (id_openGallery_Landroid_content_Context_ == IntPtr.Zero)
				id_openGallery_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "openGallery", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openGallery_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openGallery", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openView_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenView_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_openView_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_openView_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenView_Landroid_content_Context_Ljava_lang_String_);
			return cb_openView_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_OpenView_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Reflectionsinfos.Nativelibrary.LibraryClass __this = global::Java.Lang.Object.GetObject<global::Com.Reflectionsinfos.Nativelibrary.LibraryClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OpenView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openView_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']/method[@name='openView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("openView", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOpenView_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void OpenView (global::Android.Content.Context p0, string p1)
		{
			if (id_openView_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_openView_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openView", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openView_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openView", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_returnMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReturnMessage_Ljava_lang_String_Handler ()
		{
			if (cb_returnMessage_Ljava_lang_String_ == null)
				cb_returnMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReturnMessage_Ljava_lang_String_);
			return cb_returnMessage_Ljava_lang_String_;
		}

		static IntPtr n_ReturnMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Reflectionsinfos.Nativelibrary.LibraryClass __this = global::Java.Lang.Object.GetObject<global::Com.Reflectionsinfos.Nativelibrary.LibraryClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReturnMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_returnMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.reflectionsinfos.nativelibrary']/class[@name='LibraryClass']/method[@name='returnMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("returnMessage", "(Ljava/lang/String;)Ljava/lang/String;", "GetReturnMessage_Ljava_lang_String_Handler")]
		public virtual unsafe string ReturnMessage (string p0)
		{
			if (id_returnMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_returnMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "returnMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_returnMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "returnMessage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
