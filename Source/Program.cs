using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Threading;

namespace Source
{
    class Program
    {
        Task task;Task task1;
        static void Main(string[] args)
        {

            using (var context = new SourceModel())
            {
                context.StatusSet.Add(new Status{ Id=1,StatusStr= "выполнено" });
                context.StatusSet.Add(new Status { Id = 2, StatusStr = "не выполнено" });
                context.StatusSet.Add(new Status { Id = 3, StatusStr = "выполняется" });
                context.StatusSet.Add(new Status { Id = 4, StatusStr = "просроченно" });

                context.MessageSet.Add(new Message { Id = 1, Title = "Title", Text = "Предпринята попытка установить версию", CreateData = DateTime.Now });
                context.MessageSet.Add(new Message { Id = 2, Title = "Title2", Text = "Предпринята попытка установить версию 2", CreateData = DateTime.Now });

                context.DataDbSet.Add(new DataDb { Id = 1, To = "1", From = "2", MessageId = 1 });
                context.DataDbSet.Add(new DataDb { Id = 2, To = "2", From = "3", MessageId = 2 });
                context.DataDbSet.Add(new DataDb { Id = 3, To = "1", From = "2", MessageId = 2 });
                context.DataDbSet.Add(new DataDb { Id = 4, To = "3", From = "1", MessageId = 1 });
                Thread.Sleep(1500);
                
               
            }

        }

        public void Tasks()
        {
            using (var context = new SourceModel())
            {
                task = Task.Factory.StartNew(() =>context.MessageSet.ToList());
                task1 = Task.Factory.StartNew(() => context.DataDbSet.ToList());

               
            }


        }
        
    }
}
