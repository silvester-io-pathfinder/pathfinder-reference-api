using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ResplendentMansion : Template
    {
        public static readonly Guid ID = Guid.Parse("be1eb08b-e713-4d5f-b80f-bcd86592d274");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Resplendent Mansion",
                Level = 9,
                CastTime = "1 minute.",
                Range = "500 feet.",
                Duration = "Until the next time you make your daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39878ea1-fef3-4010-9e75-e78df7c6d1e2"), Type = TextBlockType.Text, Text = "You conjure a towering mansion up to four stories tall and up to 300 feet on a side. While Casting the Spell, you hold an image of the mansion and its desired appearance in your mind. The mansion can contain as many or as few rooms as you desire, and it is decorated as you imagine it. You can imagine a purpose for each room of the mansion, and the proper accouterments appear within. Any furniture or other mundane fixtures function normally for anyone inside the mansion, but they cease to exist if taken beyond its walls. No fixture created with this spell can create magical effects, but magical devices brought into the mansion function normally." };
            yield return new TextBlock { Id = Guid.Parse("35c7cf11-efc5-45db-adcd-b025a3a1236e"), Type = TextBlockType.Text, Text = "Your mansion contains the same types and quantities of foodstuffs and servants as created by the magnificent mansion spell." };
            yield return new TextBlock { Id = Guid.Parse("cae1b934-e117-49ac-b08e-4414a0f75462"), Type = TextBlockType.Text, Text = "Each of the mansion's exterior doorways and windows are protected by alarm spells. You choose whether each alarm is audible or mental as you Cast the Spell, and each has a different sound (for an audible alarm) or sensation (for a mental one), allowing you to instantly determine which portal has been used." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5136f07b-000a-4596-8577-aa2dd6cd8b5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 364
            };
        }
    }
}
