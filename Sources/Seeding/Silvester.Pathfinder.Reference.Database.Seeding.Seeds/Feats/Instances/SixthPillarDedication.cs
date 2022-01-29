using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthPillarDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bfde807a-0298-4329-adcc-836d2906b5d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sixth Pillar Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Sixth Pillar archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1b6b570-19ab-447a-94d3-e4a733c5ef26"), Type = TextBlockType.Text, Text = $"You use your physical discipline to channel your magic. If your proficiency rank in unarmed attacks is at least expert, your proficiency rank in spell attacks increases to expert. Likewise, if your proficiency rank in spell attacks is at least expert, your proficiency rank in unarmed attacks improves to expert. You become an expert in Athletics, or in another trained skill if you were already expert in Athletics." };
            yield return new TextBlock { Id = Guid.Parse("f53c3735-dd95-4aec-ade6-ee41d9d2ff00"), Type = TextBlockType.Text, Text = $"__Manually improve your spell attacks and unarmed attacks proficiencies accordingly.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("d0fb9cfa-53cd-4aef-8fa1-de56378d305d"));
            builder.HaveSpecificStat(Guid.Parse("28f76f02-2e71-4937-8897-fcdbfec91953"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0b305d29-dbe3-4f71-b947-1e7d40d90a69"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2060ca6b-3b1c-435d-a189-d1c6f84b6193"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("7336ab9c-bfd5-48cb-bdff-460a99fb7aea"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d6ebe61-3820-4d94-b1ed-f64ba4f4e10b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
