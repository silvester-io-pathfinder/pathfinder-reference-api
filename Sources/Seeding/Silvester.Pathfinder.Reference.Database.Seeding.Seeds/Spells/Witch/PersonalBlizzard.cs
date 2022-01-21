using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PersonalBlizzard : Template
    {
        public static readonly Guid ID = Guid.Parse("09174920-3fb3-4bf3-a380-7779901e35af");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Personal Blizzard",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f51ff63-e319-4e18-baa5-400a920c1089"), Type = TextBlockType.Text, Text = "You summon an isolated blizzard of obscuring, scouring ice to follow your target. The target attempts a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb3733a8-e049-4d42-a55a-3a4070971b62"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("79dd342c-8f67-4f35-82c9-4f88fc8f940b"), Type = TextBlockType.Text, Text = "The cold damage and persistent cold damage increase by 1 (2 on a critical failure)." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c4fc6718-9756-49f1-919b-2b393818ac76"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 1d6 cold damage, and the spell ends.",
                Failure = "The target takes 1d6 cold damage and 1d6 persistent cold damage. (The persistent damage automatically ends when the spell ends.) It is concealed to other creatures, and other creatures are concealed to it.",
                CriticalFailure = "As failure, but both the cold damage and the persistent cold damage increase to 2d6."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5dd079c8-96c5-43fd-82ae-637b79d0720b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("95d1fd2f-e48e-4648-8e75-98cdd2a5d1e2"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("601d82f8-2dd4-422e-b393-f8ec96ae39a4"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("bf993044-3e9c-4d96-815d-45e3fec1b729"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("527ab12e-bfe0-4b0a-94fd-f69fec4bd8e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
