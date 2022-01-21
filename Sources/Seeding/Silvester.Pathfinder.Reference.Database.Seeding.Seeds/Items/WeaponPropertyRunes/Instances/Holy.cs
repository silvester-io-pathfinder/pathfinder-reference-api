using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Holy : Template
    {
        public static readonly Guid ID = Guid.Parse("0347c95e-2227-4c7c-92f2-d37d77e78e7d");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Holy",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("86c792b6-6ee5-46a1-9688-3799a701c313"),
                Name = "Holy",
                Usage = "Etched onto a weapon without an unholy rune.",
                CraftingRequirements = "You are good.",
                Price = 140000,
                Level = 11,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("af94facc-6c5b-47fe-a33e-cb9711835db1"), "Holy weapons command powerful celestial energy. A weapon with this rune deals an extra 1d6 good damage against evil targets. If you are evil, you are enfeebled 2 while carrying or wielding this weapon.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d2975b34-2c3a-4eb1-9dbe-8cc0fa325187"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Trigger("You critically succeed at an attack roll against an evil creature with the weapon.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("9d0cb068-9cc3-445f-b507-affe8b0e9470"), "You regain HP equal to double the evil creature's level. This is a good, positive, healing effect.");
                            });
                    })
                    .Build()

            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("07854db5-1e82-42ff-b658-6b76bbed96e1"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1e3270d3-3b0f-417d-85d1-5f82b44258a1"), Traits.Instances.Good.ID);
            builder.Add(Guid.Parse("450cb329-d536-402e-89b8-cebc8a5aee85"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2f90062-1822-4d66-b634-4704a77549e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
