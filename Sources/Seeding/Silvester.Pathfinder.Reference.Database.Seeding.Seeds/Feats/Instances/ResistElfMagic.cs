using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResistElfMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("2c29ea9b-2428-41b4-b86e-448195052e95");

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
            yield return new TextBlock { Id = Guid.Parse("c5798e7e-74b6-4873-a443-0ebef968dd5d"), Type = TextBlockType.Text, Text = $"Your ancestral resistance to magic protects you. You gain a +1 circumstance bonus to the triggering saving throw. If the triggering effect is arcane, you gain a +2 circumstance bonus instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a731f16-a706-4738-bc0c-7ef4468e89c7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
