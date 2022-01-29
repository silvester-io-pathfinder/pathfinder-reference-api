using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinToTheSpot : Template
    {
        public static readonly Guid ID = Guid.Parse("47ca9d35-78b6-4384-b3c0-3cf26184a9d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pin to the Spot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1076d6b7-fca8-4c3c-b871-92f761166b87"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a target within reach. If you hit and deal damage, the target is also restrained as if you had critically succeeded at an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eb101114-9a13-440a-93b6-67f4cae3519c"), Feats.Instances.ProvocatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9903b2e-1ae7-4384-86f7-80e3ff4532a8"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
