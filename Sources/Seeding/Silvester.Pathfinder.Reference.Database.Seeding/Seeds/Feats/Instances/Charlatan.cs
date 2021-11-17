using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Charlatan : Template
    {
        public static readonly Guid ID = Guid.Parse("f13f7aa7-1332-4522-b452-a8a15de61415");

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
            yield return new TextBlock { Id = Guid.Parse("bbc59668-dfa8-4d2d-8804-0b84f671c4f2"), Type = TextBlockType.Text, Text = "You’ve learned to mimic the abilities of spellcasters by studying their flourishes and words. When you activate a magic item to generate a spell effect, attempt a Deception check. If you succeed against an onlooker’s Perception DC, to that onlooker, you appear to (activity: Cast that Spell | Cast a Spell) instead. Onlookers who successfully (feat: Recognize the Spell | Recognize Spell) realize you used a magic item, though those who later successfully (action: Identify the Magic | Identify Magic) still can’t determine that the source of the effect was a magic item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bd7a74a0-2c14-4340-a179-cc8124009903"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80228fed-def4-4427-bbe3-4871e0cad0de"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
