using System;
using System.Collections.Generic;

namespace ASPLesson.Domain.Services.Services
{
    public enum ExpressionModel
    {
        NotNull = 0,
        Range = 1,
    }

    public interface IModelService
    {
        bool CheckModel<T>(ExpressionModel expression, T model);

        bool CheckModel<T>(Dictionary<string, ExpressionModel> parameters);
    }
    
    
    public class ModelService : IModelService
    {
        private bool IsModelValid {get; set; }

        public bool CheckModel<T>(ExpressionModel expression, T model)
        {
            var exp = model as string;
            switch (expression)
            {
                case ExpressionModel.NotNull:
                    if (!string.IsNullOrWhiteSpace(exp))
                        IsModelValid = true;
                    break;
            }
            return IsModelValid;
        }

        public bool CheckModel<T>(Dictionary<string, ExpressionModel> parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.Value)
                {
                    case ExpressionModel.NotNull:
                        if (string.IsNullOrWhiteSpace(parameter.Key))
                            return false;
                        else
                            IsModelValid = true;
                        continue;
                    case ExpressionModel.Range:
                        if (Convert.ToInt32(parameter.Key) < 0 || Convert.ToInt32(parameter.Key) > 130)
                            return false;
                        else
                            IsModelValid = true;
                        continue;
                }
            }
            return IsModelValid;
        }
    }
}