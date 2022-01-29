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
    public class UnexpectedShift : Template
    {
        public static readonly Guid ID = Guid.Parse("8f3980e9-4820-44e8-9f23-83c77dd4adc0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unexpected Shift",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take damage from an attack, spell, or other effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8b425fa-26d8-4002-a538-d22460655ba1"), Type = TextBlockType.Text, Text = $"Your supernatural connection sometimes causes you to phase from reality when under threat, disappearing for split seconds before reappearing - often surprising you as much as your enemies. Roll a DC 16 flat check. On a success, you gain resistance to all damage equal to your level against the triggering effect, you gain a +2 circumstance bonus to saving throws against that effect until the start of your turn, and you gain the dazzled condition for 1 round." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3757a09b-12c3-4e5f-8545-0e93f9254201"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
