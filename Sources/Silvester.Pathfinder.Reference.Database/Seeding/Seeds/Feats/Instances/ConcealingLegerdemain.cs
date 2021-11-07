using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcealingLegerdemain : Template
    {
        public static readonly Guid ID = Guid.Parse("d6a00711-1d12-45d8-aaa3-37614b17dfc6");

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
            yield return new TextBlock { Id = Guid.Parse("aa49fdf3-49b4-4a23-8873-e8702faeb1dc"), Type = TextBlockType.Text, Text = "Rather than hide an object somewhere the inspectors won’t search, you’re skilled at keeping the object on the move so it’s never where they look. When you (action: Conceal an Object) of light Bulk or less, you can use Thievery instead of Stealth for your checks and for the DC of an active searcher’s Perception check. You roll the check only once, but you must continue to use actions to (action: Conceal an Object) throughout the process." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1d269d31-09fc-4564-a4ed-ed15a3d2b862"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9d6c289-58ab-4daf-952b-ad5287aad1c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
