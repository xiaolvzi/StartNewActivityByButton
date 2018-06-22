package md5e53f2fa39114c3d42cb52edc3e670b16;


public class DataViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App67.DataViewHolder, App67", DataViewHolder.class, __md_methods);
	}


	public DataViewHolder ()
	{
		super ();
		if (getClass () == DataViewHolder.class)
			mono.android.TypeManager.Activate ("App67.DataViewHolder, App67", "", this, new java.lang.Object[] {  });
	}

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
