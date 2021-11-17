using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HiddenParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("a5ba0e11-4d90-4d95-89b1-6ea4d3aa4feb");

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
            yield return new TextBlock { Id = Guid.Parse("e376207e-8e3f-4261-b29c-532fb97abfe1"), Type = TextBlockType.Text, Text = "When you put your mind to slipping out of sight, you disappear completely. You become invisible for 1 minute, even if you use a hostile action. Not even (spell: glitterdust), (spell: see invisibility), or similar effects can reveal you, though creatures can still use the (action: Seek) action to locate you as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("616887f7-8805-4d87-abaa-15bab7f1dbaa"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eba4bcd1-f1ab-46db-b4be-d6ee9a85d4fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}