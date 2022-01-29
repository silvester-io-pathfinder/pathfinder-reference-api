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
    public class PinpointPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("5580e418-8a17-4ecb-bdbf-c739c59186f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pinpoint Poisoner",
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
            yield return new TextBlock { Id = Guid.Parse("d70febd8-f8a0-4c36-abe3-1ccf8ef54a2e"), Type = TextBlockType.Text, Text = $"Unsuspecting targets are especially vulnerable to your poisons. When you successfully {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a flat-footed creature with a poisoned weapon or expose a flat-footed creature to an {ToMarkdownLink<Models.Entities.Trait>("inhaled", Traits.Instances.Inhaled.ID)} poison, the flat-footed condition also gives that creature a -2 circumstance penalty to its initial save against that poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bf3a3c85-e7cb-4431-a2fa-e9f17f6a49d0"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c7969de-21e3-479e-b69c-3cfd7eef038b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
