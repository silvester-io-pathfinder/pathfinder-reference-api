using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MixedManeuver : Template
    {
        public static readonly Guid ID = Guid.Parse("cf5e10d4-f89b-4d17-908d-20ed88ca1f10");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mixed Maneuver",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd47b0a6-2cb0-47f3-9188-baba59c4d270"), Type = TextBlockType.Text, Text = "You combine two different maneuvers together into a single flowing whole. Choose any two of (action: Grapple), (action: Shove), and (action: Trip). Attempt both of the attacks you chose against the same or different creatures, but don’t apply the multiple attack penalty until after resolving both attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("08c485e8-bb3c-449b-bcc7-4534d3c7642b"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cb52368-46ce-4d29-8450-0ac4195621c6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
