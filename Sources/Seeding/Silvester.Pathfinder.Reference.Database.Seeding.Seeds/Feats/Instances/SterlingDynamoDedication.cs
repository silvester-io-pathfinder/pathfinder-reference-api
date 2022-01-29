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
    public class SterlingDynamoDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d7f7a1e8-0eb5-4724-9da3-3c95c4d9810f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sterling Dynamo Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the sterling dynamo archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c58aafd-1f6b-45ef-9de6-19bf3fbbdc9d"), Type = TextBlockType.Text, Text = $"You obtain a sterling dynamo prosthetic, which allows you to replace or augment a limb, or even add a simple new non-prehensile limb, such as a tail. While your sterling dynamo prosthetic can replace a missing prehensile limb, such as an arm, choosing to add a new limb can never increases your character's number of hands or prehensile limbs beyond two, even in combination with other abilities or effects." };
            yield return new TextBlock { Id = Guid.Parse("e10ea268-6625-4f0e-b7a3-772556127149"), Type = TextBlockType.Text, Text = $"Your sterling dynamo prosthesis is especially optimized for combat, granting you a dynamo melee unarmed attack that is in the brawling weapon group and is made of silver (which makes it more effective against certain types of creatures, such as devils and werewolves)." };
            yield return new TextBlock { Id = Guid.Parse("bd06b817-3a70-43ea-a58e-1188a2531e6a"), Type = TextBlockType.Text, Text = $"You have several options to customize your sterling dynamo. First, choose whether you have a power driver dynamo, which deals 1d6 bludgeoning damage and has the {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)} trait, or a percussive striker dynamo, which deals 1d4 bludgeoning damage and has the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} and {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("9fc08e8b-d68b-4e8d-99af-d3cbf4f1cae8"), Type = TextBlockType.Text, Text = $"Most dynamos are automated, so they don't require a free hand to use, like other {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} attacks. However, you can instead choose to make your dynamo be manually controlled via a handheld switch, lever, or other device; to make an attack with a manually controlled dynamo, you must have a hand free to operate it, but the benefit is great control and a more devastating strike. This increases the damage die by one size, to a 1d8 for a power drive dynamo or 1d6 for a percussive striker dynamo. Arm dynamos are always manual, but they use the hand on that arm to operate the dynamo when making strikes. Manual control is required only in the heat of combat, not for less strenuous adventuring or everyday activities." };
            yield return new TextBlock { Id = Guid.Parse("326761cf-305e-41ae-95cb-457737c3cf11"), Type = TextBlockType.Text, Text = $"You need to keep your sterling dynamo wound, but the process isn't particularly onerous, so in most situations, it won't be an issue. If you spend 1 minute winding up your dynamo, it can remain active for 24 hours before needing additional winding. However, enemies can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Disable the dynamo", SkillActions.Instances.DisableADevice.ID)}, which has a level equal to your own, to reduce the remaining operational time by 1 hour, or 2 hours on a critical success. Certain other abilities that adversely affect technology might also reduce the dynamo's remaining operational time. When your dynamo is out of operational time, you can still use it as a normal prosthetic, but you cannot use your dynamo unarmed attack or any other abilities from this archetype until you wind the dynamo again. You can wind the dynamo for 1 minute at any time to return it to the maximum 24 hours of operational time." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7998802-0998-4290-b1c4-0dac0e29cdc4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
