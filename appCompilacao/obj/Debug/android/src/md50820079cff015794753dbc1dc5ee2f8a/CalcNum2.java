package md50820079cff015794753dbc1dc5ee2f8a;


public class CalcNum2
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("appCompilacao.CalcNum2, appCompilacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CalcNum2.class, __md_methods);
	}


	public CalcNum2 ()
	{
		super ();
		if (getClass () == CalcNum2.class)
			mono.android.TypeManager.Activate ("appCompilacao.CalcNum2, appCompilacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
