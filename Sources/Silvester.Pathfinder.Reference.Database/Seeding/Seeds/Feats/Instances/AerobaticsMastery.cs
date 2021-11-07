using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AerobaticsMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("4980e53d-cf94-46f6-ba1e-45b2a1cfb1d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aerobatics Mastery",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9505e2a2-55fd-4ff4-a6b5-ce8060e6d449"), Type = TextBlockType.Text, Text = "You move with grace in flight and can perform amazing aerial stunts. You gain a +2 circumstance bonus to Acrobatics checks to (action: Maneuver in Flight) and can combine two maneuvers into a single action, such as reversing direction while making a steep ascent or descent or hovering in gale-force winds. The DC of the Acrobatics check is equal to the DC of the most difficult maneuver + 5. If you’re legendary in Acrobatics, you can combine three such maneuvers into a single action; the DC of the Acrobatics check is equal to the DC of the most difficult maneuver + 10. Regardless of the combination, these maneuvers rarely allow you to move farther than your fly Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e859227a-94d6-4092-bb57-e3ac666aaec0"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3215f035-be54-4adb-9352-13d4492e0667"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
