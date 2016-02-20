using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthApp.Models
{
    public class ContextInitializer: DropCreateDatabaseAlways<ApplicationContext>
    {
    }
}