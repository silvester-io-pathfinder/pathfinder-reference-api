using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LinguistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4c81e445-aa4c-4d5b-ac99-52a59e0f415b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Linguist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the linguist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b63af53a-ac8b-413e-890d-72798acacc0e"), Type = TextBlockType.Text, Text = "You have studied languages and their development. You become trained in Society; if you were already trained in Society, you instead become an expert in Society. You gain the (feat: Multilingual) skill feat twice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLanguageAmount(Guid.Parse("a606a997-2fa3-404f-a621-be8f7a1b5759"), Comparator.GreaterThanOrEqualThan, amount: 3);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("babc5fb4-3e82-4975-a44f-96a5127f7f70"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
