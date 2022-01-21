using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DwarvenReinforcement : Template
    {
        public static readonly Guid ID = Guid.Parse("ea736d62-661b-4e1f-9ba1-690d9aa8863a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dwarven Reinforcement",
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
            yield return new TextBlock { Id = Guid.Parse("3f46839f-d617-44cb-9d2a-8aaa706bfe0c"), Type = TextBlockType.Text, Text = $"You can use your knowledge of engineering and metalwork to temporarily strengthen thick objects and structures. By spending 1 hour working on an item, you can give it a +1 circumstance bonus to its Hardness for 24 hours. If you're a master in Crafting, the bonus is +2, and if you're legendary, the bonus is +3. You can reinforce a portion of a structure, though 1 hour usually reinforces only a door, a few windows, or another section that fits within a 10-foot cube." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("86c9adf0-1fab-4c9b-a50a-34fb6f5b31ac"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90890f9c-f01b-40ef-9da2-887e92ce9d1c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
