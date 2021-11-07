using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReverseEngineering : Template
    {
        public static readonly Guid ID = Guid.Parse("2a4729b3-4540-4d0a-8cd1-d6ff369ff7fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reverse Engineering",
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
            yield return new TextBlock { Id = Guid.Parse("1a8887dd-5f7e-4790-aa01-8a914c82c0d3"), Type = TextBlockType.Text, Text = "You are able to reverse engineer items into formulas more effectively than most. You gain a +2 circumstance bonus to Crafting checks to reverse engineer a formula from an item. Additionally, if you get a critical success on your Crafting check, you can opt to not only create the formula but also reassemble the original item at the same time, leaving you with the formula and the item instead of the formula and raw materials equal to half the item’s value." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("433a490f-3fc2-4b5c-8e90-c25237867c58"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("e4093b5f-4743-4797-b086-e9b808c68301"), Feats.Instances.ScroungerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f16ce018-cf2d-423e-bbbd-99df2f24a829"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
