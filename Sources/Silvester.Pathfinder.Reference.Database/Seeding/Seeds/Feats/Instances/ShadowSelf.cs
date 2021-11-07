using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowSelf : Template
    {
        public static readonly Guid ID = Guid.Parse("f4e7ca3f-a9dc-47ed-9ff5-2fe6fd6b17bb");

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
            yield return new TextBlock { Id = Guid.Parse("cf3ee306-7ed4-4335-8e86-c630a58390f4"), Type = TextBlockType.Text, Text = "With a powerful talent for misdirection, you slip from your adversaries’ notice so thoroughly you appear to be somewhere else. You become invisible for 1 minute or until you take a hostile action, whichever comes first. Choose a location within 10 feet of you. Until your invisibility ends, you appear to be hidden in that location to anyone trying to find you. If the searcher gets clear evidence that you’re not there, they no longer think you’re hidden there, but they don’t discover your actual location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a19b97f9-533a-40f9-a66e-0055379d5fdc"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("186c6d38-c480-4b42-b77c-41224bcecd47"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
