using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DivineFont : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Divine Font", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Through your deity's blessing, you gain additional spells that channel either the life force called positive energy or its counterforce, negative energy. When you prepare your spells each day, you can prepare additional heal or harm spells, depending on your deity. The divine font spell your deity provides is listed in the Divine Font entry for your deity; if both are listed, you can choose between heal or harm. Once you choose, you can't change your choice short of an ethical shift or divine intervention." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Example, Text = "Healing Font: You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only heal spells in these slots, and the number of slots is equal to 1 plus your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Example, Text = "Harmful Font: You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only harm spells in these slots, and the number of slots is equal to 1 plus your Charisma modifier." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainDeityDivineFont(Guid.Parse(""));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 119
            };
        }
    }
}
