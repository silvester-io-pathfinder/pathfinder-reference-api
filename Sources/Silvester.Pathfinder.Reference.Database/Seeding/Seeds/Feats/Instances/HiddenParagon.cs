using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HiddenParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("12de23ef-86b5-4780-947e-aea5c81698fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hidden Paragon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully use Stealth to Hide and become hidden from all of your current foes, or use Stealth to Sneak and become undetected to all your current foes.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc994704-0652-4f91-8fe1-a29f162e7671"), Type = TextBlockType.Text, Text = "When you put your mind to slipping out of sight, you disappear completely. You become invisible for 1 minute, even if you use a hostile action. Not even (spell: glitterdust), (spell: see invisibility), or similar effects can reveal you, though creatures can still use the (action: Seek) action to locate you as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f56bba25-9ba5-4698-a744-eb73a356bfd0"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b5a5880-c9fe-4ced-bd58-d2783ac12a4b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
