using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerdantWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("1f219ded-f10e-449b-aca7-304cd12016ff");

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
            yield return new TextBlock { Id = Guid.Parse("998c9610-783b-4dfa-acdc-9fa76de8287e"), Type = TextBlockType.Text, Text = "You cultivate a seed that can sprout into a wooden staff, vine whip, or another weapon. You spend 10 minutes focusing primal energy into a seed, imprinting it with the potential of a single level 0 weapon you are trained with and that has no mechanical parts or metal components. When holding the imprinted seed, you can spend a single (action: Interact) action to cause it to immediately grow into that weapon; a second (action: Interact) action returns it to seed form. Your verdant weapon functions as the imprinted weapon and can be etched with runes or affixed with talismans as normal, which are suppressed when the weapon is in seed form. It also becomes a primal focus." };
            yield return new TextBlock { Id = Guid.Parse("21139795-78d1-44a0-b74e-3e8299d354a7"), Type = TextBlockType.Text, Text = "You can have only one verdant seed at a time. If you prepare a second, your first verdant seed immediately becomes a mundane specimen; any runes on the previous seed that are valid for the new seed transfer between them at no cost, but you lose any inapplicable runes unless you transfer them to a runestone or another weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3e87d69-378e-468a-af02-c95cab6ad738"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
