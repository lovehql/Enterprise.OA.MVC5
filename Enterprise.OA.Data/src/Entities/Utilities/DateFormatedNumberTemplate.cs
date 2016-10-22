using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class DateFormatedNumberTemplate : NumberTemplate
    {
        public const string defaultTemplate = "DefaultTemplate";

        public string ResetCriterion { get; set; }

        public virtual ICollection<DateFormatedNumberInstance> Instances { get; set; }
        
        /// <summary>
        /// default template
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string Generate(string prefix)
        {
            return Generate(defaultTemplate, prefix);
        }
        
        /// <summary>
        /// custom template
        /// </summary>
        /// <param name="key"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string Generate(string key, string prefix)
        {
            prefix = string.IsNullOrWhiteSpace(prefix) ? string.Empty : prefix;

            return string.Empty;

            //return UnitOfWork.Transact<string>(
            //    context =>
            //    {
            //        var template = context.QuerySingle<DateFormattedNumberTemplate>(x => x.Number == key);

            //        if (template == null)
            //        {
            //            throw new InvalidOperationException(Resources.NumberTemplateNotFoundException);
            //        }

            //        var numberInstance = context.QuerySingleDateFormattedNumberInstance(key, prefix);

            //        if (numberInstance == null)
            //        {
            //            numberInstance = new DateFormattedNumberInstance()
            //            {
            //                Template = template,
            //                Prefix = prefix,
            //                Seed = template.Seed,
            //                LastGenerateDate = DateTime.Now
            //            };

            //            context.Add(numberInstance);
            //        }
            //        else
            //        {
            //            DateTime lastGeneratedDate = numberInstance.LastGenerateDate; numberInstance.LastGenerateDate = DateTime.Now;

            //            if (string.Format(template.ResetCriterion, numberInstance.LastGenerateDate) == string.Format(template.ResetCriterion, lastGeneratedDate))
            //            {
            //                numberInstance.Seed++;
            //            }
            //            else
            //            {
            //                numberInstance.Seed = template.Seed;
            //            }

            //            context.Update(numberInstance);
            //        }

            //        return string.Format(template.Body, numberInstance.Prefix, numberInstance.LastGenerateDate, numberInstance.Seed);
            //    });
        }
    }
}
