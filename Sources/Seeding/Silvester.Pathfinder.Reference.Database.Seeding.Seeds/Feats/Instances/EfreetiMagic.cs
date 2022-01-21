using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EfreetiMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("625b2572-56f7-447f-8494-542b2353879d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efreeti Magic",
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
            yield return new TextBlock { Id = Guid.Parse("e4b1b6f1-7cb3-4e8a-9a88-2f953fcbf215"), Type = TextBlockType.Text, Text = $"The magic of your efreeti ancestors flows through you. You can cast {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)} and {ToMarkdownLink<Models.Entities.Spell>("illusory object", Spells.Instances.IllusoryObject.ID)} once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("135acc29-e3e9-4d6b-abce-2daaf2f86315"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
