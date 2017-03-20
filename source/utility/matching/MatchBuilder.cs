using System;

namespace code.utility.matching
{
    public class MatchBuilder<ItemToMatch, Property>
    {
        PropertyAccessor<ItemToMatch, Property> accessor;

        public MatchBuilder(PropertyAccessor<ItemToMatch, Property> property_accessor)
        {
            accessor = property_accessor;
        }

        public IMatchA<ItemToMatch> equal_to(Property property)
        {
            return new CriteriaMatch<ItemToMatch>(item => accessor(item).Equals(property));
        }

        public IMatchA<ItemToMatch> equal_to_any(params Property[] values)
        {
            return new CriteriaMatch<ItemToMatch>(item =>
            {
                foreach (var value in values)
                {
                    if (accessor(item).Equals(value))
                        return true;
                }

                return false;
            });
        }
    }
}