using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //ProductManagerde Add operasyonunda return new SuccessResult("Ürün eklendi.");olması 
        public SuccessResult(string message) : base(true, message)
        {

        }
        //ProductManagerde Add operasyonunda return new SuccessResult();olması
        public SuccessResult() :base(true)//base içerisindeki paramatreyi Result'a gönderir. True değeri default değer olmuş oldu.
        {

        }
    }
}
