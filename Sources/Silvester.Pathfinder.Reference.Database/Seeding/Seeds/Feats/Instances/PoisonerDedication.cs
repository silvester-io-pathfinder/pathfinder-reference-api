using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d9195e30-fda9-4f65-bacf-c09ef3af65f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poisoner Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained at least two other feats from the poisoner archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3172167a-0bcf-4f02-83d1-81d1f3239e05"), Type = TextBlockType.Text, Text = "You make a point of always having a few toxins near at hand – you never know when some arsenic or the like might prove useful. You gain the alchemist’s infused reagents class feature, gaining a number of reagents each day equal to your level. Your advanced alchemy level for creating these is 1 and doesn’t increase on its own. You also gain the (feat: Alchemical Crafting) feat. You may only create and choose formulas for alchemical poisons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("13bffdbc-4323-4fe2-84d4-07992166ed57"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72094b11-3200-43a4-b5bf-3bd1ac888021"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
