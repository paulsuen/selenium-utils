﻿using Riganti.Selenium.Core.Abstractions;
using Riganti.Selenium.Core.Abstractions.Exceptions;
using Riganti.Selenium.Validators.Checkers;

namespace Riganti.Selenium.Core.Api
{
    public abstract class OperationRunnerBase<T> : IOperationRunner<T> where T : ISupportedByValidator
    {
        private readonly OperationResultValidator operationResultValidator = new OperationResultValidator();

        protected void EvaluateResult<TException>(CheckResult checkResult)
            where TException : TestExceptionBase, new()
        {
            operationResultValidator.Validate<TException>(checkResult);
        }

        public abstract void Evaluate<TException>(IValidator<T> validator) where TException : TestExceptionBase, new() ;
    }
}