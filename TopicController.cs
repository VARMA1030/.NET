using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Eventbal;
using Eventdal;
using EventAPI.Models;
using System.Data;
using System.Web.Http.Cors;

namespace EventAPI.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TopicController : ApiController
    {
        // GET: api/Inserttopic
        public List<TopicModel> Get()
        {
           Topicdal dal = new Topicdal();
            DataTable dt = new DataTable();
            dt = dal.showTopics();
            List<TopicModel> list = new List<TopicModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TopicModel tm = new TopicModel();
                tm.Topicid = Convert.ToInt32(dt.Rows[i][0]);
                tm.Topicname = Convert.ToString(dt.Rows[i][1]);
                tm.Topicdesc = Convert.ToString(dt.Rows[i][2]);
                tm.Category = Convert.ToString(dt.Rows[i][3]);
                tm.Price = Convert.ToSingle(dt.Rows[i][4]);
                tm.Eventname = Convert.ToString(dt.Rows[i][5]);
                list.Add(tm);
            }
            return list;

        }

        // GET: api/Inserttopic/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inserttopic
        public void Post(TopicModel tm)
        {
            Topicdal dal = new Topicdal();
            Topic t = new Topic();
            t.Topicname = tm.Topicname;
            t.Topicdesc = tm.Topicdesc;
            t.Category = tm.Category;
            t.Price = tm.Price;
            t.Eventname = tm.Eventname;
            dal.insertTopic(t);

        }

        // PUT: api/Inserttopic/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Inserttopic/5
        public void Delete(int id)
        {
        }
    }
}
