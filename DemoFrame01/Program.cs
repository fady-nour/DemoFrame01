using DemoFrame01.Context;
using Microsoft.EntityFrameworkCore;

namespace DemoFrame01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region demo

           
            #region Entitty frame work core
            /*
             ORM => object Rational mapper 
            support linq
            support multible DB 
            cross platform
            support migrations
            auto tracker
            disadvantges
            perfomance low (auto tracker)
            complexity 
             */

            #endregion
            #region Ado.net
            /*
             low level framee
            no migration 
            no tacking
            manual connection 
            direct acess with database

            disadvantdes
                 
             */
            #endregion
            #region Dapper
            /*
             * lightwight
             * simple api 
             * faster
             * easy to use
             no tracking and migrations
          micro orm
            limited features
            */
            #endregion
            #region Dbcontext
            //ComponeyDbcontext componeyDbcontext = new ComponeyDbcontext();
            //try
            //{

            //}
            //finally
            //{
            //    componeyDbcontext.Dispose();
            //}

            //using ComponeyDbcontext dbcontext = new ComponeyDbcontext();
            //dbcontext.Database.Migrate();
            //to apply migeatin must doenload package entity framework
            #endregion
            #endregion

            using ComponeyDbcontext dbcontext = new ComponeyDbcontext();
        }
    }
}
