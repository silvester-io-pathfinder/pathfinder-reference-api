using System;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Searching.Models
{
    public class SearchResult
    {
        public Guid Id { get;  }

        public string Name { get; }

        public string Type { get; }

        public SearchResult(Guid id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type.GetDisplayString();
        }
    }

    public static class StringExtensions
    {
        public static string GetDisplayString(this string type)
        {
            if(type.Contains(" "))
            {
                //Nasty idempotence implementation.
                return type;
            }

            string result = "";
            for(int i = 0; i < type.Length; i ++)
            {
                char current = type[i];
                if(char.IsUpper(current) && i != 0)
                {
                    result += " ";
                }
                
                result += current;
            }
            return result;
        }
    }
}
