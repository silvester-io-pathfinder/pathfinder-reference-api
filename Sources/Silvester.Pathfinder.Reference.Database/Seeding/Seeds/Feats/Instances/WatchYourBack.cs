using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WatchYourBack : Template
    {
        public static readonly Guid ID = Guid.Parse("13fe8cff-0ee7-4468-8f38-dbf1251fd9eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watch Your Back",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8114991-6a46-4958-b163-d7bf2ba1db35"), Type = TextBlockType.Text, Text = "You menace the target, stoking their fears and drawing their attention. Attempt an Intimidation check against the Will DC of a target within 30 feet. If you succeed, for 1 minute, that target gains a +2 status bonus to Perception checks against you, but they take a –2 status penalty to Will saves against fear effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9374fc8b-36e3-486b-a067-7a295cf694ae"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8341b52-8760-4db4-a1ea-a1bf7c4ba6c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
