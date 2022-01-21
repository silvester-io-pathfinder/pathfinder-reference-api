using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EstablishWard : Template
    {
        public static readonly Guid ID = Guid.Parse("d7fae3da-a6ec-4a1d-a907-62786bd02dd0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Establish Ward",
                Level = 5,
                Area = "30-foot burst.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0580045-3e46-427d-8308-397250cd880f"), Type = TextBlockType.Text, Text = "You bind a part of your essence to your surroundings, creating a warded area that grants you power within it, but drains you outside of it. While within the area, you can make nature's wrath Strikes by commanding plants, wind, rocks, and other natural features to attack enemies. These are melee Strikes that use your spell attack modifier, can target any creature within the ward, and deal bludgeoning, piercing, or slashing damage equal to 2d8 plus your spellcasting ability modifier." };
            yield return new TextBlock { Id = Guid.Parse("d8e5760f-99bd-42a3-97ed-2842ff3206ab"), Type = TextBlockType.Text, Text = "Upon Casting the Spell, you can immediately make a single nature's wrath Strike. You are quickened while inside the ward, and can use the additional action only to make nature's wrath Strikes. You are slowed 1 while outside the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("787b8dda-68fa-46d6-9c0b-aacea77db3e3"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("303bfcbf-344d-488e-8367-6d0b670a0065"), Type = TextBlockType.Text, Text = "The area increases by 5 feet, and the Strikes deal an additional 1d8 damage." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7103f0d1-1444-4859-bb50-137116205c98"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9c403838-6495-4f2e-88ac-ae6c7d3d3791"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("8ba31b82-cdf6-4f90-8d31-4551ba3859f3"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d01616dc-165b-41f9-a6d7-ceb16490c6d5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
