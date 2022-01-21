using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class Bloodline : Template
    {
        public static readonly Guid ID = Guid.Parse("3ae50514-fd00-4c2b-9da2-c16d3fe7c373");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Bloodline", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7763c0b7-93a5-4525-9b9e-3fe7758a9387"), Type = TextBlockType.Text, Text = "Choose a bloodline that gives you your spellcasting talent. This choice determines the type of spells you cast and the spell list you choose them from, additional spells you learn, and additional trained skills. You also gain Focus Points and special focus spells based on your bloodline." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBloodline(Guid.Parse("e5107e1a-071e-484f-9e4f-daca03bc445b"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bb2c03a-0f04-44d3-90ef-cbbb79097730"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 192
            };
        }
    }
}
