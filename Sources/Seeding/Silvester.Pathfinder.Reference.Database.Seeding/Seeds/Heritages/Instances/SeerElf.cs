using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SeerElf : Template
    {
        public static readonly Guid ID = Guid.Parse("f95169fa-400b-446e-8ba2-0dca02ada9bc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Seer Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("42be6acf-45e9-4685-abe8-45033d3bd3e7"), Type = TextBlockType.Text, Text = "You have an inborn ability to detect and understand magical phenomena. You can cast the detect magic cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse("3e380c7f-d58a-4567-b906-9a2ab3043b53"), Type = TextBlockType.Text, Text = "In addition, you gain a +1 circumstance bonus to checks to Identify Magic and to Decipher Writing of a magical nature. These skill actions typically use the Arcana, Nature, Occultism, or Religion skill." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse("1dd58777-da1a-4191-b2a0-69e24265647c"), Spells.Instances.DetectMagic.ID, MagicTraditions.Instances.Arcane.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2430d97-6515-4671-963c-e20e60c2b300"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 40
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
