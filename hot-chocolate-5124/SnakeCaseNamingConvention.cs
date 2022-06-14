using HotChocolate.Types.Descriptors;
using System.Reflection;
using System.Text.RegularExpressions;

namespace hot_chocolate_5124
{
    public class SnakeCaseNamingConvention : DefaultNamingConventions
    {
        public override NameString GetMemberName(MemberInfo member, MemberKind kind)
        {
            if (kind == MemberKind.ObjectField)
            {
                var pattern = new Regex(@"[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+");
                return string.Join("_", pattern.Matches(member.Name)).ToLower();
            }

            return base.GetMemberName(member, kind);
        }
    }
}
