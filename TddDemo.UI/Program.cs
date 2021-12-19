using Moq;
using System;
using System.Text;
using TddDemo.Business;
using TddDemo.Business.Results;
using TddDemo.Entities;

namespace TddDemo.UI
{
    internal class Program
    {


        static void Main(string[] args)
        {
            IResult result = ValidateEgn();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(result.Message);
            Console.ReadLine();
        }

        private static IResult ValidateEgn()
        {
            Mock<IEgnDal> _mockEgnDal = new Mock<IEgnDal>(); ;
            EgnPartsEntity _dbEgns;

            string _egn = Console.ReadLine(); IEgnDal egnManger = new EgnManager(_mockEgnDal.Object);

            _dbEgns = new EgnPartsEntity { egn = _egn };
            if (!egnManger.LengthIsValid(_dbEgns).Success) return egnManger.LengthIsValid(_dbEgns);
            if (!egnManger.AllDigitsIsValidate(_dbEgns).Success) return egnManger.AllDigitsIsValidate(_dbEgns);
            if (!egnManger.MonthsIsValid(_dbEgns).Success) return egnManger.MonthsIsValid(_dbEgns);
            if (!egnManger.DayIsValid(_dbEgns).Success) return egnManger.DayIsValid(_dbEgns);
            if (!egnManger.LastDigitIsValid(_dbEgns).Success) return egnManger.LastDigitIsValid(_dbEgns);
            if (!egnManger.LocationIsValid(_dbEgns).Success) return egnManger.LocationIsValid(_dbEgns);
            return new Result(true, Messages.success);
        }
    }
}
