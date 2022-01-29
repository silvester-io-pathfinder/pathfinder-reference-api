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
    public class HirelingManager : Template
    {
        public static readonly Guid ID = Guid.Parse("2ddcfa89-70b1-461e-a04a-417391433353");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hireling Manager",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04a2b6b8-5b28-4a26-b5ba-4c9ad109ccdd"), Type = TextBlockType.Text, Text = $"You are able to find and secure better labor than most. When securing a hireling for a service, that hireling gains a bonus applies to both trained and untrained hirelings and has no effect on the cost of the service or labor provided." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("1bd62df4-1163-44a9-89a9-f7101be66824"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5f099651-50a5-469c-9fcd-cd6b82b45e31"), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14e699ce-6abd-4b44-b048-4813aa5b35bb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
