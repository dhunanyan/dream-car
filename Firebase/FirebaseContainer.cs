﻿//using FireSharp;
//using FireSharp.Config;
//using FireSharp.Interfaces;
//using FireSharp.Response;
//using Microsoft.WindowsAzure.Storage.Blob;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System;

//namespace DreamCar.Firebase
//{
//    public class FirebaseCls
//    {

//        public async Task UpdateFireblob(CloudBlobContainer blobContainer)
//        {

//            try
//            {
//                IFirebaseConfig config = new FirebaseConfig
//                {
//                    AuthSecret = "Gg5t1fSLC0WWPVM1VMoNxlM29qO1s53dEso7Jrfp",
//                    BasePath = "https://ringtoneapp.firebaseio.com/"
//                };

//                IFirebaseClient client = new FirebaseClient(config);
//                var list = blobContainer.ListBlobs();
//                List<CloudBlockBlob> blobNames = list.OfType<CloudBlockBlob>().ToList();

//                // SET
//                var todo = new Todo();

//                List<Todo> todoList = new List<Todo>();
//                List<UploadDataModel> MetaList = new List<UploadDataModel>();
//                foreach (var blb in blobNames)
//                {
//                    blb.FetchAttributes();
//                    Todo td = new Todo();
//                    td.name = blb.Name;
//                    td.url = blb.Uri.AbsoluteUri.ToString();
//                    if (blb.Metadata.Values.Count > 0)
//                    {
//                        td.Category = blb.Metadata.Values.ElementAt(0);
//                        td.UserName = blb.Metadata.Values.ElementAt(1);
//                        td.Number = blb.Metadata.Values.ElementAt(2);
//                        td.Email = blb.Metadata.Values.ElementAt(3);
//                        td.Comments = blb.Metadata.Values.ElementAt(4);
//                    }
//                    todoList.Add(td);
//                }

//                SetResponse response = await client.SetAsync("Image/", ImageModal.i);
//            }
//            catch (Exception e)
//            {

//            }

//            //GET
//            //FirebaseResponse getresponse = await client.GetAsync("ringtones");
//            //List<Todo> gettodo = response.ResultAs<List<Todo>>(); //The response will contain the data being retreived
//        }
//    } 
//} 
 