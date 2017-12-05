using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Service
{
    public class MessageDBService
    {
        //實做資料庫模型
        public MvcApplication1.Models.messageEntities db = new Models.messageEntities();

        //此方法取得資料庫中，Article資料表並回傳
        public List<Article> GetData() {
            return db.Article.ToList();
        }

        //此方法將接收的資料存入資料庫
        public void DBCreate(String Article_title , String Content) { 
        
            //實做資料表
            Article NewData = new Article();
            NewData.Title = Article_title;//此變數用於儲存文章標題
            NewData.Content = Content;//此變數用於儲存內容標題
            NewData.time = DateTime.Now;//此變數儲存文章發表時間

            //新增一筆資料
            db.Article.Add(NewData);
            db.SaveChanges();
        }

    }
}