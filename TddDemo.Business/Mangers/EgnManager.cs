using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TddDemo.Business.Results;
using TddDemo.Entities;

namespace TddDemo.Business
{
    public class EgnManager : IEgnDal
    {   //EGN:8011200561
        //     8 0 1 1 2 0 0 5 6 1  
        //     1 2 3 4 5 6 7 8 9 10-digit
        //All Digit is Valid! Return true success.
        #region Променливи
        private IEgnDal _egnDal;
        private Result _result;
        private EgnTools _egnTools;
        private Locations _locations;
        #endregion

        #region Конструктор
        public EgnManager(IEgnDal egnDal)
        {
            _egnDal = egnDal;
            _egnTools = new EgnTools();
            _locations = new Locations();
        }
        #endregion

        #region ЕГН Валидация
        public IResult AllDigitsIsValidate(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.errorDigit);
            if (egn.egn.Any() && egn.egn.All(c => Char.IsDigit(c)))
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        //Date is Valid! Return true success.
        public IResult DigitIsValid(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.errorDigit);
            if (egn.egn.Any() && egn.egn.All(c => Char.IsDigit(c)))
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        //LastDIgit 9 is Valid!  Return true success.
        //8011200561
        public IResult LastDigitIsValid(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.invalidLastDigit);
            _egnTools.Algoritam();
            int digit, sum = 0;
            for (int i = 0; i < egn.egn.Length - 1; i++)
            {
                digit = int.Parse(egn.egn.Substring(i, 1));
                sum += digit * _egnTools._Collection[i + 1];
            }

            digit = int.Parse(egn.egn.Substring(9, 1));
            bool success = ((sum - 11) % 11 == digit);

            if (success)
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        //Location is Valid!  Return true success. From Result, From DataResult return Data:"Бургас", Messege:success and boolean succes:true;
        //8011200561
        public IResult LocationIsValid(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.invalidLocation);
            int digit = int.Parse(egn.egn.Substring(6, 3));
            var regions = _locations.RegionsGenerate();
            var result = regions.SingleOrDefault(c => c.minValues <= digit && c.maxValues >= digit);
            if (result.Name.Length > 0)
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        //Lebgt is Valid!  Return true success. Lenght == 10 return boolean:succes:true  or return boolean:succes:false
        //EGN:8011200561
        //     8 0 1 1 2 0 0 5 6 1  
        //     1 2 3 4 5 6 7 8 9 10-digit
        public IResult LengthIsValid(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.lengthMinMax);
            if (egn.egn.Length == 10)
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        //Months is Valid!  Return true success. return boolean:succes:true  or return boolean:succes:false
        //EGN:8011200561
        //     8 0 1 1 2 0 0 5 6 1  
        //     1 2 3 4 5 6 7 8 9 10-digit
        public IResult MonthsIsValid(EgnPartsEntity egn)
        {
            int months = 0;
            bool success = int.TryParse(egn.egn.Substring(2, 2), out months)
                && egn.month == months;
            if (success && egn.month > 0 && egn.month < 13)
            {
                _result = new Result(true, Messages.success);
            }
            else
            {
                string date = string.Format("{0}/{1}/{2}", egn.egn.Substring(0, 2), egn.egn.Substring(2, 2), egn.egn.Substring(4, 2));
                months = int.Parse(egn.egn.Substring(2, 2));
                if (months > 0
                && months % 20 > 0
                && months % 20 < 13
                && months < 53) 
                {
                    _result = new Result(true, Messages.success);
                }
                else { _result = new Result(false, Messages.invalidMonth); }

            }
            return _result;
        }

        public IResult DayIsValid(EgnPartsEntity egn)
        {
            _result = new Result(false, Messages.lengthMinMax);
            bool result = egn.day > 0 && egn.day < 31;
            if (result)
            {
                _result = new Result(true, Messages.success);
            }
            return _result;
        }
        #endregion
    }
}