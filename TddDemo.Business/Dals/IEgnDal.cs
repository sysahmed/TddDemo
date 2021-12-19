using System.Collections.Generic;
using TddDemo.Business.Results;
using TddDemo.Entities;

namespace TddDemo.Business
{
    //Data Access Layers
    public interface IEgnDal
    {
        IResult LengthIsValid(EgnPartsEntity egn);
        IResult AllDigitsIsValidate(EgnPartsEntity egn);
        IResult MonthsIsValid(EgnPartsEntity egn);
        IResult DayIsValid(EgnPartsEntity egn);
        IResult LastDigitIsValid(EgnPartsEntity egn);
        IResult DigitIsValid(EgnPartsEntity egn);
        IResult LocationIsValid(EgnPartsEntity egn);
    }
}
