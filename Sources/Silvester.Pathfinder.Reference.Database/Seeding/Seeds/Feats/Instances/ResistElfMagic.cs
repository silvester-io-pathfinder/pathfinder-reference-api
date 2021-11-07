using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResistElfMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("7dfc366b-1319-4b42-93ca-d6c2b95af019");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resist Elf Magic",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a magical effect but haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42615126-e63d-49ae-9665-b4ce86cce9f0"), Type = TextBlockType.Text, Text = "Your ancestral resistance to magic protects you. You gain a +1 circumstance bonus to the triggering saving throw. If the triggering effect is arcane, you gain a +2 circumstance bonus instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55321465-2711-4f8b-81b2-1fdf5efa2415"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
