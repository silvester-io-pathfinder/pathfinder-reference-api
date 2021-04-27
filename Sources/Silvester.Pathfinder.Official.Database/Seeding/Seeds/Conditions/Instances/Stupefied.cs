using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Stupefied : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("a9bb8a46-7442-4480-b008-c706d7d4ef2f");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Stupefied",
                ConditionCategoryId = ConditionCategories.Instances.LoweredAbilities.ID,
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7577f633-3d1c-4a3d-a71b-6310daabf88e"), Type = Utilities.Text.TextBlockType.Text, Text = "Your thoughts and instincts are clouded. Stupefied always includes a value. You take a status penalty equal to this value on Intelligence-, Wisdom-, and Charisma-based checks and DCs, including Will saving throws, spell attack rolls, spell DCs, and skill checks that use these ability scores. Any time you attempt to Cast a Spell while stupefied, the spell is disrupted unless you succeed at a flat check with a DC equal to 5 + your stupefied value." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83fd1bb7-1466-4cb8-8eb9-3c14b5a90813"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
