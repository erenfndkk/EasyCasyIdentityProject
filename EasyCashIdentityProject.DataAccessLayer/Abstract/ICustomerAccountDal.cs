using EasyCashIdentityProject.EntityLayer.ConCceate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal : IGenericDal<CustomerAccount>
    {
        //CustomerAccount sınıfına özel bir method olursa buraya yazılacak
    }
}
