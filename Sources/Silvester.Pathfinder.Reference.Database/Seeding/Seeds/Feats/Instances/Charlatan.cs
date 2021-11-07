using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Charlatan : Template
    {
        public static readonly Guid ID = Guid.Parse("5dbc8b9f-35e6-4b35-af32-49168296f96c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charlatan",
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
            yield return new TextBlock { Id = Guid.Parse("d54ad388-ad39-4775-a27d-eedc19badd6d"), Type = TextBlockType.Text, Text = "You’ve learned to mimic the abilities of spellcasters by studying their flourishes and words. When you activate a magic item to generate a spell effect, attempt a Deception check. If you succeed against an onlooker’s Perception DC, to that onlooker, you appear to (activity: Cast that Spell | Cast a Spell) instead. Onlookers who successfully (feat: Recognize the Spell | Recognize Spell) realize you used a magic item, though those who later successfully (action: Identify the Magic | Identify Magic) still can’t determine that the source of the effect was a magic item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("252b642d-1546-4519-8bd4-250b8d1263e0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdef8b0f-edd4-4d69-b44f-6d19f7e0a2a6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
