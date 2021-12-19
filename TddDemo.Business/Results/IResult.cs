using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddDemo.Entities;

namespace TddDemo.Business.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
      //  Messages ResultsMessage(EgnPartsEntity egn);
    }
}
