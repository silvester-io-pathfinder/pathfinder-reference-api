using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowSelf : Template
    {
        public static readonly Guid ID = Guid.Parse("e230e321-e0a0-40c5-b9ed-9343b1dc3513");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Self",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully use Stealth to Hide and become hidden from all your current foes, or use Stealth to Sneak and become undetected to all your current foes.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff8f1051-0350-4654-859d-76a6f6568cd1"), Type = TextBlockType.Text, Text = "With a powerful talent for misdirection, you slip from your adversaries' notice so thoroughly you appear to be somewhere else. You become invisible for 1 minute or until you take a hostile action, whichever comes first. Choose a location within 10 feet of you. Until your invisibility ends, you appear to be hidden in that location to anyone trying to find you. If the searcher gets clear evidence that you're not there, they no longer think you're hidden there, but they don't discover your actual location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e121dfcc-932c-4960-b71a-f986a0104c8a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e6448a2-06a9-4d75-bdf7-705826dc4db7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
