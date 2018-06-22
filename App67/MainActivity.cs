using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Views;
using System.Collections.Generic;
using System;

namespace App67
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView mListView;
        ChatRoomAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mListView = FindViewById<ListView>(Resource.Id.listview);
            List<string> list = new List<string> {
                "A","A","A","A","A","A","A",
            };
            adapter = new ChatRoomAdapter(this, list);
            mListView.Adapter = adapter;
        }


        class ChatRoomAdapter : BaseAdapter
        {
            Context mContext;
            List<string> mitems { get; set; }
            public ChatRoomAdapter(Context context, List<string> list)
            {
                this.mContext = context;
                this.mitems = list;

            }


            public override int Count
            {
                get
                {
                    return mitems.Count;
                }
            }
            

            public override Java.Lang.Object GetItem(int position)
            {
                return mitems[position];
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                DataViewHolder holder = null;
                if (convertView == null)
                {
                    convertView = LayoutInflater.From(mContext).Inflate(Resource.Layout.item_layout, null, false);
                    holder = new DataViewHolder();
                    holder.tv = convertView.FindViewById<TextView>(Resource.Id.tv);
                    holder.bt = convertView.FindViewById<Button>(Resource.Id.bt);
                    convertView.Tag = holder;
                }
                else
                {
                    holder = convertView.Tag as DataViewHolder;

                }


                // image button click event.
                holder.bt.Click += (sender, args) =>
                {
                    Android.App.AlertDialog.Builder alert1 = new Android.App.AlertDialog.Builder(mContext);
                    alert1.SetTitle("Message");
                    alert1.SetMessage("View Image / Download Image");
                    alert1.SetPositiveButton("Download", (senderAlert, args1) =>
                    {
                        // Download CODE
                    });
                    alert1.SetNegativeButton("View Image", (sender1, args2) =>
                    {
                        try
                        {
                            // here I wants to open a new activity.
                            var intent = new Intent(mContext, typeof(MyNewActivity));
                            mContext.StartActivity(intent);
                        }
                        catch (Exception ex)
                        {
                        }
                    });
                    Dialog dialog1 = alert1.Create();
                    dialog1.Show();
                };

                holder.tv.Text = mitems[position];


                return convertView;

            }

 
            
        }
    }

    public class DataViewHolder:Java.Lang.Object
    {

        public Button bt { get; set; }
        public TextView tv { get; set; }
    }
}

