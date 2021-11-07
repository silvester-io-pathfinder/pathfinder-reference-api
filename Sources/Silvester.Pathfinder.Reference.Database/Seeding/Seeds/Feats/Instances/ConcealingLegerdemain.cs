using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcealingLegerdemain : Template
    {
        public static readonly Guid ID = Guid.Parse("ae4ff29a-3b4f-481d-b8f4-a4be5b7cebc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Concealing Legerdemain",
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
            yield return new TextBlock { Id = Guid.Parse("a225a8f5-77a7-4e76-8b61-0f9969d258b6"), Type = TextBlockType.Text, Text = "Rather than hide an object somewhere the inspectors won’t search, you’re skilled at keeping the object on the move so it’s never where they look. When you (action: Conceal an Object) of light Bulk or less, you can use Thievery instead of Stealth for your checks and for the DC of an active searcher’s Perception check. You roll the check only once, but you must continue to use actions to (action: Conceal an Object) throughout the process." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("aad8ce6c-be71-42a9-b833-dd6c0acd6f97"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6c82e03-f9fd-4161-9298-1986af4988f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
