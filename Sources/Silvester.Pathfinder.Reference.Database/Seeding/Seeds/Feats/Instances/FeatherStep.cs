using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeatherStep : Template
    {
        public static readonly Guid ID = Guid.Parse("52d7b53a-19a9-4343-b606-f71833307aac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feather Step",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f519976-dcac-4034-9847-6e697afd6e1c"), Type = TextBlockType.Text, Text = "You step carefully and quickly. You can (Action: Step) into difficult terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("c2b56797-291a-4894-ac2d-251410408c99"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("734a1c73-e421-44a9-bc6c-f2b9ffda7ae7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
