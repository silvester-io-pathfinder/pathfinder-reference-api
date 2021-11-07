using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisarmingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e540f7-57b7-4641-a6db-6b70fc8b9068");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Stance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1720368a-077c-43cd-99fa-43dfe70b59e7"), Type = TextBlockType.Text, Text = "You adopt a fencing stance that improves your control over your weapon. While you are in this stance, you gain a +1 circumstance bonus to Athletics checks to (action: Disarm) and a +2 circumstance bonus to your Reflex DC when defending against checks to (action: Disarm) you. In addition, you can attempt to (action: Disarm) creatures up to two sizes larger than you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("85f4a204-b943-4fab-b463-6e538afa3c06"), Feats.Instances.DuelistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("4719d503-fa35-4b81-8da2-a146a69ea6a6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7746c7f1-f503-4925-a7e3-048af498bcc8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
