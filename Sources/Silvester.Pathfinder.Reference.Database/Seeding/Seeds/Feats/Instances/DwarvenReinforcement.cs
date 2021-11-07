using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DwarvenReinforcement : Template
    {
        public static readonly Guid ID = Guid.Parse("e9d6cf33-97d7-461b-8bd1-9cc775b652da");

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
            yield return new TextBlock { Id = Guid.Parse("e1aa34ac-30d9-4c03-bfee-1a49c5990b64"), Type = TextBlockType.Text, Text = "You can use your knowledge of engineering and metalwork to temporarily strengthen thick objects and structures. By spending 1 hour working on an item, you can give it a +1 circumstance bonus to its Hardness for 24 hours. If you’re a master in Crafting, the bonus is +2, and if you’re legendary, the bonus is +3. You can reinforce a portion of a structure, though 1 hour usually reinforces only a door, a few windows, or another section that fits within a 10-foot cube." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9373e32f-c8c1-4e8a-9c56-d11336fe68fd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efd68f2b-a3e5-462b-ba85-97d742bb9a7d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
