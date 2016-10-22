using System;

namespace Enterprise.OA.Framework
{
    public abstract class FacadeBase<TKernel> : IFacade<TKernel>
    {
        private readonly Func<TKernel> _kernelAccessor;

        protected FacadeBase(Func<TKernel> kernelAccessor)
        {
            if(kernelAccessor == null)
            {
                throw new ArgumentNullException(nameof(kernelAccessor));
            }

            _kernelAccessor = kernelAccessor;
        }

        protected virtual TKernel Kernel
        {
            get { return _kernelAccessor.Invoke(); }
        }

        public TResult Execute<TResult>(Func<TKernel, TResult> action)
        {
            return action.Invoke(Kernel);
        }
    }
}
