using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("3fd5bfeb-e79c-40ff-8e41-c54683461e7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Distraction",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40ffbeb2-5b76-45e7-812b-f6460f5c75c8"), Type = TextBlockType.Text, Text = $"Your movements with two weapons are so swift and disorienting that they befuddle your opponent. When using {ToMarkdownLink<Models.Entities.Feat>("Twin Feint", Feats.Instances.TwinFeint.ID)}, if both your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} deal damage to a targeted creature, the target must succeed at a Will saving throw against your class DC or become stupefied 1 until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90d50377-bdd3-41d3-8467-342d111206d8"), Feats.Instances.TwinFeint.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("442d35d0-beab-49ff-9582-29d6f02d0e81"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
