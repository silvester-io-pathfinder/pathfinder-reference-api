using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousCuriosityOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("96675071-92c8-4b5c-98a3-78c5d6d2ec4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Curiosity - Occult",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d17e1121-1f78-49f1-a828-4dfedf19dd50"), Type = TextBlockType.Text, Text = $"You gain {ToMarkdownLink<Models.Entities.Spell>("misdirection", Spells.Instances.Misdirection.ID)} and {ToMarkdownLink<Models.Entities.Spell>("silence", Spells.Instances.Silence.ID)} as 2nd-level occult innate spells. You can cast each spell once per day and can target only yourself." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9626a080-3ef0-4416-b07e-112aa08bae51"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
