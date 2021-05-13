using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class EtherealRune : Template
    {
        public static readonly Guid ID = Guid.Parse("76e3db46-6f8a-4a56-9459-58d0b14e2059");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Ethereal",
                RarityId = Rarities.Instances.Uncommon.ID,
                CraftingRequirements = "Supply a casting of 9th-level ethereal jaunt."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("aa6891cb-39ce-4647-b7f9-c7252ab598a1"), Type = TextBlockType.Text, Text = "An ethereal rune replicates armor on the Ethereal Plane." };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("13ef1f89-bd03-400e-960f-2cf2ffc951d5"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Command",
                Effect = "You gain the effects of an ethereal jaunt spell. This doesn’t require concentration and lasts for 10 minutes or until you choose to return to material form as a free action.",
                Frequency = "Once per day."
            };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("7645428c-8707-496a-872a-42bc584b8717"),
                Benefits = "You can gain the effects of an ethereal jaunt spell.",
                ItemLevel = 17,
                Price = 1350000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1422800-1f08-4c43-99cd-c5819ade517c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
