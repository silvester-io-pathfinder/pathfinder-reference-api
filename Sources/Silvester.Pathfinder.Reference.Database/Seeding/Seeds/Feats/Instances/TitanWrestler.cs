using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TitanWrestler : Template
    {
        public static readonly Guid ID = Guid.Parse("941cab14-2bed-4c3b-9944-f2612ffaab85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan Wrestler",
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
            yield return new TextBlock { Id = Guid.Parse("389a9f6e-68b6-406f-939b-46aa9ae3f490"), Type = TextBlockType.Text, Text = "You can attempt to (action: Disarm), (action: Grapple), (action: Shove), or (action: Trip) creatures up to two sizes larger than you, or up to three sizes larger than you if you’re legendary in Athletics." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1e689682-db17-4869-9265-6d233120578c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34643364-4445-43f5-8571-0e783742fd9c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
