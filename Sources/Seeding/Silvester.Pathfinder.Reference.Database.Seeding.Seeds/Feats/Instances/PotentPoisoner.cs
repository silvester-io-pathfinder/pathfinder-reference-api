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
    public class PotentPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("6372efd8-021e-4283-883c-385b3b37916c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Potent Poisoner",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01d98e2e-a9b4-4922-b3cb-751f09fe499b"), Type = TextBlockType.Text, Text = $"By concentrating your poisons' toxic components, you make them harder for victims to resist. When you craft an alchemical item with the {ToMarkdownLink<Models.Entities.Trait>("poison", Traits.Instances.Poison.ID)} trait by any means, the DC is increased by up to 4, to a maximum of your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("31a38338-dd60-4dbb-9ca1-47f31859ea0f"), ClassFeatures.Alchemists.PowerfulAlchemy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2876312-f191-4799-9415-c28e293f8cae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
