using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HL7MessageViewer
{
    public class Hl7ApiController : ApiController
    {
        public long Get(long messageid)
        {
            return messageid;
        }

        public MyHL7Segment[] Get(string url)
        {
            MyHL7Segment[] segments = new MyHL7Segment[]
            {
                new MyHL7Segment{
                    Title = "MHS",
                    Fields = new Field[] 
                    {
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        }
                    }
                },
                new MyHL7Segment{
                    Title = "EVN",
                    Fields = new Field[] 
                    {
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        }
                    }
                },
                new MyHL7Segment{
                    Title = "PV1",
                    Fields = new Field[] 
                    {
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        },
                        new Field
                        {
                            Id = "1",
                            Key = "Key",
                            Value = "Value"
                        }
                    }
                }
            };

            return segments;
        }

        public string[] GetMessagesByPasID(string server, string ns, string pasid)
        {
            Random r = new Random();
            var id = new string[100];
            for (int i = 0; i < 100; i++)
            {
                id[i] = r.Next().ToString();
            }

            return id;
        }
    }

    public class MyHL7Segment
    {
        public string Title { get; set; }

        public Field[] Fields { get; set; }
    }

    public class Field
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}