using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("796b8829-ea8d-4ae0-926a-3d9cbc86533e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cffa6095-437b-410f-8fed-d97bfe21908b"), Type = TextBlockType.Text, Text = $"Your shapeshifting grants you a magical connection to the animal world. You can cast {ToMarkdownLink<Models.Entities.Spell>("animal messenger", Spells.Instances.AnimalMessenger.ID)}, {ToMarkdownLink<Models.Entities.Spell>("calm emotions", Spells.Instances.CalmEmotions.ID)} (animals only), and {ToMarkdownLink<Models.Entities.Spell>("speak with animals", Spells.Instances.SpeakWithAnimals.ID)} as 2nd-level primal innate spells once per day each. These spells use your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96603d43-eba1-49c1-a4ee-f9f72599ec4b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
