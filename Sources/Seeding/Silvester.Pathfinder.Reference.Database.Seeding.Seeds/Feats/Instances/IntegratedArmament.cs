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
    public class IntegratedArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("6b4ffa44-be6b-4d6b-bf10-1d68f51680af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Integrated Armament",
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
            yield return new TextBlock { Id = Guid.Parse("c51a8b7c-d247-4403-93bc-acc50c373139"), Type = TextBlockType.Text, Text = $"Your mechanical body houses a weapon or shield that you can quickly draw and stow, leaving you prepared for combat at all times." };
            yield return new TextBlock { Id = Guid.Parse("91f2a8ae-6983-456a-9a8f-64beed6dc7aa"), Type = TextBlockType.Text, Text = $"You can use a 1-minute activity, which has the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait, to integrate a single, one-handed weapon or shield into one of your arms. You can draw or stow this item as an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action. Creatures don't automatically see this integrated item when it's stowed and must actively {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} in order to find it. They take a –2 circumstance penalty to any checks to do so. While you are wielding the item, it can't be {ToMarkdownLink<Models.Entities.SkillAction>("Disarmed", SkillActions.Instances.Disarm.ID)} and you can't drop or {ToMarkdownLink<Models.Entities.Action>("Release", Actions.Instances.Release.ID)} it; you must {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to store the weapon and free that hand. A creature determined to retrieve the item can do so, but it requires either 1 minute to remove it or extreme violence to your arm—such as physically removing portions of the limb. You can only have one integrated armament at a time, though you can use the 1-minute activity to replace the item or swap the arm in which it's stored." };
            yield return new TextBlock { Id = Guid.Parse("95520d87-825d-4701-b11d-a0b81609f385"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("7eaf48d1-50d8-47cb-9532-5982941ad3ac"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your body has more space for integration. You can now either integrate two one-handed weapons, a one-handed weapon and a shield, or a single two-handed weapon which is split across both arms. You can use a single {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to draw or store both integrated armaments. When you draw a single weapon, you can choose to hold it with either one hand or both hands." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e89f649c-b7b4-4a0c-9ca4-7fd8a7512511"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
