using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShokisArgument : Template
    {
        public static readonly Guid ID = Guid.Parse("d26a4b19-3aae-47c1-a36e-bc4a294f09fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoki's Argument",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4724ad5d-d922-424e-843d-7df0a024b320"), Type = TextBlockType.Text, Text = $"You feel a connection to shokis, the rambling collectors of wayward souls, and might have found old texts written by one. You are trained in Diplomacy. If you were already trained in Diplomacy (from your background or class, for example), you instead become trained in a skill of your choice. You can also cast {ToMarkdownLink<Models.Entities.Spell>("disrupt undead", Spells.Instances.DisruptUndead.ID)} as a divine innate cantrip at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d2a4f38-dc71-423d-9e93-7e67669f025b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
