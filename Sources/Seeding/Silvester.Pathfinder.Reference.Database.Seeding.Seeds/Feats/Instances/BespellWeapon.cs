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
    public class BespellWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("0575d610-36e4-4717-9bd1-ed7a7bfe00de");

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
            yield return new TextBlock { Id = Guid.Parse("38618d6f-47e0-42d9-90f7-b841160a5829"), Type = TextBlockType.Text, Text = $"You siphon the residual energy from the last spell you cast into one weapon you're wielding. Until the end of your turn, the weapon deals an extra 1d6 damage of a type depending on the school of the spell you just cast." };
            yield return new TextBlock { Id = Guid.Parse("77086140-9983-4625-a4d4-147ca5b85f77"), Type = TextBlockType.Enumeration, Text = $" Abjuration: force damage" };
            yield return new TextBlock { Id = Guid.Parse("c7165f4e-86c7-4dd9-a21a-95158094d262"), Type = TextBlockType.Enumeration, Text = $" Conjuration or Transmutation: the same type as the weapon" };
            yield return new TextBlock { Id = Guid.Parse("1dd8d209-2aa7-41d6-8dd8-1224dd7bac11"), Type = TextBlockType.Enumeration, Text = $" Divination, Enchantment, or Illusion: mental damage" };
            yield return new TextBlock { Id = Guid.Parse("b2c4a5a6-c4fa-42c1-b0f8-45b7a4e8645d"), Type = TextBlockType.Enumeration, Text = $" Evocation: a type the spell dealt, or force damage if the spell didn't deal damage" };
            yield return new TextBlock { Id = Guid.Parse("27440357-8a7f-42f5-9b46-90046016eb0a"), Type = TextBlockType.Enumeration, Text = $" Necromancy: negative damage" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb57c222-868c-4931-9b30-fe5c0c8eca40"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
