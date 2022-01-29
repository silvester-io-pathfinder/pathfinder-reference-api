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
    public class DualHandedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("4f8ccf29-5213-42bf-b3f1-6c6852a61e0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Handed Assault",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1570626d-8d21-4fdd-abe6-00810d4e473e"), Type = TextBlockType.Text, Text = $"You snap your free hand over to grip your weapon just long enough to add momentum and deliver a more powerful blow to your opponent. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. You quickly switch your grip during the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} in order to make the attack with two hands. If the weapon doesn't normally have the {ToMarkdownLink<Models.Entities.Trait>("two-hand", Traits.Instances.TwoHand.ID)} trait, increase its weapon damage die by one step for this attack. If the weapon has the {ToMarkdownLink<Models.Entities.Trait>("two-hand", Traits.Instances.TwoHand.ID)} trait, you gain the benefit of that trait and a circumstance bonus to damage equal to the weapon's number of damage dice. When the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is complete, you resume gripping the weapon with only one hand. This action doesn't end any stance or fighter feat effect that requires you to have one hand free." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("867baf77-c7eb-41db-9323-1eda563f5ef6"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("cfc791ac-930d-4da4-8fd9-fc09382174ed"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6761b4b2-d00a-4bf1-8b70-3dd1fa8ee506"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
