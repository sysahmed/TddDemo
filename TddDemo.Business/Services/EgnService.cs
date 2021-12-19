using TddDemo.Business.Results;
using TddDemo.Entities;

namespace TddDemo.Business.Services
{
    public class EgnService 
    {
        IEgnDal _egnDal;
        Result result;
        public EgnService(IEgnDal egnDal)
        {
            _egnDal = egnDal;
            result = new Result(true,Messages.success);
        }
        public IResult ResultsMessage(EgnPartsEntity egn)
        {
           string veriler= _egnDal.LengthIsValid(egn).Message;
            //if (!r) result= new Result(false, Messages.lengthMinMax);
           
            return result;
        }
    }
}
