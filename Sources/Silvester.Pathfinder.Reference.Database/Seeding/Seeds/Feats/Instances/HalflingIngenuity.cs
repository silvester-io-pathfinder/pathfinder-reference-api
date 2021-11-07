using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingIngenuity : Template
    {
        public static readonly Guid ID = Guid.Parse("7d9efdf4-6865-4004-9fdc-8bb760496723");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Ingenuity",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a61dcc42-3747-47f3-b33b-7f9df02f2625"), Type = TextBlockType.Text, Text = "While your willingness to dig into a task you know little about might get you into trouble, your incredible luck often saves you from danger. You can attempt skill actions that normally require you to be trained even if you aren’t trained in that skill. If you use (Feat: Halfling Luck) when you fail a check for a skill with which you are untrained, you can add a proficiency bonus equal to your level, rather than 0, when you reroll the triggering skill check. You gain a +4 circumstance bonus to this rerolled skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e610c77b-2caf-44a2-aec5-afb78eb335db"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74f0bd06-1c92-4554-8a87-f2e4d226ee07"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
