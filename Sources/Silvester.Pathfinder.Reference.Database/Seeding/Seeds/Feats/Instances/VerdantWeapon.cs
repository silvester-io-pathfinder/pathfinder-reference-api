using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerdantWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("78c4093b-41de-4b20-a4e9-6fc734b76e9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Verdant Weapon",
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
            yield return new TextBlock { Id = Guid.Parse("07b9263d-7a0b-4c39-83c7-3dc51b745e4a"), Type = TextBlockType.Text, Text = "You cultivate a seed that can sprout into a wooden staff, vine whip, or another weapon. You spend 10 minutes focusing primal energy into a seed, imprinting it with the potential of a single level 0 weapon you are trained with and that has no mechanical parts or metal components. When holding the imprinted seed, you can spend a single (action: Interact) action to cause it to immediately grow into that weapon; a second (action: Interact) action returns it to seed form. Your verdant weapon functions as the imprinted weapon and can be etched with runes or affixed with talismans as normal, which are suppressed when the weapon is in seed form. It also becomes a primal focus." };
            yield return new TextBlock { Id = Guid.Parse("175412fe-2a47-4c64-8a0a-b12c54096220"), Type = TextBlockType.Text, Text = "You can have only one verdant seed at a time. If you prepare a second, your first verdant seed immediately becomes a mundane specimen; any runes on the previous seed that are valid for the new seed transfer between them at no cost, but you lose any inapplicable runes unless you transfer them to a runestone or another weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89e30cdd-0702-4bf7-bca4-fcd1a4cfdda8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
