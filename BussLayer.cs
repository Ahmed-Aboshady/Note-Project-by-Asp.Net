using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Note_Project
{
    public class BussLayer
    {
        //getallnote
        public static DataTable getall()
        {
            return dblayer.select(new SqlCommand("select * from note"));
        }
        //getallwriter
        public static DataTable getallwriter()
        {
            return dblayer.select(new SqlCommand("select * from writer"));
        }
        //getallcatelogs
        public static DataTable getallcat()
        {
            return dblayer.select(new SqlCommand("select * from catalogs"));
        }
        public static DataTable getallorderdate()
        {
            return dblayer.select(new SqlCommand("select n.title,n.bref,n.describe,n.datatime,c.name,w.name  from catalogs c  inner join note n on c.id=n.cid and c.id=@id inner join writer w on w.id=n.userid order by n.datatime"));
        }
        //getbyname catalogs
        public static DataTable getByName(string name)
        {
            return dblayer.select(new SqlCommand($"select * from catalogs where name='{name}'"));

        }
        //getbyname writer
        public static DataTable writerByName(string name)
        {
            return dblayer.select(new SqlCommand($"select * from writer where name='{name}'"));

        }

        //get student by noteid

        public static DataTable getBydept(int catid)
        {
            return dblayer.select(new SqlCommand($"select * from note where cid={catid}"));
        }
        public static DataTable getByuser(int userid)
        {
            return dblayer.select(new SqlCommand($"select * from note where cid={userid}"));
        }
        //get note by id
        public static DataTable getByID(int id)
        {
            return dblayer.select(new SqlCommand($"select * from note where id={id}"));
        }
        //edit
        public static int edit(int id, string title , string bref, string desc, int data, int cid,int user)
        {
            return dblayer.DML(new SqlCommand($"update note set title='{title}' ,bref={bref} ,describe='{desc}' ,datatime={data},cid='{cid}',userid={user} where id={id}"));
        }

        //delete
        public static int delete(int id)
        {
            return dblayer.DML(new SqlCommand($"delete from note where id={id}"));
        }

        //add
        public static int add(string title, string bref, string desc, int data, int cid,int user)
        {
            return dblayer.DML(new SqlCommand($"insert into note (title ,bref,describe ,datatime,cid,userid) values('{title}',{bref} ,'{desc}',{data} ,'{cid}' ,'{user}')"));
        }
       
        //udatepasswordwriter
        public static int editpass(int id, int pass)
        {
            return dblayer.DML(new SqlCommand($"update writer set password='{pass}' where id={id} "));
        }
    }
}