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
    public class EmblazonArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("a512f4b4-75a9-411f-bf1a-f44d268dfc5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Armament",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("231ca03b-b739-40be-80db-55e953bfc7f9"), Type = TextBlockType.Text, Text = $"Carefully etching a sacred image into a physical object, you steel yourself for battle. You can spend 10 minutes emblazoning a symbol of your deity upon a weapon or shield. The symbol doesn't fade until 1 year has passed, but if you Emblazon an Armament, any symbol you previously emblazoned and any symbol already emblazoned on that item instantly disappears. The item becomes a religious symbol of your deity and can be used as a divine focus while emblazoned, and it gains another benefit determined by the type of item. This benefit applies only to followers of the deity the symbol represents." };
            yield return new TextBlock { Id = Guid.Parse("67a16e08-1cbe-43c4-8488-eb1bec83b70c"), Type = TextBlockType.Enumeration, Text = $" Shield: The shield gains a +1 status bonus to its Hardness. (This causes it to reduce more damage with the {ToMarkdownLink<Models.Entities.Ability>("Shield Block", Abilities.Instances.ShieldBlock.ID)} reaction.)" };
            yield return new TextBlock { Id = Guid.Parse("97e7e2ca-bd24-4e53-bc1f-cf912df8457f"), Type = TextBlockType.Enumeration, Text = $" Weapon: The wielder gains a +1 status bonus to damage rolls." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f456bf0a-7bb8-48cc-b0aa-43638aa94883"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("af375c09-921b-447a-ab34-9a520de62be6"), Traits.Instances.Exploration.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66c2032d-7830-4874-b882-208dcb43ab5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
