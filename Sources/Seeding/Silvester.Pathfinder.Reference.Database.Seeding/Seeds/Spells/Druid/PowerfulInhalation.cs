using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PowerfulInhalation : Template
    {
        public static readonly Guid ID = Guid.Parse("e4c3ea9a-21a1-4d6d-9b9b-fb0401f2b5d8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Powerful Inhalation",
                Level = 3,
                Area = "10-foot emanation.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c014d97f-7221-40ee-a294-36af6dbe861f"), Type = TextBlockType.Text, Text = "You rapidly draw the air from your surroundings, hoarding it for yourself. Creatures in the area when the spell is cast take 5d6 bludgeoning damage with a basic Fortitude save. A creature that fails its save can�t speak above a raspy whisper for 1 round. A creature that critically fails can�t speak or use abilities that require it to breathe for 1 round. This prevents it from using effects that require speech, such as casting spells with verbal components, and from using a breath weapon or similar ability." };
            yield return new TextBlock { Id = Guid.Parse("7ab1e6bf-f65d-4636-898f-bbbece9a8aef"), Type = TextBlockType.Text, Text = "Creatures made of air (such as air elementals) attempting a save against this spell get a degree of success one worse than they rolled." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("33a93362-668f-494c-a0f8-36cc8b679332"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1e543ae7-cabe-495b-9ec6-29fe6c5d5090"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6." }
                }
            };
        }
        
        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58c42c1b-9165-4ea0-a2fe-ee1da493828e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}