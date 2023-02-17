using FluentValidation;

namespace ValidateSettings
{
    public class TestOptionsValidator : AbstractValidator<TestOptions>
    {
        public TestOptionsValidator()
        {
            RuleFor(x => x.LogLevel).IsEnumName(typeof(LogLevel));

            RuleFor(x => x.Retries).InclusiveBetween(1, 9);
        }
    }
}
