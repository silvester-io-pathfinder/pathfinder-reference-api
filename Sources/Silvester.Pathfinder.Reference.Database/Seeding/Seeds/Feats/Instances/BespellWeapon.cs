using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BespellWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("d417dd31-e850-4d08-a3bf-7b0282266d46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bespell Weapon",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5bd498c9-fdc7-4d27-a588-24241504b39b"), Type = TextBlockType.Text, Text = "You siphon the residual energy from the last spell you cast into one weapon you’re wielding. Until the end of your turn, the weapon deals an extra 1d6 damage of a type depending on the school of the spell you just cast." };
            yield return new TextBlock { Id = Guid.Parse("756b48fd-b2af-4602-80e9-fff29b3cda54"), Type = TextBlockType.Enumeration, Text = " Abjuration: force damage" };
            yield return new TextBlock { Id = Guid.Parse("3977c64b-b7b5-42a3-bfa5-80e2cdd1c8c1"), Type = TextBlockType.Enumeration, Text = " Conjuration or Transmutation: the same type as the weapon" };
            yield return new TextBlock { Id = Guid.Parse("94e38e5f-1265-465c-bdbd-25be1a3cebc8"), Type = TextBlockType.Enumeration, Text = " Divination, Enchantment, or Illusion: mental damage" };
            yield return new TextBlock { Id = Guid.Parse("5fe87aa8-141e-45e8-86c8-485a2f435132"), Type = TextBlockType.Enumeration, Text = " Evocation: a type the spell dealt, or force damage if the spell didn’t deal damage" };
            yield return new TextBlock { Id = Guid.Parse("2685c7a2-2d7b-4d84-be98-2e6f0f7dd139"), Type = TextBlockType.Enumeration, Text = " Necromancy: negative damage" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dacefec2-1dcb-4a81-a653-712d8b644701"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
