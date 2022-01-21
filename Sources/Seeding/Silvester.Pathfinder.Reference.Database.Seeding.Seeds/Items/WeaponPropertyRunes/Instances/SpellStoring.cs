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
    public class SpellStoring : Template
    {
        public static readonly Guid ID = Guid.Parse("294a6238-beb1-4b09-97c6-dc08d2f98185");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Spell-Storing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f35ebacc-afb8-4f7b-99f3-670100507cdc"), "A spell-storing rune creates a reservoir of eldritch energy within the etched weapon.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("9968c8a7-4e09-4887-b62d-2e4ae3591aec"),
                Name = "Spell-Storing",
                Usage = "Etched onto a melee weapon.",
                Level = 13,
                Price = 270000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ba1bd5b1-7d85-499c-9c30-9f4bb7e6a8e4"), "A spellcaster can spend 1 minute to cast a spell of 3rd level or lower into the weapon. The spell must have a casting of 2 actions or fewer and must be able to target a creature other than the caster. The spell has no immediate effect—it is instead stored for later. When you wield a spell-storing weapon, you immediately know the name and level of the stored spell. A spell-storing weapon found as treasure has a 50% chance of having a spell of the GM's choice stored in it.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dad2c430-281a-470e-8795-25307a5805c9"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Requirements("On your previous action this turn, you hit and damaged a creature with this weapon.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5001f656-c70c-4526-aa90-0b4e20462753"), "You unleash the stored spell, which uses the target of the triggering attack as the target of the spell. This empties the spell from the weapon and allows a spell to be cast into it again. If the spell requires a spell attack roll, the result of your attack roll with the weapon determines the degree of success of the spell, and if the spell requires a saving throw, the DC is 30.");
                            });
                    })
                    .Add(Guid.Parse("658a3787-32b5-47f2-8ccd-87a6a247fb66"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("54e0314e-f703-4e05-997e-607ec377d27f"), "Harmlessly expend the stored spell. This frees the weapon to have a new spell cast into it.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("43160ffe-29bb-40e8-90fc-f665f0564b34"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("59f3c637-259a-456a-b36e-9209f08120d7"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7769d72-1dce-4fb6-a0b6-c4c77949a356"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
