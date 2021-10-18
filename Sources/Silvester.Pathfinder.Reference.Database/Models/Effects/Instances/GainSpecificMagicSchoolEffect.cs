using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificMagicSchoolEffect : Effect
    {
        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;
    }
}
