using System;

namespace Enterprise.OA.Framework
{
    public interface IFacade<TKernel>
    {
        TResult Execute<TResult>(Func<TKernel, TResult> action);
    }
}
