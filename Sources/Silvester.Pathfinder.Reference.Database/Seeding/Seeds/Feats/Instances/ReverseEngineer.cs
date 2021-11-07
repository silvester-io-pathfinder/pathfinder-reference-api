using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReverseEngineer : Template
    {
        public static readonly Guid ID = Guid.Parse("54657eee-7048-4409-b777-0c472f5a677c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reverse Engineer",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b057d132-9ccf-43f8-ac37-52bedbf30c83"), Type = TextBlockType.Text, Text = "You are incredibly skilled at reverse engineering items to learn their formulas, or disassembling them just to disable them. You gain a +2 circumstance bonus to Crafting checks to reverse engineer a formula from an item. If you get a critical success on your Crafting check, you can opt to both create the formula and reassemble the original item at the same time, leaving you with the formula and the item instead of the formula and raw materials equal to half the item’s value. Furthermore, you can use Crafting instead of Thievery to (action: Disable a Device) or (action: Pick a Lock)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4ad2f624-a3bc-4ea1-b348-eea7e3f9af79"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("581cf506-ba8b-4167-99d8-cbadccfef568"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
